using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Classes
{
   public class UserUI
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public List<OrderUI> orders { get; set; }
    }
}
