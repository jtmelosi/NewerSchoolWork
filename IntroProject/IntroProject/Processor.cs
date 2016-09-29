using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProject
{
    public class Processor
    {
        // name, $ (words), memo, date, check#, $(numbers), # of checks, sum of checks
        private static string[] strArr = new string[8];
        // the string that holds an error message if an incorrect input was given
        private static string response = "";

        public Processor()
        {
        }

        // receives input, calculates everything, does tally, sets up output or an appropriate error message, returns whether or not input was acceptable
        public static bool receiveInput(string name, string amount, string memo)
        {
            if (!isCorrectInput(amount, name, memo))
            {
                return false;
            }
            double doubleValue = Convert.ToDouble(amount);
            // submit to tally
            Tally.increaseTally(doubleValue);
            // name
            strArr[0] = name;
            // amount in double format as string
            strArr[5] = amount;
            // memo
            strArr[2] = memo;
            // date
            DateTime today = DateTime.Today;
            strArr[3] = today.ToString("d");
            // amount in words
            strArr[1] = processAmount(strArr[5]);
            // check #
            strArr[4] = "" + (2000+Tally.getCount());
            // # of checks
            strArr[6] = "" + Tally.getCount();
            // sum of checks
            strArr[7] = "" + Tally.getTotal();
            
            return true;
        }

        // make sure input received is acceptable
        private static bool isCorrectInput(string amountString, string name, string memo)
        {
            // check if input is acceptable
            int periodCount = 0;
            int periodSpot = 0;
            int charSpot = -1;
            foreach (char c in amountString)
            {
                charSpot++;
                if (c != '.')
                {
                    if (!Char.IsDigit(c))
                    {
                        response = "Please only submit numbers and a period.";
                        return false;
                    }
                }
                else
                {
                    periodCount++;
                    periodSpot = charSpot;
                }
            }
            if (periodCount != 1)
            {
                response = "Please include a singular period in the amount input.";
                return false;
            }
            if (periodSpot != amountString.Length - 3)
            {
                response = "Please place a period before exactly the last two digits in the amount.";
                return false;
            }

            // check if amount is acceptable
            double doubleValue = Convert.ToDouble(amountString);
            if (doubleValue >= 10000)
            {
                response = "Please submit an amount with a value lower than 10,000.";
                return false;
            }
            if (doubleValue <= 0)
            {
                response = "Please submit an amount with a value higher than 0.";
                return false;
            }
            // name and memo character limit
            int nameLengthMax = 13;
            if (name.Length >= nameLengthMax)
            {
                response = "Please limit the name to less than " + nameLengthMax + " characters.";
                return false;
            }
            int memoLengthMax = 25;
            if (memo.Length >= memoLengthMax)
            {
                response = "Please limit the name to less than " + nameLengthMax + " characters.";
                return false;
            }

            response = "";
            return true;
        }

        // static strings only used in this function, so I placed them here
        private static string[] ones = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static string[] tens = new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        // recursive calculation of the amount as words
        private static string processAmount(string amount)
        {

            string[] splitIntAndDecimal = amount.ToString().Split('.');
            int integerHalf =((int) double.Parse(splitIntAndDecimal[0]));
            double decimalHalf = double.Parse(splitIntAndDecimal[1]);
            
            string toAddOn = "and " + decimalHalf + "/100";
            
            return recurseForInt(integerHalf) + toAddOn;
        }
        // recursively is called with an updated value of the remaining words to calculate, and returns words for the amount in English
        private static string recurseForInt(int remaining)
        {
            string toAdd = "";
            
            if (remaining >= 1000)
            {
                int numberOfThousands = remaining / 1000;
                toAdd += ones[numberOfThousands - 1] + " thousand ";
                return toAdd + recurseForInt(remaining % 1000);
            }

            if (remaining > 0)
            {
                if (remaining >= 100)
                {
                    int numberOfHundreds = remaining / 100;
                    toAdd += ones[numberOfHundreds - 1] + " hundred ";
                    remaining -= numberOfHundreds * 100;
                    if (remaining > 0)
                    {
                        toAdd += "and ";
                    }
                    return toAdd + recurseForInt(remaining);
                }

                if (remaining >= 20)
                {
                    int numberOfTens = remaining / 10;
                    toAdd += tens[numberOfTens - 2] + " ";
                    remaining -= numberOfTens * 10;
                    return toAdd + recurseForInt(remaining);
                }

                toAdd += ones[remaining - 1] + " ";
                remaining = 0;
                return toAdd;
            }


            return "";
        }

        // returns the array of data, will only be accessed if receiveInput is true
        public static string[] getOutput()
        {
            return strArr;
        }

        // returns the string for the response, will only be accessed if receiveInput is false
        public static string getResponse()
        {
            return response;
        }
    }
}
