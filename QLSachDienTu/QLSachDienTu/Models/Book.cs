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
        [MaxLength(7)]
        public string bookID { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
        public string kind { get; set; }
       
        public string filType { get; set; }
        public string privateOrPublic { get; set; }
        public byte[] source { get; set; }
        public User poster { get; set; }
        public ICollection<Mail> bookinMail { get; set; }
 


    }
}
