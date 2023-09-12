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

        private int loanNextNumber = 1;
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Dictionary<string, Document> Documents { get; set; }
        public List<Lending> Lendings { get; set; }

        // COSTRUTTORI

        public Library(string name)
        {
            this.Name = name;
            this.Users = new List<User>();
            this.Documents = new Dictionary<string, Document>();
            this.Lendings = new List<Lending>();
        }

        // GETTERS
        public int GetTotalDocuments()
        {
            return Documents.Count;
        }

        public List<Document> GetListOfDocuments()
        {
            List<Document> documentList = new List<Document>();

            var listDocument = Documents.Values;

            foreach (var doc in listDocument)
            {
                documentList.Add(doc);
            }

            return documentList;
        }


        // METODI

        // Metodo per aggiungere un Utente
        public void AddUser(User user)
        {
            this.Users.Add(user);
        }

        // Metodo per aggiungere un documento 
        public void AddDocs(Document document)
        {
            this.Documents.Add(document.Code, document);
        }

        // Metodo per aggiungere un prestito 

        public void AddLending(Lending loan)
        {
            Lendings.Add(loan);
        }


        // Metodo bool di registrazione prestito
        public bool RegisterLoan(User user, Document document, DateTime startTime, DateTime endTime)
        {
            if (!Users.Contains(user))
            {
                Console.WriteLine("User not registered in database");
                return false;
            }

            if (!Documents.ContainsKey(document.Code))
            {
                Console.WriteLine("Document not available");
                return false;
            }

            foreach (var key in Lendings)
            {
                if (key.Document == document && key.EndTime >= key.StartTime)
                {
                    Console.WriteLine("Document has already been loaned");
                    return false;
                }
            }

            var loan = new Lending(loanNextNumber, startTime, endTime, user, document);

            Lendings.Add(loan);

            loanNextNumber++;

            Console.WriteLine("Loan registered successfully");
            return true;

        }


        public Lending RegisterAndGetLoan(DateTime startTime, DateTime endTime, User user, Document document)
        {

            if (startTime < DateTime.Now.AddMinutes(-1) || startTime > endTime)
            {
                throw new Exception("Loan is not corrected! Please check dates");

            }

            if (!Users.Contains(user))
            {
                Console.WriteLine("User not registered in database");
                return null;
            }

            if (!Documents.ContainsKey(document.Code))
            {
                Console.WriteLine("Document not available");
                return null;
            }

            foreach (var loanRetrieved in Lendings)
            {
                if (loanRetrieved.Document == document && loanRetrieved.EndTime >= startTime)
                {
                    Console.WriteLine("Document has already been loaned");
                    return null;
                }
            }

            var loan = new Lending(loanNextNumber, startTime, endTime, user, document);
            Lendings.Add(loan);

            loanNextNumber++;

            Console.WriteLine("Loan registered successfully");
            return loan;

        }



        // Metodo per cercare un documento per codice
        public Document SearchDocumentByCode(string code)
        {
            var findDocCode = Documents[code];
            return findDocCode;
        }

        // Metodo per cercare un documento per titolo
        public List<Document> SearchDocumentByTitle(string title)
        {
            List<Document> retrievedDocuments = new List<Document>();

            var listDocument = Documents.Values;

            foreach (var doc in listDocument)
            {
                if (doc.Title == title)
                {
                    retrievedDocuments.Add(doc);
                }
            }

            return retrievedDocuments;

        }

        // Metodo per cercare prestiti con il nome e cognome Utente

        public List<Lending> SearchLendingByUser(string firstName, string lastName)
        {
            var findUserLoan = Lendings.FindAll(lending => lending.User.Firstname.ToLower() == firstName.ToLower() && lending.User.Lastname.ToLower() == lastName.ToLower());
            return findUserLoan;

        }

    }

 }





