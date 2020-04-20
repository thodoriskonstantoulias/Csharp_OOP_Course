using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class Cryptography
    {
        public static void TestCrypto()
        {
            DESCryptoServiceProvider key = new DESCryptoServiceProvider();
            Console.WriteLine("Enter your message");

            string text = Console.ReadLine();
            Console.WriteLine("Cipher text " + Encrypt(text, key));

            string cipherText = Encrypt(text, key);
            Console.WriteLine("Decrypt text " + Decrypt(cipherText, key));
        }

        public static string Encrypt(string text, SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);

            sw.Write(text);
            sw.Flush();
            cs.FlushFinalBlock();

            return (Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length));
        }

        public static string Decrypt(string cipher, SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipher));
            CryptoStream cs = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);

            return sr.ReadToEnd();
        }
    }
}
