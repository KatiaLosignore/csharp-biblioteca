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
        public Dvd(string code, string title, int year, string category, string position, string author) : base(title, year, category, position, author)
        {
            this.Duration = GetRandom();
        }


        // METODI

        public override int GetRandom()
        {
            // Genera un numero random da 80 and 1000
            int min = 60;
            int max = 181;
            int randNumber = Random.Shared.Next(min, max);

            return randNumber;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Duration: {this.Duration} minutes");
        }


    }
}
