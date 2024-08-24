using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace messengerX_v._1._0._0
{
    public class hashPassword
    {
       public static string getHashPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < hashedPassword.Length; i++)
            {
                stringBuilder.Append(hashedPassword[i].ToString("x2")); // convert the password to the hexadecimal
            }

            return stringBuilder.ToString();
        }
    }
}
