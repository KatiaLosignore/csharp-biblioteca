using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        // PROPRIETA'

        public static int TotalDocumentCreated = 0;
        public string Code { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Category { get; set; }

        public string Position { get; set; }

        public string Author { get; set; }


        // COSTRUTTORE

        public Document(string title, int year, string category, string position, string author)
        {
            this.Code = $"{TotalDocumentCreated} - {title[0].ToString().ToUpper()}-{GetRandom()}";
            TotalDocumentCreated++;
            this.Title = title;
            this.Year = year;
            this.Category = category;
            this.Position = position; 
            this.Author = author;
        }

        // METODI

        // Genera un numero random
        public virtual int GetRandom()
        {
            // Generate a random number between 1 and 1000
            int min = 1;
            int max = 1000;

            int randNumber = Random.Shared.Next(min, max);

            return randNumber;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Code: {this.Code}\r\nTitle: {this.Title}\r\nYear: {this.Year}\r\nCategory: {this.Category}\r\nPosition: {this.Position}\r\nAuthor: {this.Author}");
        }
    }
}
