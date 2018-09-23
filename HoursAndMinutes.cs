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

//FIXME PSEUDO sorta will fix when on visual studio

WriteLine("hw1#10 - Patrick Barnes");
WriteLine("HoursAndMinutes");

//double so we can use decimal rates and inputs
const double BASE_RATE = 200;
const double HOUR_RATE = 150; //wow
const double MILE_RATE = 2; //wow
double inputHours = 0;
double inputMiles = 0;
double calculatedEstimate = 0;

//skip error checking
Write("Estimated Hours:");
inputHours = (double) Read();
Write("Estimated Miles:");
inputMiles = (double) Read();

calculatedEstimate =    BASE_RATE +
                        (HOUR_RATE * inputHours) +
                        (MILE_RATE * inputMiles);

WriteLine("{0} + {1}*{2} + {3}*{4}",    BASE_RATE,
                                        HOUR_RATE, inputHours,
                                        MILE_RATE, inputMiles);
WriteLine("Estimated Cost:{0}", calculatedEstimate);

WriteLine("--End--");
