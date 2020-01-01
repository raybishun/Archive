using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _99_Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password: ");
            string pwd = Console.ReadLine();
            Console.WriteLine();

            HashData hd = new HashData();
            string pwd_hash = hd.CreateHash(pwd);
            Console.WriteLine($"{pwd_hash}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Re-enter password: ");
            string pwd2 = Console.ReadLine();

            string pwd2_hash = hd.CreateHash(pwd2);

            Console.WriteLine();

            if (pwd_hash == pwd2_hash)
            {
                Console.WriteLine("Correct password");
            }
            else
            {
                Console.WriteLine("You da stupid...");
            }



            Console.ReadLine();
        }
    }

    public class HashData
    {
        public string CreateHash(string text)
        {
            HashAlgorithm sha256 = SHA256.Create();
            byte[] hash = sha256.ComputeHash(Encoding.Default.GetBytes(text));
            return Convert.ToBase64String(hash);
        }
    }
}