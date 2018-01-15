using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TheBestLibraryCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            CardCatalog bookCatalog = new CardCatalog();
            Console.WriteLine("Enter a file name");
            bookCatalog.FileName = Console.ReadLine();
            bookCatalog.MenuDisplay();
            Console.ReadLine();
            
        }
        
        public class CardCatalog
        {
            public string message = "Enter a valid Number!";
            private string _filename;

            public string FileName
            {
                get
                {
                    return _filename;
                }
                set
                {
                    _filename = value;
                }
            }

            private List<Book> listOfBooks = new List<Book> { };

            public void MenuDisplay()
            {
                
                Console.WriteLine("\n");
                Console.WriteLine("What would you like to do?");                
                Console.WriteLine("1. List All Books");
                Console.WriteLine("2. Add a Book");
                Console.WriteLine("3. Save and Exit");
                
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                MenuDisplayLogic(userInput);

            }
            
            public void MenuDisplayLogic(int userInput)
            {
                
                    if (userInput == 1)
                    {
                        Console.WriteLine($"You've selected {userInput}: List all books.");

                        // run method ListAllbook()
                        Save();
                        ListAllBooks();                        
                    }
                    if (userInput == 2)
                    {
                        Console.WriteLine($"you've entered {userInput}: Add a book");
                        // run method AddABook()
                        AddABook();                       
                    }
                    if (userInput == 3)
                    {
                        Console.WriteLine($"you've entered {userInput}: Press enter to exit!");
                        // run method Save()
                        Save();
                    }
                
                
                
                    
               
            
            }

            public void ListAllBooks()
            {
                foreach (var book in listOfBooks)
                {
                    Console.WriteLine($"Title: {book.Title} by {book.Author}");                   
                }
                
                MenuDisplay();
            }

            public void AddABook()
            {
                Book aBook = new Book();

                Console.WriteLine("What's the name of the book?");
                aBook.Title = Console.ReadLine();

                Console.WriteLine("Who's the author?");
                aBook.Author = Console.ReadLine();

                Console.WriteLine("What's the genre?");
                aBook.Genre = Console.ReadLine();

                Console.WriteLine("How many pages is the book?");
                aBook.NumberOfPages = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("When was it publised?");
                aBook.YearPublished = Convert.ToInt32(Console.ReadLine());

                listOfBooks.Add(aBook);
                Console.WriteLine("{0} has been added to the card catalog", aBook.Title);
                MenuDisplay();
            }

            public void Save()
            {
                string filePath = @"C:\Users\chami\Documents\CODING\CodingTemple\C# Project\TheBestLibraryCatalog" + FileName + ".txt";

                using (TextWriter tw = new StreamWriter(filePath))
                {
                    foreach (var book in listOfBooks)
                    {
                        tw.WriteLine(string.Format("Title: {0}\r\n Author: {1}\r\n Genre: {2}\r\n Number of Pages: {3}\r\n Year Published: {4}\r\n", book.Title, book.Author, book.Genre, book.NumberOfPages, book.YearPublished));
                        tw.WriteLine(Environment.NewLine);
                    }
                }

            }
        }

        public class Book
        {
            private string _title;
            public string Title { get { return _title; } set { _title = value; } }

            private string _author;
            public string Author { get { return _author; } set { _author = value; } }

            private string _genre;
            public string Genre { get { return _genre; } set { _genre = value; } }

            private int _numberOfPages;
            public int NumberOfPages { get { return _numberOfPages; } set { _numberOfPages = value; } }

            private int _yearPublished;
            public int YearPublished { get { return _yearPublished; } set { _yearPublished = value; } }
        }
    }
}