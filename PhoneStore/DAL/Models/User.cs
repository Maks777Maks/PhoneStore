using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required] 
        public string Name { get; set; }
        [Required]
        public string Mail { get; set; }

        public List<Order> orders { get; set; }
    }
}
