/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw1
*/
/*
16
--
Create an enumeration named Month that holds values for the months of the year, starting with 
JANUARY equal to 1. Write a program named **MonthNames** that prompts the user for a month integer.
 Convert the user’s entry to a Month value, and display it.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace MonthNames
{
    class MonthNames
    {
        enum Months
        {
            JANUARY = 1, FEBRUARY, MARCH, APRIL,
            MAY, JUNE, JULY, AUGUST,
            SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
        }
        static void Main(string[] args)
        {
            WriteLine("hw1#16 - Patrick Barnes");
            WriteLine("MonthNames");

            Months inputNum = (Months) int.Parse(ReadLine());

            WriteLine("{0} is {1}", (int)inputNum, inputNum);


            WriteLine("--End--");
        }
    }
}
