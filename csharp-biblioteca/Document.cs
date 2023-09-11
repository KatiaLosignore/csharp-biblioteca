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

        public string Code { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Category { get; set; }

        public int Position { get; set; }

        public string Author { get; set; }


        // COSTRUTTORE

        public Document(string code, string title, int year, string category, int position, string author)
        {
            this.Code = code;
            this.Title = title;
            this.Year = year;
            this.Category = category;
            this.Position = position; 
            this.Author = author;
        }

        // METODI
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Code: {this.Code}\r\nTitle: {this.Title}\r\nYear: {this.Year}\r\nCategory: {this.Category}\r\nPosition: {this.Position}\r\nAuthor: {this.Author}");
        }
    }
}
