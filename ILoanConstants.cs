using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG_271
{
    public class ILoanConstants
    {
        const int short_term = 1, medium_term = 3, long_term = 5;

        const string CompanyName = "Unique Building Services Loan Company";

        const double maxLoan = 100000;

        public ILoanConstants()
        {
        }

        public static int Short_term => short_term;

        public static int Medium_term => medium_term;

        public static int Long_term => long_term;

        public static string CompanyName1 => CompanyName;

        public static double MaxLoan => maxLoan;
    }
}
