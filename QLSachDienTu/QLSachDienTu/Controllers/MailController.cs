using QLSachDienTu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSachDienTu.Controllers
{
    class MailController
    {
        public static object GetMails(User user)
        {
            object mails;
            using (EBookContext context = new EBookContext())
            {
                mails = context.mails.Include("book").Where(m => m.toUserName == user.userName).Select(m => new
                {
                    to = m.toUserName,
                    from = m.fromUserName,
                    bookId = m.bookId,
                    bookName = m.book.bookName,
                    reason = m.reason
                }).ToList();
            }
            return mails;
        }
        public static void Add(User formUser, User toUser, Book book, Mail mail)
        {
            using (EBookContext context = new EBookContext())
            {
                context.users.Include("mailReceives").Where(u => u.userName.Equals(toUser.userName)).FirstOrDefault().mailReceives.Add(mail);
                context.users.Include("mailSents").Where(u => u.userName.Equals(formUser.userName)).FirstOrDefault().mailSents.Add(mail);
                var e = context.books.Include("mails").Where(b => b.id.Equals(book.id)).FirstOrDefault();
                context.books.Include("mails").Where(b => b.id.Equals(book.id)).FirstOrDefault().mails.Add(mail);

                var r = context.books.Include("mails").Where(b => b.id.Equals(book.id)).FirstOrDefault();
                context.mails.Add(mail);
                context.SaveChanges();
            }
        }
        public static void Delete(string fromUserName, string toUserName, int bookId)
        {
            using (EBookContext context = new EBookContext())
            {
                var x = context.books.Include("mails").Where(b => b.id.Equals(bookId)).FirstOrDefault();
                context.books.Include("mails").Where(b => b.id == bookId).FirstOrDefault().mails.Remove(context.mails.Find(bookId, toUserName, fromUserName));
                context.users.Include("mailReceives").Where(u => u.userName == toUserName).FirstOrDefault().mailReceives.Remove(context.mails.Find(bookId, toUserName, fromUserName));
                //context.users.Include("mailSents").Where(u => u.userName == fromUserName).FirstOrDefault().mailSents.Remove(context.mails.Find(bookId, toUserName, fromUserName));
                context.mails.Remove(context.mails.Find(bookId, toUserName, fromUserName));
                context.SaveChanges();
            }
        }
        public static Mail GetMail(int bookId, string toUserName, string fromUserName)
        {
            Mail mail;
            using (EBookContext context = new EBookContext())
            {
                mail = context.mails.Find(bookId, toUserName, fromUserName);
            }
            return mail;
        }
        public static void DeleteAddMail(User user)
        {
            using (EBookContext context = new EBookContext())
            {
                context.mails.Where(m => m.toUserName == user.userName).ToList().ForEach(m => Delete(m.fromUserName, m.toUserName, m.bookId));
                context.SaveChanges();
            }
        }
    }
}
