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
<<<<<<< HEAD
            CardCatalog.MenuDisplay();





            Console.ReadLine();



            Console.ReadLine();

=======
            bookCatalog.MenuDisplay();
            Console.ReadLine();
>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88
        }

        public class CardCatalog
        {
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

<<<<<<< HEAD





            public static List<Book> listOfBooks = new List<Book> { };
              

            
=======
            private List<Book> listOfBooks = new List<Book> { };
>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88


            public static void MenuDisplay()
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. List All Books");
                Console.WriteLine("2. Add a Book");
                Console.WriteLine("3. Save and Exit");
                Console.WriteLine("What would you like to do?");
<<<<<<< HEAD
                int userInput = Convert.ToInt32(Console.ReadLine());              
                    


                MenuDisplayLogic(userInput);
                 

            }
            
            
            
           
            public static void MenuDisplayLogic(int userInput)
=======
                int userInput = Convert.ToInt32(Console.ReadLine());
                MenuDisplayLogic(userInput); 
            }

            public void MenuDisplayLogic(int userInput)
>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88
            {
                for (var i = 0; i < userInput; i++)
                {
                    if (userInput == 1)
                    {
                        Console.WriteLine($"you've entered {userInput}");

                        // run method ListAllbook()
<<<<<<< HEAD

                        
                       // call MenuDisplay at the end of choice 

                        MenuDisplay();


=======
                        ListAllBooks();
                        // call MenuDisplay at the end of choice 1
>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88
                    }

                    if (userInput == 2)
                    {
                        Console.WriteLine($"you've entered {userInput}");
                        // run method AddABook()
<<<<<<< HEAD
                        CardCatalog.AddABook();
                        MenuDisplay();
=======
                        AddABook();
>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88

                        // call MeneDisplay at the en of chocice 2
                    }
                    if (userInput == 3)
                    {
<<<<<<< HEAD
                        Console.WriteLine($"you've entered {userInput}, Are you sure you want to exit?");                   
                        
                        // run method SaveAndExit()
                        CardCatalog.SaveAndExit();
                        MenuDisplay();

=======
                        Console.WriteLine($"you've entered {userInput}");
                        // run method Save()
                        Save();
>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88
                    }
                }
            }

<<<<<<< HEAD

            public static void ListAllBooks()
            {
                Console.Write("List All Books \n");
                Console.WriteLine("\n");                

               



=======
            public void ListAllBooks()
            {
                Console.Write("List All Books \n");
                Console.WriteLine("\n");
                MenuDisplay();
>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88
            }

            public void AddABook()
            {
<<<<<<< HEAD

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
                    Console.WriteLine("\n");
                    MenuDisplay();



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
                    Console.WriteLine("\n");
                
                MenuDisplay();

=======
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
>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88
            }

            public void Save()
            {
<<<<<<< HEAD
                Console.WriteLine("Save and Exit");
=======
               string filePath = @"C:\Users\Andrey\Downloads\" + FileName + ".txt";

               using (TextWriter tw = new StreamWriter(filePath))
               {
                  foreach (var book in listOfBooks)
                  {
                     tw.WriteLine(string.Format("Title: {0}\r\n Author: {1}\r\n Genre: {2}\r\n Number of Pages: {3}\r\n Year Published: {4}\r\n", book.Title, book.Author, book.Genre, book.NumberOfPages, book.YearPublished));
                     tw.WriteLine(Environment.NewLine);
                  }
               }
               
>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88
            }


            
        }
<<<<<<< HEAD
        
=======

>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88
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
<<<<<<< HEAD

=======
>>>>>>> 57caebc515497a3be08e9259feae9a9ac1ce3a88
    }
    
    
}
