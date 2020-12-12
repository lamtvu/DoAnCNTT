using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSachDienTu.Models;

namespace QLSachDienTu.Controllers
{
    class UserController
    {
        public static object getUsers()
        {
            object users;
            using (EBookContext context = new EBookContext())
            {
                users = context.users.Select(u => new
                {
                    userName = u.userName,
                    office = u.office,
                    mail = u.mail,

                }).ToList();
            }
            return users;
        }
        public static string[] GetNameUsers()
        {
            string[] user;
            using (EBookContext context = new EBookContext())
            {
                user = context.users.Select(u => u.userName).Distinct().ToArray();
            }
            return user;
        }
        public static User getUser(string userName, string password)
        {
            User user;
            using (EBookContext context = new EBookContext())
            {
                user = context.users.Where(u => u.userName == userName && u.password == password).FirstOrDefault();
            }
            return user;
        }
        public static User GetUser(string userName)
        {
            User user;
            using (EBookContext context = new EBookContext())
            {
                user = context.users.Where(u => u.userName == userName).FirstOrDefault();
            }
            return user;
        }
        public static object SearchUser(string userName)
        {
            object users;
            using (EBookContext context = new EBookContext())
            {
                users = context.users.Where(u => u.userName.Contains(userName)).Select(u => new
                {
                    userName = u.userName,
                    office = u.office,
                    mail = u.mail,

                }).ToList();
            }
            return users;
        }
        public static void UpdateUser(User oldUser, User newUser)
        {
            using (EBookContext context = new EBookContext())
            {
                var User = context.users.Find(oldUser.userName);
                User.mail = newUser.mail;
                User.password = newUser.password;
                User.avatar = newUser.avatar;
                context.SaveChanges();
            }
        }
        public static void Add(User user)
        {
            using (EBookContext context = new EBookContext())
            {
                context.users.Add(user);
                context.SaveChanges();
            }
        }
        public static void Delete(User user)
        {
            using (EBookContext context = new EBookContext())
            {
                context.users.Include("ownerBooks").Where(u => u.userName.Equals(user.userName)).FirstOrDefault().ownerBooks.Clear();
                context.books.Where(b => b.posterName == user.userName).ToList()
                    .ForEach(b => context.books.Remove(context.books.Find(b.id)));
                context.mails.Where(m => m.fromUserName == user.userName || m.fromUserName == user.userName).ToList()
                    .ForEach(m => context.mails.Remove(context.mails.Find(m.bookId, m.toUserName, m.fromUserName)));
                context.schedules.Where(s => s.userName == user.userName).ToList().ForEach(s => context.schedules.Remove(context.schedules.Find(s.bookId, s.userName)));
                context.users.Remove(context.users.Find(user.userName));
                context.SaveChanges();
            }
        }
    }
}
