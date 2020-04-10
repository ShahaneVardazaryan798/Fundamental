using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter your Name");
            string Name = ReadLine();
            WriteLine("Enter your age");
            int age = int.Parse(ReadLine());
            WriteLine("Enter your Location");
            string Location = ReadLine();
            WriteLine("Enter your Profession");
            string Profession = ReadLine();
            WriteLine("Enter your Goroskope");
            char Goroskope = char.Parse(ReadLine());
            StringBuilder sb = new StringBuilder($"WELCOME {Name}");
            string str = sb.ToString();
            ForegroundColor = ConsoleColor.Red;
            SetCursorPosition(WindowWidth / 2, WindowHeight / 2);
            WriteLine(str);

        }
    }
}
