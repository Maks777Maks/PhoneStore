using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.DTOModels
{
    [DataContract]
    public class OrderDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public UserDTO user { get; set; }
        [DataMember]
        public PhoneDTO phone { get; set; }
        [DataMember]
        public DateTime time { get; set; }
    }
}
