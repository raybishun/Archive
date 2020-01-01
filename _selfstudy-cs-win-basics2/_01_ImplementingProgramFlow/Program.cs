using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _01_ImplementingProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch_Demo();


            // Console.WriteLine(HashAlgorithm_PopQuiz.CreateHash("abc"));
            Console.ReadLine();
        }

        static void Switch_Demo()
        {
            Console.Write("How much do you like .NET? (Scale of 1 to 10) ");
            short loveIt;
            bool isNumeric = short.TryParse(Console.ReadLine().ToString(), out loveIt);
            if (isNumeric && loveIt >= 0 && loveIt <= 10)
            {
                string HowMuchDoYouLoveIt = "";
                switch (loveIt)
                {
                    case 1:
                    case 2:
                    case 3:
                        HowMuchDoYouLoveIt = "beginner";
                        break;
                    case 4:
                    case 5:
                    case 6:
                        HowMuchDoYouLoveIt = "intermediate";
                        break;
                    case 7:
                    case 8:
                    case 9:
                        HowMuchDoYouLoveIt = "advanced";
                        break;
                    default:
                        break;
                }

                Console.WriteLine(HowMuchDoYouLoveIt);
            }
            else
            {
                Console.WriteLine("Enter a number between 1 and 10");
            }

            AccountStatus currentStatus = AccountStatus.RestrictedFraudAlert;

            switch (currentStatus)
            {
                case AccountStatus.OK:
                    break;
                case AccountStatus.Overdrawn:
                    break;
                case AccountStatus.Maintentance:
                    break;
                case AccountStatus.RestrictedFraudAlert:
                    break;
                case AccountStatus.SuspendedUserRequest:
                    break;
                case AccountStatus.SuspendedBankReview:
                    break;
                case AccountStatus.Other:
                    break;
                default:
                    break;
            }

            int evalNumber = 6;
            string usingThe_Ternary_Operator = (evalNumber >= 7) ? "yes" : "no";
            Console.WriteLine(usingThe_Ternary_Operator);

            // && = Short Circuit Operator (that is, if the 1st condition is false, no other condition is checked)

            // postfix = i++ (A is incremented 'before' B is assigned)
            int a = 10;
            int b = a++;
            Console.WriteLine($"{a} | {b}");


            // prefix ++i (A is incremented and B is assigned the value)
            a = 10;
            b = ++a;
            Console.WriteLine($"{a} | {b}");
        }

    enum AccountStatus
        {
            OK,
            Overdrawn,
            Maintentance,
            RestrictedFraudAlert,
            SuspendedUserRequest,
            SuspendedBankReview,
            Other
        };

    class HashAlgorithm_PopQuiz
    {
        public static string CreateHash(string text)
        {
            HashAlgorithm sha256 = SHA256.Create();
            byte[] hash = sha256.ComputeHash(Encoding.Default.GetBytes(text));
            return Convert.ToBase64String(hash);
        }
    }
    }
}