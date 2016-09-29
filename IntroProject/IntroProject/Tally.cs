using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProject
{
    public class Tally
    {

        private static int count;
        private static double total;

        public static void increaseTally(double amountIncreased)
        {
            total += amountIncreased;
            count++;
        }

        public static double getTotal()
        {
            return total;
        }

        public static int getCount()
        {
            return count;
        }



    }
}
