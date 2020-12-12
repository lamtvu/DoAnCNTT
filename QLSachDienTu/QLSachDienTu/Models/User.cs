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
        [StringLength(20)]
        public string userName { get; set; }
        [StringLength(20)]
        public string office { get; set; }
        [StringLength(50)]
        public string mail { get; set; }
        [StringLength(20)]
        public string password { get; set; }
        public byte[] avatar { get; set; }

        public virtual ICollection<Mail> mailSents { get; set; }
        public virtual ICollection<Mail> mailReceives { get; set; }
        public virtual ICollection<Schedule> uSchedules { get; set; }
        public virtual ICollection<Book> ownerBooks { get; set; }
    }
}
