using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
    {
        // PROPRIETA'
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<Document> Documents { get; set; }
        public List<Lending> Lendings { get; set; }

        // COSTRUTTORI

        public Library(string name)
        {
            this.Name = name;
            this.Users = new List<User>();
            this.Documents = new List<Document>();
            this.Lendings = new List<Lending>();
        }

    }
}
