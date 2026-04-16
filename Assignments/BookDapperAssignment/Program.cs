using System.Data.Common;
using BookDapperAssignment.Models;
using Dapper;
using Microsoft.Data.SqlClient;
namespace BookDapperAssignment
{
    internal class Program
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=BankDB007;Integrated Security=True;Encrypt=False";
        DbConnection db;

        public Program()
        {
            db = new SqlConnection(connectionString);
        }
        private void AddBook(Book book)
        {
            try
            {
                var sql  = "INSERT INTO TABLE Book (BookId,Title,Price,Author,Publisher,Language,PublishDate) VALUES (@BookId,@Title,@Price,@Author,@Publisher,@Language,@PublishDate)";
                db.Open();
                db.Execute(sql, book);
                Console.Write("New Record Successfully Inserted");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void EditBook(Book book)
        {
            try
            {
                var sql = "UPDATE Book SET BookId = @BookId AND Price = @Price WHERE BookId = @BookId";

            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
