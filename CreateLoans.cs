using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG_271
{
    internal class CreateLoans
    {
        PersonalLoan personal = new PersonalLoan(5);
        BusinessLoan business = new BusinessLoan(5);
        int  i=0;
        double primeInterestRate;
        string[] objectArray = new string[5];

        public enum loanType
        {
            Business = 1,
            Individual,
            Exit
        }

        public void loanMenu()
        {
            int choice;
            int stop = 1;

            Console.WriteLine("Please give the current Prime Interest Rate in Decimal Format (0.1054):");
            primeInterestRate = double.Parse(Console.ReadLine());
            Console.Clear();

            while (stop == 1)
            {
                Console.WriteLine($"Add {objectArray.Length - i} more people");
                Console.WriteLine("What loan type do you want?");
                Console.WriteLine(@"1. Business Loans
2. Individual Loans
3. Exit");
                choice = int.Parse(Console.ReadLine());

                loanType option = (loanType)choice;
                switch (option)
                {
                    case loanType.Business:
                        if (i > 4)
                        {
                            stop = 0;
                        }
                        else
                        {
                            BusinessLoan bloan = CreateBusinessLoan();
                            business[i] = bloan;
                            business[i].userInput();
                            business[i].interestAllocate(primeInterestRate);
                            objectArray[i] = business[i].ToString();
                            i++;
                        }
                        break;
                    case loanType.Individual:
                        if (i > 4)
                        {
                            stop = 0;
                        }
                        else
                        {
                            PersonalLoan ploan = CreatePersonalLoan();
                            personal[i] = ploan;
                            personal[i].userInput();
                            personal[i].interestAllocate(primeInterestRate);
                            objectArray[i] = personal[i].ToString();
                            i++;
                        }
                        break;
                    case loanType.Exit:
                        stop = 0;
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();
            foreach (var item in objectArray)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
        public BusinessLoan CreateBusinessLoan()
        {
            Console.WriteLine("Building Business Loan:");
            Console.WriteLine("Enter Loan Number:");
            int loanNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Name:");
            string customerFirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string customerLastName = Console.ReadLine();

            Console.WriteLine("Enter loan amount:");
            double loanAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Loan Term [1 , 3 or 5 years]:");
            int loanTerm = int.Parse(Console.ReadLine());

            BusinessLoan businessLoan = new BusinessLoan(loanNumber, loanTerm, customerLastName, customerFirstName, loanAmount, 0);
                return businessLoan;
        }
        public PersonalLoan CreatePersonalLoan()
        {
            Console.WriteLine("Building Personal Loan:");
            Console.WriteLine("Enter Loan Number:");
            int loanNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Name:");
            string customerFirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string customerLastName = Console.ReadLine();

            Console.WriteLine("Enter loan amount:");
            double loanAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Loan Term [1 , 3 or 5 years]:");
            int loanTerm = int.Parse(Console.ReadLine());

            PersonalLoan personalLoan = new PersonalLoan(loanNumber, loanTerm, customerLastName, customerLastName, loanAmount, 0);
                return personalLoan;
        }
    }
}
