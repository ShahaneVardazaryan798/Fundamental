using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ZarXaxacoxner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] arr = new string[12] { "January","February","March",  "April",   "May",  "June", " July","Ougust","September","October","November","December"};
            WriteLine("Enter the month");
            bool find = false;
            string Month;
            Month = ReadLine();
            
            for (int i = 0; i <arr.Length; i++)
            {
                if(Month==arr[i])
                {
                    find = true;
                   WriteLine((int)(i+1));
                    break;
                }
               
            }
            if(!find)
            {
               WriteLine("Please enter the month again");
            }
            
        }
    }
}
