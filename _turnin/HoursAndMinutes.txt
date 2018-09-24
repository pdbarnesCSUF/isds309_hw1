/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw1
*/
/*
10
--
Write a program named **HoursAndMinutes** that declares a minutes variable to represent
minutes worked on a job, and assign a value to it. Display the value in hours and minutes.
 For example, 197 minutes becomes 3 hours and 17 minutes.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace HoursAndMinutes
{
    class HoursAndMinutes
    {
        static void Main(string[] args)
        {
            WriteLine("hw1#10 - Patrick Barnes");
            WriteLine("HoursAndMinutes");

            int inputMinutes = 0;
            int calculatedMinutes = 0;
            int calculatedHours = 0;

            //skip error checking
            Write("Minutes (int):");
            inputMinutes = int.Parse(ReadLine());

            calculatedHours = inputMinutes / 60;
            calculatedMinutes = inputMinutes % 60;
            
            WriteLine("{0} hours and {1} minutes", calculatedHours, calculatedMinutes);

            WriteLine("--End--");
        }
    }
}
