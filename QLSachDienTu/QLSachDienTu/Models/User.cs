using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLSachDienTu.Models
{   
    [Table("User")]
    public class User
    {
        [Key]
        public string username { get; set; }
        public string office { get; set; }
        public string mail { get; set; }
        private string password { get; set; }
        public byte[] avatar { get; set; }

        public ICollection<Mail> mailSent { get; set; }
        public ICollection<Mail> mailReceive { get; set; }

        public ICollection<Schedule> schedule { get; set; }
        public ICollection<Book> bookOwner { get; set; }
    }
}
