//Jordan Fox - Team Haymitch 
//Due 2/2/2016
//CS325-002 Project 0 part 2
//G. Mayer
//class responsible for writing the data given to the files and reading the information back to show the customer.
//Will take input from Jacob's class, format it to save to the file, and also pull from the file in the correct format for Jacob's class to read.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IntroProject;



namespace IntroProject
{

        
   public class file_io
    {
  



        public double[] read(string fileName)
        {
            var reader = new StreamReader(File.OpenRead(fileName));
            int NextCheck = 1001;
            string[] values;
            double balance = 0.0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                values = line.Split(',');
                balance = double.Parse(values[5]);
                if (values[3].Equals("CHECK"))
                {
                    NextCheck = int.Parse(values[1]);
                }
            }

            reader.Dispose();
            double[] output = new double[2];
            output[0] = balance;
            output[1] = Convert.ToDouble(NextCheck);
            return output;
        }


        public void write(string fileName, string output)
        {
            //output to the filename the string output on a new line
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(output);
            }

        }
        //sample of what output should look like.
        // cash: "date + ',' + "CASH" + ',' + amount + ',' + "CASH" + ',' + memo + ',' + newBalance + \n"
        // check: "date + ',' + checkNumber + ',' + amount + ',' + toField + ',' + memo + ',' + newBalance + \n"
        // deposit: "date + ',' + "DEPOSIT" + ',' + amount + ',' + "DEPOSIT" + ',' + memo + ',' + newBalance + \n"




    }
}
