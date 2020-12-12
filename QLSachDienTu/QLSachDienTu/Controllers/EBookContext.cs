using QLSachDienTu.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLSachDienTu.Controllers
{


    class EBookContext : DbContext
    {
        public DbSet<Book> books { get; set; }
        public DbSet<Mail> mails { get; set; }
        public DbSet<Schedule> schedules { get; set; }
        public DbSet<User> users { get; set; }
        public EBookContext() : base("name=EBookDBConnectionString")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                        .HasRequired(b => b.poster)
                        .WithMany(u => u.ownerBooks)
                        .HasForeignKey(b => b.posterName)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mail>()
                        .HasRequired(m => m.fromUser)
                        .WithMany(u => u.mailSents)
                        .HasForeignKey(m => m.fromUserName)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mail>()
                        .HasRequired(m => m.toUser)
                        .WithMany(u => u.mailReceives)
                        .HasForeignKey(m => m.toUserName)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mail>()
                        .HasRequired(m => m.book)
                        .WithMany(b => b.mails)
                        .HasForeignKey(m => m.bookId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Schedule>()
                        .HasRequired(s => s.book)
                        .WithMany(b => b.bSchedule)
                        .HasForeignKey(m => m.bookId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Schedule>()
                        .HasRequired(s => s.user)
                        .WithMany(u => u.uSchedules)
                        .HasForeignKey(s => s.userName)
                        .WillCascadeOnDelete(false);
        }
    }
}
