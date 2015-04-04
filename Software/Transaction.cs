using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CV_Checking
{
   public enum Category_T
   {
      Credit = 0,
      Misc,
      Bucket,
      Food,
      Joy,
      Auto,
      School,
      Dining,
      House,
      Expense,
      Utility,
      Medical,
      Activity,
      NUM_CATEGORIES
   }
   
   [Serializable]
   public class Transaction
   {
      #region CLASS DATA / CONSTRUCTORS
      static int  sequenceNext   = 0;
      int         id             = -1;
      long        ticks          = DateTime.Now.Ticks;   // Stores Date
      string      description    = "";
      Category_T  category       = Category_T.Misc;
      bool        bCleared       = false;
      bool        bFlagged       = false;
      decimal     amount         = 0;
      bool        bModified      = true;

      public Transaction()
      {
         // parameterless constructor for serialization.
         // Let class data definitions set initial values.
      }
      
      public Transaction(Category_T _category, string _description, decimal _amount)
      {
         category    = _category;
         description = _description;
         amount      = _amount;
         id          = SEQUENCE_NEXT;
      }

      public Transaction(Category_T _category, string _description, double _amount)
      {
         category    = _category;
         description = _description;
         amount      = (decimal)_amount;
         id          = SEQUENCE_NEXT;
      }
      
      public Transaction(Category_T _category, string _description, float _amount)
      {
         category    = _category;
         description = _description;
         amount      = (decimal)((double)_amount);
         id          = SEQUENCE_NEXT;
      }
      #endregion CLASS DATA / CONSTRUCTORS
      
      #region OVERRIDES
      internal static string CSV_Header()
      {
         return "ID,YYYY-DD-MM,CATEGORY,DESCRIPTION,AMOUNT,CLEARED,FLAGGED\r\n";
      }
      
      internal string CSV_DataString()
      {
         return      id.ToString() +
               "," + Date.ToString("yyyy-MM-dd") +
               "," + category.ToString() +
               "," + description.Replace(","," ").ToString() +
               "," + amount.ToString() + 
               "," + Cleared.ToString() + 
               "," + Flagged.ToString()+
               "\r\n";
      }

      public override string ToString()
      {
         return description + ", " + amount.ToString("F2");
      }
     
      internal string ToStringPretty()
      {
         // Date, Amount, Desc
         string sDate = Date.ToString("yyyy.MM.dd");
         return string.Format("{0}, {1,10: 0.00;-0.00}, {2}", sDate, amount, description);
      }
     
      public override bool Equals(object obj)
      {
         if (obj == null || GetType() != obj.GetType())  { return false; }
         Transaction t = (Transaction)obj;
         return (t.ticks == ticks) && (t.amount == amount) && (t.description == description);
      }
      
      public override int GetHashCode()
      {
         return base.GetHashCode();
      }
      #endregion OVERRIDES

      #region GET / SET ACCESSORS
      internal static int SEQUENCE_NEXT
      {
         get { return sequenceNext++;  }
         set { sequenceNext = value;   }
      }
      
      public int ID
      {
         get { return id;  }
         set { id = value; bModified = true; }
      }
      
      public long Ticks
      {
         get { return ticks; }
         set { ticks = value; bModified = true; }
      }
      public DateTime Date
      {
         get {  return new DateTime(ticks); }
         set {  ticks = value.Ticks; bModified = true; }
      }
      
      public string Description
      {
         get { return description; }
         set { description = value; bModified = true; }
      }
      
      public Category_T Category
      {
         get { return category; }
         set { category = value; bModified = true; }
      }
      
      public bool Cleared
      {
         get { return bCleared; }
         set { bCleared = value; bModified = true; }
      }
      
      public bool Flagged
      {
         get { return bFlagged;  }
         set { bFlagged = value; bModified = true; }
      }
      
      public decimal Amount
      {
         get { return amount; }
         set { amount = value; bModified = true; }
      }

      internal bool Modified
      {
         get { return bModified;  }
         set { bModified = value; }
      } 
      
      #endregion CLASS DATA / ACCESSORS
      
   }
}
