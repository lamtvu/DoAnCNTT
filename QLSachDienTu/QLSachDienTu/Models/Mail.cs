using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLSachDienTu.Models
{
    [Table("Mail")]
    public class Mail
    {
        public User toUser { get; set; }
        public User fromUser { get; set; }
        public Book book { get; set; }
        public string reason { get; set; }

    }
}
