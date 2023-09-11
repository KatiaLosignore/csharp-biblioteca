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

        public void PrintInfoUser()
        {
            Console.WriteLine($"Lastname: {this.Lastname}\r\nFirstname: {this.Firstname}\r\nEmail: {this.Email}\r\nPassword: {this.Password}\r\nPhoneNumber: {this.PhoneNumber}");
        }
    }
}



