using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;

namespace QLSachDienTu.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int id { get; set; }
        [StringLength(20)]
        public string posterName { get; set; }
        [StringLength(50)]
        public string bookName { get; set; }
        [StringLength(50)]
        public string author { get; set; }
        [StringLength(30)]
        public string kind { get; set; }
        [StringLength(10)]
        public string fileType { get; set; }
        [StringLength(10)]
        public string privateOrPublic { get; set; }
        public byte[] source { get; set; }

        public User poster { get; set; }
        public virtual ICollection<Mail> mails { get; set; }
        public virtual ICollection<Schedule> bSchedule { get; set; }
    }
}
