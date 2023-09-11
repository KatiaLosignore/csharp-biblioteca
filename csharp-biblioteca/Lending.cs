using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Lending
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public User User { get; set; }
        public Document Document { get; set; }

        public Lending(User user, Document document)
        {
            this.User = user;
            this.Document = document;

            Console.WriteLine("Insert start date (dd/mm/yyyy)");
            this.StartTime = Console.ReadLine();

            Console.WriteLine("Insert end date (dd/mm/yyy)");
            this.EndTime = Console.ReadLine();
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

        public void PrintInfoU()
        {
            Console.WriteLine("User loan information: ");
            Console.WriteLine($"Start Time: {this.StartTime}\r\nEnd Time: {this.EndTime}\r\n User: {User.Firstname} {User.Lastname}\r\nDocument: {Document.Code} {Document.Title}");
        }

    }
}
