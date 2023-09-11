using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        // PROPRIETA'
        public int Duration { get; set; }

        // COSTRUTTORE
        public Dvd(string code, string title, int year, string category, string position, string author, int duration) : base(code, title, year, category, position, author)
        {
            this.Duration = duration;
        }


        // METODI
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Duration: {this.Duration} minutes");
        }


    }
}
