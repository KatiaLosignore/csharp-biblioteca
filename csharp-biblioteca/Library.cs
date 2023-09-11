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


        // METODI

        // Metodo per aggiungere un Utente
        public void AddUser(User user)
        {
            this.Users.Add(user);
        }

        // Metodo per aggiungere un libro
        public void AddBook(Book book)
        {
            this.Documents.Add(book);
        }

        // Metodo per aggiungere un Dvd
        public void AddDvd(Dvd dvd)
        {
            this.Documents.Add(dvd);
        }

        // Metodo per aggiungere un prestito
        public void AddLending(DateTime startTime, DateTime endTime, User user, Document document)
        {
            Lending lending = new Lending()
            {
                StartTime = startTime,
                EndTime = endTime,
                User = user,
                Document = document
            };

            this.Lendings.Add(lending);
            Console.WriteLine($"You have successfully added a loan!");
        }

        // Metodo per cercare un documento per codice
        public Document SearchDocumentByCode(string code)
        {
            return this.Documents.Find(doc => doc.Code == code);
        }

        // Metodo per cercare un documento per titolo
        public List<Document> SearchDocumentByTitle(string title)
        {
            return this.Documents.FindAll(doc => doc.Title.Contains(title));
        }

        // Metodo per cercare prestiti con il nome e cognome Utente

        public List<Lending> SearchLendingUser(string firstName, string lastName)
        {
            return Lendings.FindAll(lending => lending.User.Firstname == firstName && lending.User.Lastname == lastName);
        }



        


    }

 }





