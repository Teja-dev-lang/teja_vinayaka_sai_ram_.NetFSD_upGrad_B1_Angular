using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collection_Assignment
{
   public interface IBookRepostory
    {
        public void Add(Books books);
        public void Edit(int Bookid, double price);

        Books Get(int id);
        List<Books> GetAll();
        public void Delete(int id);
    }
    public class BookRespostory : IBookRepostory
    {
        public List<Books> books = null;

        public BookRespostory()
        {
            books = new List<Books>() { new Books() { BookId = 1, Name = "HarryPotter", Price = 4999, Category = "Sci-fi" } };
        }

        public void Add(Books book)
        {
            books.Add(book);
        }

        public void Edit(int Bookid,double price)
        {
            for(int i = 0; i <= books.Count; i++)
            {
                if (books[i].BookId == Bookid)
                {
                    books[i].Price = price;
                }
            }
        }
        public Books Get(int id)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].BookId == id)
                {
                    return books[i];
                }
            }
            return null;
        }
        public List<Books> GetAll()
        {
            return books;
        }

        public void Delete(int id)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].BookId == id)
                {
                    books.RemoveAt(i);
                }
            }
        }

    }
    public class Test_repo
    {
        static void Main()
        {
            try
            {
                BookRespostory _repo = new BookRespostory();
                do
                {
                    Console.WriteLine("1.Add Book");
                    Console.WriteLine("2.View Books");
                    Console.WriteLine("3.View Book By Id");
                    Console.WriteLine("4.Edit Book");
                    Console.WriteLine("5.Delete Book");
                    Console.WriteLine("6.Exist App");
                    Console.WriteLine("Enter Choice"); 
           
                }
                while 
                
            }
            catch
            {

            }
     
        }
       
    }
}
