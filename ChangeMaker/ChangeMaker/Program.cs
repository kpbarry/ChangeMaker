using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);

            //Keep window open
            Console.ReadKey();
        }

        static void ChangeMaker(double amount)
        {
            //Denominations and counters
            double quarters = .25;
            double qAmount = 0;
            double dimes = .10;
            double dAmount = 0;
            double nickels = .05;
            double nAmount = 0;
            double pennies = .01;
            double pAmount = 0;
            double remainder = 0;

            //Amount of quarters
            qAmount = amount / quarters;
            //Remainder to find out dimes
            remainder = amount % quarters;
            
            //Amount of dimes
            dAmount = remainder / dimes;
            //Remainder to find out dimes
            remainder = remainder % dimes;

            //Amount of nickels
            nAmount = remainder / nickels;
            //Remainder
            remainder = remainder % nickels;

            //Amount of pennies
            pAmount = remainder / pennies;
            remainder = remainder % pennies;

            //Round down for quarters, dimes & nickels, and to nearest int for pennies
            Console.WriteLine("Amount : " + amount);
            Console.WriteLine("Quarters: " + Math.Floor(qAmount));
            Console.WriteLine("Dimes: " + Math.Floor(dAmount));
            Console.WriteLine("Nickels: " + Math.Floor(nAmount));
            Console.WriteLine("Pennies: " + Math.Round(pAmount));
        }
    }
}
