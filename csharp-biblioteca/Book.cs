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
        public Book(string code, string title, int year, string category, string position, string author) : base(title, year, category, position, author)
        {
            this.NumberOfPages = GetRandom();
        }

        // METODI

        public override int GetRandom()
        {
            // Genera un numero da 80 and 1000
            int min = 80;
            int max = 1000;
            int randNumber = Random.Shared.Next(min, max);

            return randNumber;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Number of Pages: {this.NumberOfPages}");
        }
    }
}
