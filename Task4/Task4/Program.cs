using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            Single shippingWeight = 0;
            Single shippingCost = 0;
            string TryAgain = string.Empty;
            bool IsString = true;
            string shipweight = string.Empty;
            //input
            do
            {

                do
                {
                    Console.WriteLine("please enter your package shipping weight in pounds");
                    shipweight = Console.ReadLine();
                    IsString = Single.TryParse(shipweight, out shippingWeight);
                    if (!IsString)
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                } while (!IsString);

                //process
                if (shippingWeight <= 2)
                {
                    shippingCost = 2;
                }
                else if (shippingWeight > 2 && shippingWeight <= 6)
                {
                    shippingCost = 4;
                }
                else if (shippingWeight > 6 && shippingWeight <= 10)
                {
                    shippingCost = 6;
                }
                else
                {
                    shippingCost = 8;
                }
                //output
                Console.WriteLine("The cost for your " + shippingWeight + "lb package is $" + shippingCost);

                Console.WriteLine("do you want to enter an new shipping rate Y or N?");
                TryAgain = Console.ReadLine().Substring(0, 1).ToUpper();
            } while (TryAgain == "Y");

        }
    }
}

