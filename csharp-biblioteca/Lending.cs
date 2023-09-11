using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Lending
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public User User { get; set; }
        public Document Document { get; set; }

        public Lending(DateTime startTime, DateTime endTime, User user, Document document)
        {
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

        public void PrintInfoLending()
        {
            Console.WriteLine("User loan information: ");
            Console.WriteLine($"Start Time: {this.StartTime}\r\nEnd Time: {this.EndTime}\r\n User: {User.Firstname} {User.Lastname}\r\nDocument: {Document.Code} {Document.Title}");
        }

    }
}
