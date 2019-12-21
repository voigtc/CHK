using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CV_Checking
{
   public delegate void StatusHandler(string stat);
   public delegate void BalanceItemsClearedHandler();
   public delegate void TransactionChangedHandler();
   public delegate void TransactionRemovedHandler();
     
   [Serializable]
   class Register
   {
      public static event StatusHandler _Status;
      public static event BalanceItemsClearedHandler _BalanceItemsCleared;
      
      const string DATAFILE = "data.bin";
      const string DATA_BAK_DIR = ".\\DataBackup\\";
      
      // Seriazable Data
      List<Transaction> data = new List<Transaction>();
      List<Transaction> bankData = new List<Transaction>();
      decimal bankBalance = 0;
      
      // Internal data so it is not serialized  Call Compute to calculate these amounts
      internal decimal Balance            = 0;
      internal decimal TotalCredits       = 0;
      internal decimal TotalDebits        = 0;
      internal decimal TotalUncleared     = 0;
      internal decimal TotalBuckets       = 0;
      internal decimal TotalDiscrepancies = 0;
      internal bool    bTransactionListModified  = false;     
      
      private static string password;
      
      /// <summary>
      /// Parameterless constructor for serialization
      /// </summary>
      public Register()
      {
      }
      
      #region INTERFACES
      /// <summary>
      /// Returns List of Register Transaction Data (including buckets)
      /// </summary>
      public List<Transaction> Data
      {
         get { return data;  }
         set { data = value; }
      }
      
      /// <summary>
      /// Returns List of imported Bank Data
      /// </summary>
      public List<Transaction> BankData
      {
         get { return bankData;  }
         set { bankData = value; }
      }
      
      public decimal BankBalance
      {
         get { return bankBalance;  }
         set { bankBalance = value; }
      }
      
      /// <summary>
      /// Computes the current balance (credit_sum - debit_sum)
      /// Also calculates:  TotalCredits, TotalDebits, TotalUncleared, TotalBuckets, TotalDiscrepancies
      /// </summary>
      /// <returns></returns>
      public decimal Compute()
      {
         // Reset Sums
         Balance        = 0;
         TotalCredits   = 0;
         TotalDebits    = 0;
         TotalUncleared = 0;
         TotalBuckets   = 0;
         int seqMax = 0;
         foreach (Transaction t in data)//for (int i = 0; i < data.Count; i++)
         {
            if (t.GetType() == typeof(Bucket))
            {
               TotalBuckets += t.Amount;
            }
            
            Balance += t.Amount;

            if (t.Amount > 0)
            {
               TotalCredits += t.Amount;
            }
            else
            {
               TotalDebits -= t.Amount;
            }
            
            if (t.Cleared == false)
            {
               TotalUncleared += t.Amount;
            }
            
            if (t.ID > seqMax)
            {
               seqMax = t.ID;
            }
         }
         Transaction.SEQUENCE_NEXT = seqMax+1;
         Balance = TotalCredits - TotalDebits;
         TotalDiscrepancies = BankBalance - (Balance - TotalUncleared);

         // Round all values to 2 decimal places ($$$)
         Balance              = decimal.Round(Balance, 2);
         TotalCredits         = decimal.Round(TotalCredits, 2);
         TotalDebits          = decimal.Round(TotalDebits,2);
         TotalUncleared       = decimal.Round(TotalUncleared, 2);
         TotalBuckets         = decimal.Round(TotalBuckets, 2);
         TotalDiscrepancies   = decimal.Round(TotalDiscrepancies, 2);
         
         return Balance;
      }
      
      /// <summary>
      /// Clears all 'register data' and 'bank data' transactions' Modified flag.
      /// </summary>
      private void ClearModifiedFlags()
      {
         bTransactionListModified = false;
         foreach (Transaction t in data)
         {
            t.Modified = false;
         }
         foreach (Transaction t in bankData)
         {
            t.Modified = false;
         }
      }

      /// <summary>
      /// Returns true if any transaction has been modified, false otherwise
      /// </summary>
      /// <returns></returns>
      internal bool Modified()
      {
         if (bTransactionListModified)
         {
            return true;
         }
         foreach (Transaction t in data)
         {
            if (t.Modified)
            {
               return true;
            }
         }
         foreach (Transaction t in bankData)
         {
            if (t.Modified)
            {
               return true;
            }
         }
         return false;
      }
      #endregion INTERFACES

      private static void Fire_Status(string s)
      {
         if (_Status != null)
         {
            _Status(s);
         }
      }

      #region LOAD/SAVE
      public static Register Load(string key)
      {
         password = key;
         Register r = new Register();
         Stream stream = null;
         MemoryStream memStr = null;
         try
         {
            Fire_Status("Loading File " + DATAFILE);
            FileInfo fi = new FileInfo(DATAFILE);
            if (!fi.Exists)
            {
               MessageBox.Show("Couldn't find data file:  " + DATAFILE);
               return r;
            }
            if (fi.Exists && fi.IsReadOnly)
            {
               fi.Attributes = fi.Attributes ^ FileAttributes.ReadOnly; // Clear the Readonly flag.
            }

            // Create a backup copy so we can undo any changes we may have made erroneously
            if (Directory.Exists(DATA_BAK_DIR) == false)
            {
               Directory.CreateDirectory(DATA_BAK_DIR);
            }
            Fire_Status("BACKING UP DATA FILE TO DIRECTORY " + DATA_BAK_DIR);
            File.Copy(DATAFILE, DATA_BAK_DIR + DateTime.Now.ToString("yyyyMMdd_hhmmss_") + DATAFILE);
            // Delete backup data files older than 31 days old
            DirectoryInfo di = new DirectoryInfo(DATA_BAK_DIR);
            FileInfo []files = di.GetFiles("*" + DATAFILE);
            foreach (FileInfo f in files)
            {
               TimeSpan ts = new TimeSpan(DateTime.Now.Ticks - f.LastWriteTime.Ticks);
               if (ts.TotalDays > 31)
               {
                  f.Delete();
               }
            }
            
            Fire_Status("Loading File " + DATAFILE);
            // Read data from file, Decrypt, then Deserialize the data.
            stream = new FileStream(DATAFILE, FileMode.Open);
            byte [] encryptedBytes = new byte[stream.Length];
            stream.Read(encryptedBytes, 0, encryptedBytes.Length);
            memStr = new MemoryStream(encryptedBytes);
          //memStr = new MemoryStream(Encrypter.Decrypt(encryptedBytes, password)); // Uncomment to encrypt
            IFormatter formatter = new BinaryFormatter();
            r = (Register)formatter.Deserialize(memStr);
            r.ClearModifiedFlags();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error Loading data file:  " + DATAFILE + "\r\n\r\n" + ex.Message,
                                   "Recipe Load", System.Windows.Forms.MessageBoxButtons.OK);
            r = null;
         }
         finally
         {
            if (stream != null)
            {
               stream.Close();
            }
            if (memStr != null)
            {
               memStr.Close();
            }
         }
         Fire_Status("Loading File " + DATAFILE + " Complete");
         return r;
      }

      public void Save()
      {
         Stream stream = null;
         MemoryStream memStr = null;
         try
         {
            FileInfo fi = new FileInfo(DATAFILE);
            if (fi.Exists && fi.IsReadOnly)
            {
               fi.Attributes = fi.Attributes ^ FileAttributes.ReadOnly; // Clear the Readonly flag.
            }
            
            Fire_Status("Clearing Modified Flags");
            ClearModifiedFlags();
            
            Fire_Status("Encrypting File Data");
            // Serialize the data and encrypt it.
            memStr = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(memStr, this);
            byte [] encryptedBytes = memStr.ToArray();
          //byte [] encryptedBytes = Encrypter.Encrypt(memStr.ToArray(), password); // uncomment to decrypt
            
            // Write it out to disk.
            Fire_Status("Saving File " + DATAFILE);
            stream = File.Open(DATAFILE, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            stream.Write(encryptedBytes, 0, encryptedBytes.Length);
            stream.Flush();
            stream.Close();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Exception Saving Recipe File:  " + DATAFILE + "\r\nException:  " + ex.Message,
                                  "RecipeData.cs", System.Windows.Forms.MessageBoxButtons.OK);
         }
         finally
         {
            if (stream != null)
            {
               stream.Close();
            }
            if (memStr != null)
            {
               memStr.Close();
            }
            Fire_Status("Saving File " + DATAFILE + " Complete");
         }
      }
      #endregion LOAD/SAVE
      
      #region IMPORT_CSV
      public void Import_CvCheck(string csvFile)
      {
#if true
         MessageBox.Show("Import_CvCheck DISABLED");
         return;
#else
         StreamReader sr = new StreamReader(csvFile);         
         
         sr.ReadLine(); // get rid of header line
         string line = sr.ReadLine();
         while (line != null)
         {
            string [] splits = line.Split(new char [] {','});
            if (splits.Length >= 5)
            {
               bool bCleared = splits[5] == "n" ? false : true;
               float debitAmount  = 0;
               float creditAmount = 0;

               DateTime date = new DateTime();
               if (splits[0] != "" && DateTime.TryParse(splits[0], out date) == false)
               {
                  MessageBox.Show("Line Import failed to parse Date: " + line);
                  continue;                
               }

               if (splits[2] != "" && float.TryParse(splits[2].Replace("$",""), out debitAmount) == false)
               {
                  MessageBox.Show("Line Import failed: " + line);                  
                  continue;                
               }
               if (splits[3] != "" && float.TryParse(splits[3].Replace("$",""), out creditAmount) == false)
               {
                  MessageBox.Show("Line Import failed: " + line);  
                  continue;                
               }

               if (debitAmount > 0 && creditAmount > 0)
               {
                  MessageBox.Show("WARNING:  line contains debit and Credit, importing 2 Transactions");
               }

               if (debitAmount > 0)
               {
                  Transaction t = new Transaction(Category_T.Misc, splits[1], -debitAmount);
                  t.Ticks = date.Ticks;
                  t.Cleared = bCleared;
                  t.Modified = false;
                  data.Add(t);
               }
               
               if (creditAmount > 0)
               {
                  Transaction t = new Transaction(Category_T.Misc, splits[1], creditAmount);
                  t.Ticks = date.Ticks;
                  t.Cleared = bCleared;
                  t.Modified = false;
                  data.Add(t);
               }
               
            }
            else
            {
               MessageBox.Show("Line Import failed: " + line);
            }
            line = sr.ReadLine();
         }
#endif
      }

      public void Export_CSV(string _filename, DateTime _date)
      {
         string _csvFile = _filename + ".csv";
         // Write the list out to file.  If this is a new file, add header
         if (!File.Exists(_csvFile))
         {
            File.AppendAllText(_csvFile, Transaction.CSV_Header());
         }
         
         StringBuilder _sb = new StringBuilder(10000);
         Decimal _totalAmount = 0;
         int _numExported = 0;
         for (int i = 0; i < data.Count; i++)
         {
            Transaction _t = data[i];
            if (_t.Flagged)            continue;
            if (_t.Cleared == false)   continue;
            if (_t.Modified)           continue;
            if (_t.Ticks < _date.Ticks)
            {
               _sb.Append(_t.CSV_DataString());
               _totalAmount += _t.Amount;
               _numExported++;
               data.RemoveAt(i);
               i = i-1;
            }
         }
         
         if (_sb.Length <= 0)
         {
            return;
         }
         File.AppendAllText(_csvFile, _sb.ToString());
         Transaction _txn = new Transaction(Category_T.Misc,
                                            "Exported (" + _numExported.ToString() + 
                                            ") Transactions. SUM " + DateTime.Now.ToString("yyyy-MM-dd"),
                                            _totalAmount);
         _txn.Flagged = true;
         _txn.Cleared = true;
         data.Add(_txn);
      }

      public void Import_BankData(string csvFile)
      {
         Fire_Status("Opening Statement File " + csvFile);
         System.Threading.Thread.Sleep(500);

         List<string> _lines = new List<string>(File.ReadAllLines(csvFile));
         if (_lines.Count == 0)
         {
            MessageBox.Show("Empty File");
            return;
         }

         /////////////////////////////////////
         // Check for and remove header row
         /////////////////////////////////////
         const int IX_DATE          = 1;
         const int IX_CHECK         = 2;
         const int IX_DESCRIPTION   = 3;
         const int IX_AMOUNT        = 4;
         string HEADER = "\"Account\",\"Date\",\"Check\",\"Description\",\"Amount\"";

         if (_lines[0].Contains(HEADER) == false)
         {
            MessageBox.Show("First Line is not correct for Bank Data, aborting\r\n\r\n" +
                            "Should be:  " + HEADER);
            MessageBox.Show("Download file from bank, Balances | Details (Draft Account) | Download (Formatted as: Comma-Seperated-Values)");                            
         }
         _lines.RemoveAt(0);

         /////////////////////////////////////
         // Parse all the lines
         /////////////////////////////////////
         List<string> _results = new List<string>();
         foreach (string s in _lines)
         {
            if (s == null) {  continue; }
            string _sErr = "";
            string _line = s.Replace("\"", ""); // Remove Quotes
            string [] _cells = _line.Split(new char [] {','}, StringSplitOptions.None);
            if (_cells.Length < 5)
            {
               _sErr += "   Line Import failed:  incorrect # of items.  Expecting 5\r\n";
            }


            // Parse Date
            DateTime _date = new DateTime();
            if (DateTime.TryParse(_cells[IX_DATE], out _date) == false)
            {
               _sErr += "   Line Import failed:  Couldn't parse date  " + _cells[IX_DATE] + "\r\n";
            }

            // Parse $amount  (first change parenthesis to minus sign.. and remove $
            string _sAmount = _cells[IX_AMOUNT].Replace("(","-").Replace("$","").Replace(")","");
            decimal _amount  = 0;
            if (decimal.TryParse(_cells[IX_AMOUNT], out _amount) == false)
            {
               _sErr += "   Line Import failed:  Couldn't parse amount:  " + _cells[IX_AMOUNT] + "\r\n ";                  
            }
 
            // Add Check # to description
            string _description = _cells[IX_DESCRIPTION];
            if (_cells[IX_CHECK].Trim() != "")
            {
               _description = _cells[IX_CHECK] + " - " + _cells[IX_DESCRIPTION];
            }
            else
            {
               _description = _cells[IX_DESCRIPTION];
            }

            ////////////////////////////////////////////
            // Add parsed data to new transaction list
            // Check to see if it is new, then
            // Add it to the master bankData list
            ////////////////////////////////////////////
            Transaction t = new Transaction();
            t.Amount       = _amount;
            t.Date         = _date;
            t.Description  = _description;
            t.Cleared      = false;
            if (_sErr != "")
            {
               _results.Add("ERROR-" + _line + "\r\n" + _sErr);
               Fire_Status("_sErr");

            }
            else if (bankData.Contains(t) == false)
            {
               _results.Add("ADDED-" + t.ToStringPretty());
               Fire_Status("Adding Transaction:  " + t.ToString());
               bankData.Add(t);
            }
            else
            {
               _results.Add("SKIP--" + t.ToStringPretty());
               Fire_Status("Skipping Existing Transaction" + t.ToString());
            }
            System.Threading.Thread.Sleep(50);
         }
         
         //////////////////////////////////////////////////////
         // Rename import file to show that it has been imported
         //////////////////////////////////////////////////////
         File.Copy(csvFile, "Imported_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".csv");
         File.Delete(csvFile);


         //////////////////////////////////////////////////////
         // Delete backup data files older than 31 days old
         //////////////////////////////////////////////////////
         Fire_Status("Deleting old Imported Bank Data (older than 30 days)");
         string path = Path.GetDirectoryName(csvFile);
         DirectoryInfo di = new DirectoryInfo(path);
         FileInfo []files = di.GetFiles("Imported_*.csv");
         foreach (FileInfo f in files)
         {
            TimeSpan ts = new TimeSpan(DateTime.Now.Ticks - f.LastWriteTime.Ticks);
            if (ts.TotalDays > 31)
            {
               f.Delete();
            }
         }
         Fire_Status("Statement Data Import Completed");

         File.WriteAllLines("ImportResults.txt", _results.ToArray());
         System.Diagnostics.Process.Start("notepad.exe", "ImportResults.txt");
      }
      #endregion IMPORT

      internal void ClearBankData()
      {
         try
         {
            int _count = 0;
            DateTime _dtDelete = DateTime.Now.AddMonths(-6);
            for (int i = 0; i < bankData.Count; i++)
            {
               if (bankData[i].Cleared && !bankData[i].Flagged)
               {
                  if (bankData[i].Date < _dtDelete)
                  {
                     bankData.RemoveAt(i);
                     _count++;
                     i = i - 1;
                  }
               }
            }
            Compute();
            MessageBox.Show("Removed " + _count.ToString() + " Transactions whose date is earlier than " + _dtDelete.ToString());
         }
         catch (Exception ex)
         {
            MessageBox.Show("Exception:  " + ex.Message);
         }
      }

      #region AUTO BALANCE
      public void AutoBalance()
      {
         // for each transactions that is uncleared
         // See if an uncleared item of the same amount is in the bank data
         // If a match is found, Prompt user to clear both items
         List<Transaction> dataUncleared     = UnclearedTransactions(data);
         List<Transaction> bankDataUncleared = UnclearedTransactions(bankData);
         foreach (Transaction t in dataUncleared)
         {
            if ((t.GetType() == typeof(Bucket)) || t.Flagged)
            {
               continue;   // Skip Buckets and Flagged items.
            }
            else
            {
               List<Transaction> matchList = AmountEqual(bankDataUncleared, t.Amount);
               if (matchList.Count == 1)
               {
                  string descStatement = matchList[0].Description.Replace("ATM WITHDRAWAL      STR PD - ", "");
                  descStatement = descStatement.Replace("ATM/ACH DEBIT", "");
                  descStatement = descStatement.Replace("  ", " ");
                  descStatement = descStatement.Trim();
                  DialogResult res;
                  res = MessageBox.Show("MATCH FOUND!  DO YOU WANT TO CLEAR BOTH?\r\n\r\n" +
                                        "REGISTER:   \t" + t.Amount.ToString("F2") + " \t" + t.Description + "\r\n" +
                                        "STATEMENT:  \t" + matchList[0].Amount.ToString("F2") + " \t" + descStatement, "Verify Item to Clear",
                                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                  if (res == DialogResult.Yes)
                  {
                     t.Cleared = true;
                     matchList[0].Cleared     = true;
                     if (_BalanceItemsCleared != null)
                     {
                        _BalanceItemsCleared(); // Notify listeners
                     }
                  }
                  else if (res == DialogResult.Cancel)
                  {
                     break;
                  }
               }
            }
         }
         
      }

      private List<Transaction> UnclearedTransactions(List<Transaction> tList)
      { 
         List<Transaction> unclearedList = new List<Transaction>();
         foreach (Transaction t in tList)
         {
            if (t.Cleared == false)
            {
               unclearedList.Add(t);
            }
         }
         return unclearedList;
      }
      
      private List<Transaction> AmountEqual(List<Transaction> bankDataUncleared, decimal dataAmount)
      {
         List<Transaction> amtEqualList = new List<Transaction>();
         foreach (Transaction transBank in bankDataUncleared)
         {
            if (transBank.Flagged)
            {
               continue;   // Don't do anything with flagged items
            }
            else if (transBank.Amount == dataAmount)
            {
               amtEqualList.Add(transBank);
            }
         }
         return amtEqualList;
      }
      #endregion


   }
}
