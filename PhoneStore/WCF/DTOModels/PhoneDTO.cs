using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.DTOModels
{
    [DataContract]
    public class PhoneDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Mark { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public int Price { get; set; }
    }
}
