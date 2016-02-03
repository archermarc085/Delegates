using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    delegate int ArithmeticAverageValue(int a, int b);
    delegate int ArithmeticAverageValueArray(ArithmeticAverageValue[] val);

    delegate int Avg(int a, int b, int c);
    delegate int TwoDelegates(ArithmeticAverageValue val, Avg avg);
    delegate int AvreageMassive(TwoDelegates[] del);
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticAverageValue val = delegate(int a, int b) { return (a + b) / 2; };
            ArithmeticAverageValue[] delegates = {val ,delegate(int a, int b) { return (a + b) / 2; }, delegate(int a, int b) { return (a + b) / 2; } };

            ArithmeticAverageValueArray avrgValue = delegate(ArithmeticAverageValue[] avgs)
            {
                int s = 0;
                Random rand = new Random();
                foreach (var item in avgs)
                {
                    s += item(rand.Next(0,99), rand.Next(0,99));
                }
                return (s) / avgs.Count();
            };
            Console.WriteLine(avrgValue(delegates));



            Avg threeArgs =  delegate(int a, int b, int c) { return a + b + c / 3; };
            TwoDelegates[] average = {  (g,d) => 
            {
                int srz = (d(1, 2, 3) + g(1, 2) )/ 2;
                Console.WriteLine("First");
                return srz; 
            },
            delegate(ArithmeticAverageValue vals, Avg avf){ 
              int srz = (avf(1, 2, 3) + vals(1, 2) )/ 2;
              Console.WriteLine("Second");
              return srz; 
            }};

            AvreageMassive massive = (summer) =>
            {
                int s = 0;
                foreach (var item in summer)
                {
                    s += item(val, threeArgs);
                }
                return s / summer.Count();
            };
            Console.WriteLine(massive(average));

            Console.ReadLine();
        }
    }
}
