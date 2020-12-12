using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSachDienTu.Models;

namespace QLSachDienTu.Controllers
{
    class BookController
    {
        public static object GetBooks()
        {
            return null;
        }
        public static string[] GetBookNames()
        {
            return null;
                  }
        public static object SearchNameBooks(string name)
        {
            return null;
        }
        public static object SearchAuthorBooks(string author)
        {
            return null;
        }
        public static object SearchPosterBooks(string username)
        {
            return null;
        }
        public static object SearchPOPBooks(string POP)
        {
            return null;
        }
        public static object SearchKindBooks(string kind)
        {
            return null;
        }
        public static Book GetBook(int id)
        {
            return null;
        }
        public static object getBooks(string userName)
        {
            return null;
        }
        public static void AddBook(string userName, Book book)
        {

        }
        public static void updateBook(int id, Book book)
        {

        }
        public static void deleteBook(string userName, int bookId)
        {

        }
        public static bool IsOwerBook(int bookId, User user)
        {
            return true;
        }
    }
}
