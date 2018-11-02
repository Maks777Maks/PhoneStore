using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public User user { get; set; }
        [Required]
        public Phone phone { get; set; }
        [Required]
        public DateTime time { get; set; }
    }
}
