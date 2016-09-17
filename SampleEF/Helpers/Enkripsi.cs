using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace SampleEF.Helpers
{
    public static class Enkripsi
    {
        public static string GetMd5(string password)
        {
            UnicodeEncoding unicode = new UnicodeEncoding();
            byte[] dataHash = unicode.GetBytes(password);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hasil = md5.ComputeHash(dataHash);
            return Convert.ToBase64String(hasil, 0, hasil.Length);
        }
    }
}