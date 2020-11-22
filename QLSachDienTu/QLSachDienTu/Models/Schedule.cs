using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSachDienTu.Models
{
    public class Schedule
    {
        public Book book { get; set; }
        public User user { get; set; }
        public string refuseOrAccept { get; set; }
    }
}
