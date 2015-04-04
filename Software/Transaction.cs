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
      
      #region OVERRIDES
      internal static string CSV_Header()
      {
         return "ID,YYYY-DD-MM,CATEGORY,DESCRIPTION,AMOUNT,CLEARED,FLAGGED\r\n";
      }
      
      internal string CSV_DataString()
      {
         return      id.ToString() +
               "," + Date().ToString("yyyy-MM-dd") +
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
      
      public override bool Equals(object obj)
      {
         if (obj == null || GetType() != obj.GetType()) return false;
         Transaction t = (Transaction)obj;
         return t.ticks == ticks && t.description == description && t.amount == amount;
      }
      
      public override int GetHashCode()
      {
         return base.GetHashCode();
      }
      #endregion OVERRIDES

      internal static int SEQUENCE_NEXT
      {
         get { return sequenceNext++;  }
         set { sequenceNext = value;   }
      } static int sequenceNext = 0;
      
      #region CLASS DATA / ACCESSORS
      public int ID
      {
         get { return id;  }
         set { id = value; bModified = true; }
      } int id = -1;
      
      public long Ticks
      {
         get { return ticks; }
         set { ticks = value; bModified = true; }
      } long ticks = DateTime.Now.Ticks;
      
      public string Description
      {
         get { return description; }
         set { description = value; bModified = true; }
      } string description = "";
      
      public Category_T Category
      {
         get { return category; }
         set { category = value; bModified = true; }
      } Category_T category;
      
      public bool Cleared
      {
         get { return bCleared; }
         set { bCleared = value; bModified = true; }
      } bool bCleared = false;
      
      public bool Flagged
      {
         get { return bFlagged;  }
         set { bFlagged = value; bModified = true; }
      } bool bFlagged = false;
      
      public decimal Amount
      {
         get { return amount; }
         set { amount = value; bModified = true; }
      } decimal amount = 0;
      #endregion CLASS DATA / ACCESSORS
      
      #region HELPERS
      internal bool Modified
      {
         get { return bModified;  }
         set { bModified = value; }
      } bool bModified = true;
      
      public DateTime Date()
      {
         return new DateTime(ticks);
      }
      public void SetDate(DateTime date)
      {
         ticks = date.Ticks;
      }
      #endregion HELPERS
   }
}
