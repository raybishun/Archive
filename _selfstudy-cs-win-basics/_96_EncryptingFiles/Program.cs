using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _96_EncryptingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();


            Console.WriteLine("Press enter to encrypt...");
            Console.ReadLine();
            EncryptFile("ml.txt");


            Console.WriteLine("Press enter to decrypt...");
            Console.ReadLine();
            DecryptFile("ml.txt");

            Console.ReadLine();
        }

        static void ReadFile()
        {
            int ctr = 0;
            string line;

            // Read the file and display it line by line.
            using (StreamReader sr = new StreamReader("ml.txt"))
            {
                while (   (line = sr.ReadLine())    !=    null)
                {
                    Console.WriteLine(line);
                    ctr++;
                }
            }
        }

        static void EncryptFile(string file)
        {
            File.Encrypt(file);
        }

        static void DecryptFile(string file)
        {
            File.Decrypt(file);
        }
    }
}
