using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace CV_Checking
{
   #region ENCRYPTION CLASS
   public class Encrypter
   {
      #region BYTES
      public static byte[] Encrypt(byte[] plainData, string sKey)
      {
         DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
         DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
         DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
         ICryptoTransform desEncrypt = DES.CreateEncryptor();
         byte[] encryptedData = desEncrypt.TransformFinalBlock(plainData, 0, plainData.Length);

         return encryptedData;
      }

      public static byte[] Decrypt(byte[] encryptedData, string sKey)
      {
         DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
         DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
         DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
         ICryptoTransform desDecrypt = DES.CreateDecryptor();
         byte[] decryptedData = desDecrypt.TransformFinalBlock(encryptedData, 0, encryptedData.Length);

         return decryptedData;
      }
      #endregion BYTES

      #region STRING
      public static string Encrypt(string strData, string sKey)
      {
         byte[] plainData = ASCIIEncoding.ASCII.GetBytes(strData);
         DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
         DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
         DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
         ICryptoTransform desEncrypt = DES.CreateEncryptor();
         byte[] encryptedData = desEncrypt.TransformFinalBlock(plainData, 0, plainData.Length);
         
         string strEncrypted = ASCIIEncoding.ASCII.GetString(encryptedData);
         return strEncrypted;
      }

      public static string Decrypt(string strData, string sKey)
      {
         byte[] encryptedData = ASCIIEncoding.ASCII.GetBytes(strData);
         DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
         DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
         DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
         ICryptoTransform desDecrypt = DES.CreateDecryptor();
         byte[] decryptedData = desDecrypt.TransformFinalBlock(encryptedData, 0, encryptedData.Length);

         string strDecrypted = ASCIIEncoding.ASCII.GetString(decryptedData);
         return strDecrypted;
      }
      #endregion STRING
   }
   #endregion ENCRYPTOMATIC CLASS
}
