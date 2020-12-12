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
        [Key]
        [Column(Order = 0)]
        public int bookId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string toUserName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string fromUserName { get; set; }

        public string reason { get; set; }

        public User toUser { get; set; }
        public User fromUser { get; set; }
        [ForeignKey("bookId")]
        public Book book { get; set; }

    }
}
