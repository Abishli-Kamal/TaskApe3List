using System;

namespace Task8Ape3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Az-dili","Resad dagli",200);
          
            Book book1 = new Book("Musiqi", "Orxan Lokbatanli", 150);
            
            Book book2 = new Book("Heyat bilgisi", "Balaeli", 120);
            

            Libary libary = new Libary();
            libary.books.Add(book);
            libary.books.Add(book1);
            libary.books.Add(book2);


            Console.WriteLine("FindAllBooksByPageCountRange:");
            foreach (var item in libary.FindAllBooksByPageCountRange(50,300))
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("FindAllBooksbyName:");
            foreach (var item in libary.FindAllBooksbyName("Az-dili"))
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("RemoveBooksbyName:");
            libary.RemoveBooksbyName("Musiqi");
            foreach (var item in libary.books)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("RemoveBooksbyCode:");
           
            libary.RemoveBooksbyCode("HE-3");
            foreach (var item in libary.books)
            {
                Console.WriteLine(item.Name);
            }

            
        }
    }
}
