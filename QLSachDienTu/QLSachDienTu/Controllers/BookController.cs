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
            object books;
            using (EBookContext context = new EBookContext())
            {
                books = context.books.Select(b => new
                {
                    id = b.id,
                    //poster = b.posterName,
                    name = b.bookName,
                    author = b.author,
                    kind = b.kind,
                    //fileType = b.fileType,
                    publicOrPrivate = b.privateOrPublic
                }).ToList();
            }
            return books;
        }
        public static string[] GetBookNames()
        {
            string[] books;
            using (EBookContext context = new EBookContext())
            {
                books = context.books.Select(u => u.bookName).Distinct().ToArray();
            }
            return books;
        }
        public static object SearchNameBooks(string name)
        {
            object books;
            using (EBookContext context = new EBookContext())
            {
                books = context.books.Where(b => b.bookName.Contains(name)).Select(b => new
                {
                    id = b.id,
                    //poster = b.posterName,
                    name = b.bookName,
                    author = b.author,
                    kind = b.kind,
                    //fileType = b.fileType,
                    publicOrPrivate = b.privateOrPublic
                }).ToList();
            }
            return books;
        }
        public static object SearchAuthorBooks(string author)
        {
            object books;
            using (EBookContext context = new EBookContext())
            {
                books = context.books.Where(b => b.author.Contains(author)).Select(b => new
                {
                    id = b.id,
                    //poster = b.posterName,
                    name = b.bookName,
                    author = b.author,
                    kind = b.kind,
                    //fileType = b.fileType,
                    publicOrPrivate = b.privateOrPublic
                }).ToList();
            }
            return books;
        }
        public static object SearchPosterBooks(string username)
        {
            object books;
            using (EBookContext context = new EBookContext())
            {
                books = context.books.Where(b => b.posterName.Contains(username)).Select(b => new
                {
                    id = b.id,
                    //poster = b.posterName,
                    name = b.bookName,
                    author = b.author,
                    kind = b.kind,
                    //fileType = b.fileType,
                    publicOrPrivate = b.privateOrPublic
                }).ToList();
            }
            return books;
        }
        public static object SearchPOPBooks(string POP)
        {
            object books;
            using (EBookContext context = new EBookContext())
            {
                books = context.books.Where(b => b.privateOrPublic.Contains(POP)).Select(b => new
                {
                    id = b.id,
                    //poster = b.posterName,
                    name = b.bookName,
                    author = b.author,
                    kind = b.kind,
                    //fileType = b.fileType,
                    publicOrPrivate = b.privateOrPublic
                }).ToList();
            }
            return books;
        }
        public static object SearchKindBooks(string kind)
        {
            object books;
            using (EBookContext context = new EBookContext())
            {
                books = context.books.Where(b => b.kind.Contains(kind)).Select(b => new
                {
                    id = b.id,
                    //poster = b.posterName,
                    name = b.bookName,
                    author = b.author,
                    kind = b.kind,
                    //fileType = b.fileType,
                    publicOrPrivate = b.privateOrPublic
                }).ToList();
            }
            return books;
        }
        public static Book GetBook(int id)
        {
            Book book;
            using (EBookContext context = new EBookContext())
            {
                book = context.books.Find(id) as Book;
            }
            return book;
        }
        public static object getBooks(string userName)
        {
            object books;
            using (EBookContext context = new EBookContext())
            {
                books = context.books.Where(b => b.posterName == userName).Select(b => new
                {
                    id = b.id,
                    name = b.bookName,
                    author = b.author,
                    kind = b.kind,
                    fileType = b.fileType,
                    publicOrPrivate = b.privateOrPublic
                }).ToList();
            }
            return books;
        }
        public static void AddBook(string userName, Book book)
        {
            using (EBookContext context = new EBookContext())
            {
                context.books.Add(book);
                context.users.Include("ownerBooks").Where(u => u.userName == userName).FirstOrDefault().ownerBooks.Add(book);
                context.SaveChanges();
            }
        }
        public static void updateBook(int id, Book book)
        {
            using (EBookContext context = new EBookContext())
            {
                var Ibook = context.books.Find(id);
                Ibook.bookName = book.bookName;
                Ibook.author = book.author;
                Ibook.kind = book.kind;
                if (book.source != null)
                    Ibook.source = book.source;
                Ibook.fileType = book.fileType;
                Ibook.privateOrPublic = book.privateOrPublic;
                context.SaveChanges();
            }
        }
        public static void deleteBook(string userName, int bookId)
        {
            using (EBookContext context = new EBookContext())
            {
                context.users.Include("ownerBooks").Where(u => u.userName.Equals(userName)).FirstOrDefault().ownerBooks.Remove(
                context.books.Where(b => b.id.Equals(bookId)).FirstOrDefault());
                context.books.Remove(context.books.Where(b => b.id.Equals(bookId)).FirstOrDefault());
                context.SaveChanges();
            }
        }
        public static bool IsOwerBook(int bookId, User user)
        {
            object book;
            using (EBookContext context = new EBookContext())
            {
                book = context.books.Where(b => b.posterName == user.userName).Where(b => b.id == bookId).FirstOrDefault();
            }
            if (book == null)
                return false;
            return true;
        }
    }
}
