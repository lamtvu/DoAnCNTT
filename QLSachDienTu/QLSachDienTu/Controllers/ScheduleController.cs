using QLSachDienTu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSachDienTu.Controllers
{
    class ScheduleController
    {
        public static object GetSchedules(User user)
        {
            object schedules;
            using (EBookContext context = new EBookContext())
            {
                schedules = context.schedules.Include("book").Where(s => s.userName == user.userName).Select(s => new
                {
                    bookName = s.book.bookName,
                    bookId = s.bookId,
                    refuseOrAccept = s.refuseOrAccept
                }).ToList();
            }
            return schedules;
        }
        public static object GetSchedule(User user, int bookId)
        {
            object schedule;
            using (EBookContext context = new EBookContext())
            {
                schedule = context.schedules.Find(bookId, user.userName);
            }
            return schedule;
        }
        public static void AddSchedule(Mail mail, Schedule schedule)
        {
            using (EBookContext context = new EBookContext())
            {
                context.books.Include("bSchedule").Where(b => b.id == mail.bookId).FirstOrDefault().bSchedule.Add(schedule);
                context.users.Include("uSchedules").Where(u => u.userName == mail.fromUserName).FirstOrDefault().uSchedules.Add(schedule);
                context.schedules.Add(schedule);
                context.SaveChanges();
            }
        }
        public static void AddAllSAcceptSchedule(User toUser)
        {
            using (EBookContext context = new EBookContext())
            {
                context.mails.Where(m => m.toUserName == toUser.userName).ToList().ForEach(m => AddSchedule(m, new Schedule { refuseOrAccept = "Accept" }));
                context.SaveChanges();
            }
        }
        public static void AddAllRefuseSchedule(User toUser)
        {
            using (EBookContext context = new EBookContext())
            {
                context.mails.Where(m => m.toUserName == toUser.userName).ToList().ForEach(m => AddSchedule(m, new Schedule { refuseOrAccept = "Refuse" }));
                context.SaveChanges();
            }
        }
        public static void Delete(Schedule schedule)
        {
            using (EBookContext context = new EBookContext())
            {
                context.schedules.Remove(context.schedules.Find(schedule.bookId, schedule.userName));
                context.SaveChanges();
            }
        }
        public static void DeleteAll(User user)
        {
            using (EBookContext context = new EBookContext())
            {
                context.schedules.Where(s => s.userName == user.userName).ToList().ForEach(s => Delete(s));
                context.SaveChanges();
            }
        }
    }
}
