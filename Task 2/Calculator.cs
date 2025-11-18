using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Calculator
    {
        public static void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }

        public static int Add(int num1, int num2 )
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int? num2)
        {
            int secondNumber = num2 ?? 1;
            return num1 * secondNumber;
        }

        }
    }
