using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   static class Helper
    {
        public static int CheckIntDigits(this string str)
        {
            int value = 0;
            do
            {
                Console.Write("Enter number: ");
                str = Console.ReadLine();
            }
            while (!int.TryParse(str, out value));
            return value;
        }

        public static double CheckDoubleDigits(this string str)
        {
            double value = 0;
            do
            {
                Console.Write("Enter number: ");
                str = Console.ReadLine();
            }
            while (!double.TryParse(str, out value));
            return value;
        }
    }
}
