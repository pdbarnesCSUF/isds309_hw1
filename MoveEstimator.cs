/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw1
*/
/*
9
--
Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per mile.
Write a program named **MoveEstimator** that prompts a user for and accepts estimates for
the number of hours for a job and the number of miles involved in the move and displays
the total moving fee.
*/

//FIXME PSEUDO sorta will fix when on visual studio

WriteLine("hw1#9 - Patrick Barnes");
WriteLine("MoveEstimator");

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
