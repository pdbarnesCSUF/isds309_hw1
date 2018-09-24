/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw1
*/
/*
15
--
Write a program named **FahrenheitToCelsius** that accepts a temperature in Fahrenheit from a user
 and converts it to Celsius by subtracting 32 from the Fahrenheit value and multiplying the 
 result by 5/9. Display both values to one decimal place.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace FahrenheitToCelsius
{
    class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            WriteLine("hw1#15 - Patrick Barnes");
            WriteLine("FahrenheitToCelsius");

            double inputTemp = 0;
            double calculatedTemp = 0;

            Write("Temp (in F):");
            inputTemp = double.Parse(ReadLine());
            calculatedTemp = (inputTemp - 32) * (5.0 / 9.0);

            WriteLine("{0} Fahrenheit = {1} Celsius",inputTemp.ToString("#0.0"),calculatedTemp.ToString("#0.0"));

            WriteLine("--End--");
        }
    }
}
