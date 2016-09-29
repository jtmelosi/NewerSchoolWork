using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProject
{
    public class checkbook
    {
        string filename;
        double balance;
        int checkNum;
        file_io input = new file_io();
        public checkbook(string filename)
        {
            //loads existing checkbook
            double[] output = input.read(filename);
            this.filename = filename;
            balance = output[0];
            checkNum = Convert.ToInt32(output[1]);
        }
        public checkbook(string filename, double balance) 
        {
            //creates new checkbook
            this.filename = filename;
            this.balance = balance;
            checkNum = 1000;
            DateTime date = DateTime.Now.Date;
            string output = date.ToString("MM/dd/yyyy") + ",DEPOSIT," + balance.ToString() + ",DEPOSIT,INITIAL," + balance.ToString();
            input.write(filename, output);
        }
        public double getBalance()
        {
            return balance; 
        }
        public void check(string amt, string memo, string name, bool show)
        {
            //writes the check and saves the new balance
            double amount = Convert.ToDouble(amt);
            balance -= amount;
            checkNum++;
            DateTime date = DateTime.Now.Date;
            string output = date.ToString("MM/dd/yyyy") + "," + checkNum.ToString() + "," + amt + ",CHECK," + memo + "," + balance.ToString();
            input.write(filename, output);
            if (show)
            {
                output_gui form = new output_gui(name, amt, memo, date.ToString("MM/dd/yyyy"), checkNum.ToString(), processAmount(amt));
                form.Show();
            }
        }
        public void cash(double amt, string memo)
        {
            //writes the cash pull and saves the new balance
            balance -= amt;
            DateTime date = DateTime.Now.Date;
            string output = date.ToString("MM/dd/yyyy") + ",CASH," + amt.ToString() + ",CASH," + memo + "," + balance.ToString();
            input.write(filename, output);
        }
        public void deposit(double amt, string memo)
        {
            //writes the deposit and saves the new balance
            balance += amt;
            DateTime date = DateTime.Now.Date;
            string output = date.ToString("MM/dd/yyyy") + ",DEPOSIT," + amt.ToString() + ",DEPOSIT," + memo + "," + balance.ToString();
            input.write(filename, output);
        }

        //code copied from Processor.cs
        // static strings only used in this function, so I placed them here
        private static string[] ones = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static string[] tens = new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        // recursive calculation of the amount as words
        private static string processAmount(string amount)
        {
            string[] splitIntAndDecimal = amount.ToString().Split('.');
            int integerHalf = ((int)double.Parse(splitIntAndDecimal[0]));
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
    }
}