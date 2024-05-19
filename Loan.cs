using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG_271
{
    public abstract class Loan : ILoanConstants
    {
        private int loanNumber, term=0;
        private string customerLastName, customerFirstName;
        private double loanAmount, interestRate;

        protected Loan(int loanNumber, int term, string customerLastName, string customerFirstName, double loanAmount)
        {
            this.LoanNumber = loanNumber;
            this.Term = term;
            this.CustomerLastName = customerLastName;
            this.CustomerFirstName = customerFirstName;
        }

        protected Loan(int loanNumber, int term, string customerLastName, string customerFirstName, double loanAmount, double interestRate)
        {
            this.LoanNumber = loanNumber;
            this.Term = term;
            this.CustomerLastName = customerLastName;
            this.CustomerFirstName = customerFirstName;
            this.LoanAmount = loanAmount;
            this.InterestRate = interestRate;

            if (loanAmount <= MaxLoan)
            {
                this.LoanAmount = loanAmount;
            }
            else
            {
                this.LoanAmount = MaxLoan;
            }
        }

        public int LoanNumber { get => loanNumber; set => loanNumber = value; }
        public int Term { get => term; set => term = value; }
        public string CustomerLastName { get => customerLastName; set => customerLastName = value; }
        public string CustomerFirstName { get => customerFirstName; set => customerFirstName = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }

        public void userInput()
        {
            int value;
            int controlValue = 0;

            Console.WriteLine("What is your loan number?");
            loanNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("What is your first name?");
            customerFirstName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("What is your last name?");
            customerLastName = Console.ReadLine();

                    
            while (controlValue == 0)
            {
                Console.WriteLine();
                Console.WriteLine("What is your loan amount?");
                loanAmount = double.Parse(Console.ReadLine());

                if (loanAmount > MaxLoan)
                {
                    Console.WriteLine($"Amount over the capped amount of {MaxLoan}... Try Again");
                    Console.WriteLine("Press Enter...");
                    Console.ReadKey();
                    controlValue = 0;
                }
                else
                {
                    controlValue = 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("How long do you want to repay the laon? 1-year, 3-years, or 5-years:");
            value = int.Parse(Console.ReadLine());
            if (value == Short_term)
            {
                term = Short_term;
            }
            else if (value == Medium_term)
            {
                term = Medium_term;
            }
            else if (value == Long_term)
            {
                term = Long_term;
            }
            else
            {
                term = Short_term;
                Console.WriteLine($"Default term has been selected for you. {term}-year");
                Console.WriteLine("Press Enter...");
                Console.ReadKey();
            }
        }

        public override string ToString()
        {
            return $@"-----------------------------------------------------------
Title                       Details
-----------------------------------------------------------
Loan Number:                {LoanNumber}
First Name:                 {CustomerFirstName}
Last Name:                  {CustomerLastName}
Loan Amount:                R {LoanAmount}
Interest:                   {InterestRate} / {InterestRate * 100} Percent
Term:                       {Term} year/s
Total Amount Owed:          R {LoanAmount + (LoanAmount * InterestRate)}"
;
        }

        public abstract void interestAllocate(double primeInterestRate);
    }
}
