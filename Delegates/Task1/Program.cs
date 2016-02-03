using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    delegate T ArithmeticAverageValue<T>(T a, T b, T c); 
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticAverageValue<int> averageValue = (a, b, c) =>
            {
                return (a + b + c) / 3;
            };
            Console.WriteLine(averageValue(1,2,3));

            Func<int, int, int> AVG = delegate(int a, int b) { return (a + b) / 2; };
            Console.WriteLine(AVG(2, 4));

            Console.ReadLine();
        }
    }
}
