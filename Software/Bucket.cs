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
   [Serializable]
   public class Bucket : Transaction
   {
      public Bucket()
      {
         // Let accessors define initial values
      }

      public Bucket(string _description, decimal _icrementAmount)
      {
         Category        = Category_T.Bucket;
         Description     = _description;
         incrementAmount = _icrementAmount;
      }

      #region OVERRIDES
      public override string ToString()
      {
         return Description + ", " + Amount.ToString("F2");
      }
      public override bool Equals(object obj)
      {
         return base.Equals(obj);
      }
      public override int GetHashCode()
      {
         return base.GetHashCode();
      }
      #endregion OVERRIDES
      
      #region CLASS DATA / ACCESSORS
      public decimal IncrementAmount
      {
         get { return incrementAmount; }
         set { incrementAmount = value; Modified = true; }
      } decimal incrementAmount = 0;
      #endregion CLASS DATA / ACCESSORS
      
      public void Increment()
      {
         Amount -= incrementAmount;
      }
   }
}
