using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rd = new Random();
          //  WriteLine(rd.Next());
          //  WriteLine(rd.Next(100));
          //  WriteLine(rd.Next(-34, 56));
          //  WriteLine("Zar..." + rd.Next(1, 7));
          //  ReadLine();
          Enter:
            goto Enter;
        }
    }
}
