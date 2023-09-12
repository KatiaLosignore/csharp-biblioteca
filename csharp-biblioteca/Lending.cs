using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Lending
    {
        public int LoanNumber { get; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public User User { get; set; }
        public Document Document { get; set; }

        public Lending(int loanNumber, DateTime startTime, DateTime endTime, User user, Document document)
        {
            this.LoanNumber = loanNumber;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.User = user;
            this.Document = document;
        }



        // METODI

        public static bool LendingUser()
        {
            Console.WriteLine("Would you like to borrow the document? (y/n)");
            string choice = Console.ReadLine();

            while (choice == null || choice != "y" && choice != "n")
            {
                Console.WriteLine("Insert 'y' or 'n'");
                choice = Console.ReadLine();
            }

             return choice == "y";
            
        }

        public override string ToString()
        {
            return $"Loan {this.LoanNumber}: {this.User} - {this.StartTime} until {this.EndTime}";
        }
        
        /*
        *public void PrintInfoLending()
        {
          Console.WriteLine("User loan information: ");
            Console.WriteLine($"Start Time: {this.StartTime}\r\nEnd Time: {this.EndTime}\r\nUser: {User.Firstname} {User.Lastname}\r\nDocument: {Document.Code} {Document.Title}");
        }

        */
    }
}
