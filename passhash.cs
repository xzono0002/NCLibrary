using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Library_Management_System
{
    internal class passhash
    {
        public static string hashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypted_bytes);
        }

        public static string verify(string hashpass)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] password_bytes = Convert.FromBase64String(hashpass);
            byte[] decrypted_bytes = sha1.ComputeHash(password_bytes);
            return ASCIIEncoding.ASCII.GetString(decrypted_bytes);
        }
    }
}
