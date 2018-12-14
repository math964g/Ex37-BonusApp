using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Bonuses : BonusProvider
    {
        public static double TenPercent(double amount)
        {
            return amount * 0.10;
        }

        public static double FlatTwoIfAmountMoreThanFive(double amount)
        {
            double returnValue = 0;

            if (amount > 5)
            {
                returnValue = 2.0;
            }

            else
            {
                returnValue = 0.0;
            }

            return returnValue;
        }
    }
}
