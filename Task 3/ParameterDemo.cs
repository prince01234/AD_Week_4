using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class ParameterDemo
    {
        public static int Increase(ref int number)
        {
            number += 10;
            return number;
        }

        public static string GetFullName(out string fullName)
        {
            return fullName = "Prince Shrestha";
        }

        public static int SumAll(params int[] numbers)
        {
            int sum = 0;
    
            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum;
        }
    }
}
