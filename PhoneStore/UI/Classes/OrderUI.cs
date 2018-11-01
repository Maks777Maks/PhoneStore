using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Classes
{
    public class OrderUI
    {
        public int ID { get; set; }
        public UserUI User { get; set; }
        public PhoneUI Phone { get; set; }
        public DateTime dateTime { get; set; }

    }
}
