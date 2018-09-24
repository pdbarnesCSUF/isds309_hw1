/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw1
*/
/*
17
--
Create an enumeration named Planet that holds the names for the eight planets in our solar 
system, starting with MERCURY and ending with NEPTUNE. Write a program named **Planets** that 
prompts the user for a numeric position, and display the name of the planet that is in the
 requested position
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Planets
{
    class Planets
    {
        enum Planet
        {
            MERCURY = 1, VENUS, EARTH, MARS,
            JUPITER, SATURN, URANUS, NEPTUNE
        }
        static void Main(string[] args)
        {
            WriteLine("hw1#17 - Patrick Barnes");
            WriteLine("Planets");

            Planet inputNum = (Planet)int.Parse(ReadLine());

            WriteLine("{0} is {1}", (int)inputNum, inputNum);


            WriteLine("--End--");
        }
    }
}
