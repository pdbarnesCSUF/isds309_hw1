/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw1
*/
/*
Eggs (11)
---------
Write a program named *Eggs* that declares four variables to hold the number of eggs produced
 in a month by each of four chickens, and assign a value to each variable. Sum the eggs, 
 then display the total in dozens and eggs. For example, a total of 127 eggs is 10 dozen and 7 eggs.

12
--
Modify the *Eggs* program to create a new one named **EggsInteractive** that prompts the user 
for and accepts a number of eggs for each chicken.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace EggsInteractive
{
    class EggsInteractive
    {
        static void Main(string[] args)
        {
            WriteLine("hw1#12 - Patrick Barnes");
            WriteLine("EggsInteractive");

            int eggs1 = 0;
            int eggs2 = 0;
            int eggs3 = 0;
            int eggs4 = 0;
            int calculatedSum = 0;
            int calculatedDozen = 0;
            int calculatedLeftover = 0;

            //skip error checking
            Write("chicken1 eggs:");
            eggs1 = int.Parse(ReadLine());
            Write("chicken2 eggs:");
            eggs2 = int.Parse(ReadLine());
            Write("chicken3 eggs:");
            eggs3 = int.Parse(ReadLine());
            Write("chicken4 eggs:");
            eggs4 = int.Parse(ReadLine());

            calculatedSum = eggs1 + eggs2 + eggs3 + eggs4;

            calculatedDozen = calculatedSum / 12;
            calculatedLeftover = calculatedSum % 12;

            WriteLine("{0} eggs comes to {1} dozen and {2} eggs.", calculatedSum, calculatedDozen, calculatedLeftover);

            WriteLine("--End--");
        }
    }
}
