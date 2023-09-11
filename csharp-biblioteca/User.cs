using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        // PROPRIETA'
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        
        // COSTRUTTORE
        public User(string lastname, string firstname, string email, string password, string phoneNumber)
        {
            this.Lastname = lastname;
            this.Firstname = firstname;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
        }


        // METODI

        public void InfoRequestUser()
        {
            Console.WriteLine("Insert your Lastname:");
            this.Lastname = Console.ReadLine();

            Console.WriteLine("Insert your Firstname:");
            this.Firstname = Console.ReadLine();

            Console.WriteLine("Insert your Email:");
            this.Email = Console.ReadLine();

            Console.WriteLine("Insert your Password:");
            this.Password = Console.ReadLine();

            Console.WriteLine("Insert your Telephone number:");
            this.PhoneNumber = Console.ReadLine();
        }

    }
}
