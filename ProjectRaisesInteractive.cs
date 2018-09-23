/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw1
*/
/*
ProjectedRaises (7)
-------------------
Write a C# program named *ProjectedRaises* that includes a named constant representing next year’s
anticipated 4 percent raise for each employee in a company. Also declare variables to represent
the current salaries for three employees. Assign values to the variables, and display, with
explanatory text, next year’s salary for each employee.

8
--
Convert the *ProjectedRaises* class to an interactive application named **ProjectedRaisesInteractive**.
Instead of assigning values to the salaries, accept them from the user as input.
*/

//FIXME PSEUDO sorta will fix when on visual studio

WriteLine("hw1#8 - Patrick Barnes");
WriteLine("ProjectedRaisesInteractive");

const double PCT_CHANGE = 1.04; // 1.00 being none
double inputSalary1 = 0;
double inputSalary2 = 0;
double inputSalary3 = 0;
double outputSalary1 = 0;
double outputSalary2 = 0;
double outputSalary3 = 0;

//skip error checking
Write("Input salary 1:");
inputSalary1 = (double) Read();
Write("Input salary 2:");
inputSalary2 = (double) Read();
Write("Input salary 3:");
inputSalary3 = (double) Read();

outputSalary1 = inputSalary1 * PCT_CHANGE;
outputSalary2 = inputSalary2 * PCT_CHANGE;
outputSalary3 = inputSalary3 * PCT_CHANGE;

WriteLine("Expected change multiplier:{0}",PCT_CHANGE);
WriteLine("{0} will be {1} next year.",inputSalary1, outputSalary1);
WriteLine("{0} will be {1} next year.",inputSalary2, outputSalary2);
WriteLine("{0} will be {1} next year.",inputSalary3, outputSalary3);

WriteLine("--End--");
