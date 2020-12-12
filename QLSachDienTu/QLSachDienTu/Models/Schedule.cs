using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSachDienTu.Models
{
    public class Schedule
    {
        [Key]
        [Column(Order = 0)]
        public int bookId { get; set; }
        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string userName { get; set; }
        [StringLength(10)]
        public string refuseOrAccept { get; set; }

        public Book book { get; set; }
        public User user { get; set; }
    }
}
