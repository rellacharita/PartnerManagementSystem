using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;

using System.Text;

namespace ISSI.PartnerManagementSystem.BusinessObjects
{
    public static class Security
    {
        public static String encryptpass(string password)
        {
                byte[] encode = new byte[password.Length];
                encode = Encoding.UTF8.GetBytes(password);
                string msg = Convert.ToBase64String(encode);
                return msg;
        }
        private static string Decryptpass(string encryptpass)
        {
            string decode = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encryptpass);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decode = new String(decoded_char);
            return decode;
        }
    }
}