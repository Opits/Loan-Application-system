using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG_271
{
    public class PersonalLoan : Loan
    {

        public PersonalLoan(int loanNumber, int term, string customerLastName, string customerFirstName, double loanAmount, double interestRate) : base(loanNumber, term, customerLastName, customerFirstName, loanAmount, interestRate)
        {
        }

        public override void interestAllocate(double primeInterestRate)
        {
            InterestRate = primeInterestRate + 0.02;
        }
    }
}
