/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw1
*/
/*
14
--
Write a program named **TestsInteractive** that prompts a user for eight test scores and displays
 the average of the test scores to two decimal places.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace TestsInteractive
{
    class TestsInteractive
    {
        static void Main(string[] args)
        {
            WriteLine("hw1#14 - Patrick Barnes");
            WriteLine("TestsInteractive");

            double calcNum = 0;

            Write("Test1:"); calcNum += double.Parse(ReadLine());
            Write("Test2:"); calcNum += double.Parse(ReadLine());
            Write("Test3:"); calcNum += double.Parse(ReadLine());
            Write("Test4:"); calcNum += double.Parse(ReadLine());
            Write("Test5:"); calcNum += double.Parse(ReadLine());
            Write("Test6:"); calcNum += double.Parse(ReadLine());
            Write("Test7:"); calcNum += double.Parse(ReadLine());
            Write("Test8:"); calcNum += double.Parse(ReadLine());

            calcNum /= 9;

            WriteLine("Avg:{0}", calcNum.ToString("#0.00"));

            WriteLine("--End--");
        }
    }
}
