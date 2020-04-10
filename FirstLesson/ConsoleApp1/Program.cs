using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start: WriteLine("Enter your first number");
            int num1 = int.Parse(ReadLine());
            WriteLine("Enter your second number");
            int num2 = int.Parse(ReadLine());
            WriteLine("Enter other number");
            int num3 = int.Parse(ReadLine());
            WriteLine("Enter other number");
            int num4 = int.Parse(ReadLine());
            WriteLine();
            int[] b = { num1, num2,num3,num4 };
            WriteLine("Your maximum number =" +" "+ b.Max());
            goto Start;
        }
    }
}
