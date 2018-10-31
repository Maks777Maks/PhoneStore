using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.DTOModels
{
    [DataContract]
    public class UserDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public List<OrderDTO> orders { get; set; }
    }
}
