using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Phone
    {
        [Key]
        public int ID { get; set; }
        [Required] // имя должно быть объязательно
        public string Mark { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
