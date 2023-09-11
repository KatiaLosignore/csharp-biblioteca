// See https://aka.ms/new-console-template for more information

using csharp_biblioteca;
/*
Document doc = new Document("1000", "titolo", 1950, "Matematica", 15, "Paul");

doc.PrintInfo();
*/

// Istanzio la classe Library
Library library = new Library("LibraryOne");

// Istanzio la classe Book
Book bookOne = new Book("5897", "Twilight", 2006, "Novel", "15A", "Stephenie Meyer", 412);
Book bookTwo = new Book("4897", "Tokyo Express", 2020, "Novel", "23B", "Seichö Matsumoto", 402);

// Istanzio la classe Dvd
Dvd dvdOne = new Dvd("1485", "Sonic", 2020, "Adventure", "125A", "Jeff Fowler", 100);
Dvd dvdTwo = new Dvd("2425", "Pinocchio", 2013, "Fantasy", "250B", "eNZO D'Alò", 120);

// Aggiungo i documenti creati alla biblioteca
library.AddBook(bookOne);
library.AddBook(bookTwo);
library.AddDvd(dvdOne);
library.AddDvd(dvdTwo);

// Stampo i documenti aggiunti
List<Document> list = new List<Document>();

list.Add(bookOne);
list.Add(bookTwo);
list.Add(dvdOne);
list.Add(dvdTwo);

Console.WriteLine($"The documents register here are: ");

foreach(Document document in list)
{
    document.PrintInfo();
}

Console.WriteLine("---------------------------------------");

// Creo uno User
User userOne = new User("Bianchi", "Mario", "bianchi@gmail.com", "mariobianchi", "+393335841158");

// Stampo Info User
Console.WriteLine("The User created is the following: ");
userOne.PrintInfoUser();

Console.WriteLine("---------------------------------------");

// Aggiungo lo User alla Biblioteca
library.AddUser(userOne);

// Registro un prestito
Lending lendingOne = new Lending(DateTime.Now, DateTime.Now.AddDays(19), userOne, bookTwo);

library.AddLending(DateTime.Now, DateTime.Now.AddDays(15), userOne, bookOne);
lendingOne.PrintInfoLending();

Console.WriteLine("---------------------------------------");

// // Cerco documento per codice
Document documentoSearch = library.SearchDocumentByCode("5897");
if (documentoSearch != null)
{
    Console.WriteLine("Document found: " + documentoSearch.Code);
}
else
{
    Console.WriteLine("Document not found");
}

// Cerco un documento per Titolo

List<Document> documentSearch = library.SearchDocumentByTitle("Twilight");

foreach (var document in documentSearch)
{
    Console.WriteLine($"Your researched is: { document.Title}");
}

// Cerco per nome e cognome

List<Lending> lendingUser = library.SearchLendingUser("Mario", "Bianchi");

foreach ( var lending in lendingUser)
{
    Console.WriteLine($"Lending of book: {lending.Document.Title} , User: {lending.User.Firstname} {lending.User.Lastname}");
}