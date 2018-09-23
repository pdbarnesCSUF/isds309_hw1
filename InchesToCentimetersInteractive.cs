/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw1
*/
/*
5
-
Write a C# program named InchesToCentmeters that declares a named constant that
holds the number of centimeters in an inch: 2.54. Also declare a variable to
represent a measurement in inches, and assign a value. Display the measurement
in both inches and centimeters—for example, 3 inches is 7.62 centimeters.
---
6
-
Convert the InchesToCentimeters program to an interactive application named
InchesToCentimeterslnteractive. Instead of assigning a value to the inches
variable, accept the value from the user as input.
*/

//FIXME PSEUDO sorta will fix when on visual studio

WriteLine("hw1#6 - Patrick Barnes");
WriteLine("InchesToCentimeters");

const double CM_PER_IN = 2.54;
double inputInches = 0;
double convertedCentimeters = 0;

//skip error checking
Write("Input inches:");

inputInches = (double) Read();
convertedCentimeters = inputInches * CM_PER_IN;

WriteLine("{0} inches is {1} centimeters.",inputInches, convertedCentimeters);

WriteLine("--End--");
