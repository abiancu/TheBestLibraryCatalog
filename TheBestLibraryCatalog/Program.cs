﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            CardCatalog.MenuDisplay();





            Console.ReadLine();



            Console.ReadLine();

        }

        public class CardCatalog
        {
            private string _filename;

            public string FileName
            {
                get
                {
                    return "_filename";
                }
                set
                {
                    _filename = value;
                }
            }






            public static List<Book> listOfBooks = new List<Book> { };
              

            


            public static void MenuDisplay()
            {
                Console.WriteLine("1. List All Books");
                Console.WriteLine("2. Add a Book");
                Console.WriteLine("3. Save and Exit");
                Console.WriteLine("What would you like to do?");
                int userInput = Convert.ToInt32(Console.ReadLine());              
                    


                MenuDisplayLogic(userInput);
                 

            }
            
            
            
           
            public static void MenuDisplayLogic(int userInput)
            {
                for (var i = 0; i < userInput; i++)
                {
                    if (userInput == 1)
                    {
                        Console.WriteLine($"you've entered {userInput}");

                        // run method ListAllbook()

                        
                       // call MenuDisplay at the end of choice 

                        MenuDisplay();


                    }

                    if (userInput == 2)
                    {
                        Console.WriteLine($"you've entered {userInput}");
                        // run method AddABook()
                        CardCatalog.AddABook();
                        MenuDisplay();

                        // call MeneDisplay at the en of chocice 2
                    }
                    if (userInput == 3)
                    {
                        Console.WriteLine($"you've entered {userInput}, Are you sure you want to exit?");                   
                        
                        // run method SaveAndExit()
                        CardCatalog.SaveAndExit();
                        MenuDisplay();

                    }
                }
            }


            public static void ListAllBooks()
            {
                Console.Write("List All Books \n");
                Console.WriteLine("\n");                

               



            }

            public static void AddABook()
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

            }

            public static void SaveAndExit()
            {
                Console.WriteLine("Save and Exit");
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
