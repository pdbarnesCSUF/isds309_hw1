/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw1
*/
/*
13
--
Write a program named **MakeChange** that calculates and displays the conversion of an entered
 number of dollars into currency denominations—twenties, tens, fives, and ones. For example,
 $113 is 5 twenties, 1 ten, 0 fives, and 3 ones.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace MakeChange
{
    class MakeChange
    {
        static void Main(string[] args)
        {
            WriteLine("hw1#13 - Patrick Barnes");
            WriteLine("MakeChange");

            int inputCash = 0;
            int calc20 = 0;
            int calc10 = 0;
            int calc5 = 0;
            int calc1 = 0;

            Write("enter total money (int):");
            inputCash = int.Parse(ReadLine());

            calc20 = inputCash / 20;
            calc10 = inputCash % 20 / 10;
            calc5 = inputCash % 10 / 5;
            calc1 = inputCash % 5;

            WriteLine("{0} is {1} twenties, {2} tens, {3} fives, {4} ones", inputCash, calc20, calc10, calc5, calc1);

            WriteLine("--End--");
        }
    }
}
