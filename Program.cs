using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG_271
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateLoans loans = new CreateLoans();
            loans.loanMenu();
            Console.ReadKey();
        }
    }
}
