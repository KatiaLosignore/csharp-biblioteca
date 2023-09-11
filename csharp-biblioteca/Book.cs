using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {
        // PROPRIETA'
        public int NumberOfPages { get; set; }

        // COSTRUTTORE
        public Book(string code, string title, int year, string category, string position, string author, int numberOfPages) : base(code, title, year, category, position, author)
        {
            this.NumberOfPages = numberOfPages;
        }

        // METODI
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Number of Pages: {this.NumberOfPages}");
        }
    }
}
