using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    enum Sign { Sum, Subtract, Multiply, Divide }
    delegate T ArithmeticOperations<T>(T a, T b);
    class Program
    {
      static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            string inputNumber = "";
            string inputNumber2 = "";


            firstNumber = inputNumber.CheckIntDigits();
            secondNumber = inputNumber2.CheckIntDigits();

            ArithmeticOperations<int> Add = (a, b) => { return a + b; };

            ArithmeticOperations<int> Sub = (a, b) =>
            {
                if (a > b)
                {
                    return a - b;
                }
                return b - a;
            };

            ArithmeticOperations<int> Mul = (a, b) =>
            {
                return a * b;
            };

            ArithmeticOperations<int> Div = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Divide by zero!");
                    return -1;
                }
                else
                {
                    return a / b;
                }
            };


            Sign sign = Sign.Sum;
            switch (sign)
            {
                case Sign.Sum:
                    {
                        Console.WriteLine("The sum is: " + Add(firstNumber, secondNumber));
                        break;
                    }
                case Sign.Subtract:
                    {
                       Console.WriteLine("The difference is: " + Sub(firstNumber, secondNumber));
                        break;
                    }
                case Sign.Multiply:
                    {
                       Console.WriteLine("The composition is: " + Mul(firstNumber, secondNumber));
                        break;
                    }
                case Sign.Divide:
                    {
                       Console.WriteLine("The quotient is: " +  Div(firstNumber , secondNumber));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a valid operator.");
                        break;
                    }
               }
                Console.ReadLine();
        }
    }
}
