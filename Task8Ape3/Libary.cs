using System;
using System.Collections.Generic;
using System.Text;

namespace Task8Ape3
{
    internal class Libary
    {
        public List<Book> books = new List<Book>();

        public List<Book>  FindAllBooksbyName(string value)
        {

             return books.FindAll(book => book.Name.Contains(value));
            
        }
        public void RemoveBooksbyName(string value)
        {
             books.RemoveAll(book => book.Name.Contains(value));
            
        }
        public List<Book> SearchBooks(string value)
        {
            return books.FindAll(book => book.Name.Contains(value) ||  book.AuthorName.Contains(value) || book.PageCount.ToString().Contains(value));
        }
        public List<Book> FindAllBooksByPageCountRange(int min ,int max)
        {
            return books.FindAll(book => book.PageCount>=min && book.PageCount<=max);
        }
        public  void RemoveBooksbyCode(string value)
        {
            Book book=books.Find(book => book.Code.Contains(value));
            if (book!=null)
            {
                books.Remove(book);
            }

        }



    }
}
