// See https://aka.ms/new-console-template for more information

using csharp_biblioteca;
using System.Runtime.Intrinsics.X86;


// Istanzio la classe Library
Library library = new Library("LibraryOne");

// Istanzio la classe Book
Book bookOne = new Book("5897","Twilight", 2006, "Novel", "15A", "Stephenie Meyer");
Book bookTwo = new Book("4897", "Tokyo Express", 2020, "Shonen", "28B", "Seichö Matsumoto");
Book bookThree = new Book("4991", "One Piece", 2000, "Novel", "23B", "Eichiro Oda");

// Istanzio la classe Dvd
Dvd dvdOne = new Dvd("1485", "Sonic", 2020, "Adventure", "125A", "Jeff Fowler");
Dvd dvdTwo = new Dvd("2425", "Pinocchio", 2013, "Fantasy", "250B", "Enzo D'Alò");
Dvd dvdThree = new Dvd("1525", "The Witcher", 2023, "Fantasy", "350B", "Denis Thampton");

// Istanzio la classe User
User userOne = new User("Verdi", "Giacomo", "giacomo@gmail.com", "giacomoverdi", "+393332147893");
User userTwo = new User("Rossi", "Luca", "luca@gmail.com", "lucarossi", "+393312596123");
User userThree = new User("Bianchi", "Giovanna", "gbianchi@gmail.com", "giovannabianchi", "+393338963147");

// Aggiungo i documenti creati alla biblioteca (book e dvd)
library.AddDocs(bookOne);
library.AddDocs(bookTwo);
library.AddDocs(bookThree);

library.AddDocs(dvdOne);
library.AddDocs(dvdTwo);
library.AddDocs(dvdThree);

// Aggiungo gli user alla biblioteca

library.AddUser(userOne);
library.AddUser(userTwo);
library.AddUser(userThree);

Console.WriteLine($"The number of documents present in the library is: {library.GetTotalDocuments()} documents");

library.ToString();



foreach (Document doc in library.GetListOfDocuments())
{
    Console.WriteLine(doc);
}

Lending newLoan = library.RegisterAndGetLoan(DateTime.Now, DateTime.Now.AddDays(2), userOne, dvdOne);
Console.WriteLine(newLoan);

Lending newLoan2 = library.RegisterAndGetLoan(DateTime.Now.AddDays(3), DateTime.Now.AddDays(6), userTwo, dvdTwo);
Console.WriteLine(newLoan2);

Lending newLoan3 = library.RegisterAndGetLoan(DateTime.Now, DateTime.Now.AddDays(2), userThree, dvdThree);
Console.WriteLine(newLoan3);








