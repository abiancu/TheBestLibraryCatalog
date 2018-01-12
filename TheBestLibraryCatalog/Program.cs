using System;
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
            bookCatalog.MenuDisplay();
           
                    

            

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
            

            public void MenuDisplay()
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
                    if (userInput == 1)
                    {
                        Console.WriteLine($"you've entered {userInput}");

                        // run method ListAllbook()
                        CardCatalog.ListAllBooks();
                        // call MenuDisplay at the end of choice 1


                    }
                    if (userInput == 2)
                    {
                        Console.WriteLine($"you've entered {userInput}");
                        // run method AddABook()
                        CardCatalog.AddABook();

                        // call MeneDisplay at the en of chocice 2
                    }
                    if (userInput == 3)
                    {
                        Console.WriteLine($"you've entered {userInput}");
                        // run method SaveAndExit()
                        CardCatalog.SaveAndExit();
                    }
                
            }
            public static void ListAllBooks()
            {
                Console.Write("List All Books"); // here enter the book objects
            }

            public static void AddABook()
            {
                Console.Write("Add A Book");
            }

            public static void SaveAndExit()
            {
                Console.Write("Save and Exit");
            }
        }
    }
}
