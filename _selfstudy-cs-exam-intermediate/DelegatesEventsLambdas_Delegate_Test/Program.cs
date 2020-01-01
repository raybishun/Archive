using System;

namespace DelegatesEventsLambdas_Delegate_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippingFeesDelegate theDel;
            ShippingDestination theDest;

            string theZone;

            do
            {
                // get the destination zone
                Console.WriteLine("What is the destination zone?");
                theZone = Console.ReadLine();

                if (!theZone.Equals("exit"))
                {
                    theDest = ShippingDestination.GetDestinationInfo(theZone);

                    if (theDest != null)
                    {
                        Console.WriteLine("What is the item price?");
                        string thePriceStr = Console.ReadLine();
                        decimal itemPrice = decimal.Parse(thePriceStr);

                        theDel = theDest.calcFees;

                        if (theDest.m_isHighRisk)
                        {
                            theDel += delegate (decimal thePrice, ref decimal itemFee)
                            {
                                itemFee += 25.0m;
                            };
                        }

                        decimal theFee = 0.0m;
                        theDel(itemPrice, ref theFee);
                        Console.WriteLine($"The shipping fees are: {theFee}");
                    }
                    else
                    {
                        Console.WriteLine("Hmm, you seem to have entered an unknown destination. Try again or 'exit'");
                    }
                }


            } while (theZone != "exit");

            Console.ReadLine();
        }
    }
}
