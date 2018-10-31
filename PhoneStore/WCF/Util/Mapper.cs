using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.DTOModels;

namespace WCF.Util
{
    public static class Mapper
    {
        public static Phone PhoneFromDTO(PhoneDTO phonedto )
        {
            Phone result = new Phone();
            result.Mark = phonedto.Mark;
            result.Model = phonedto.Model;
            result.Price = phonedto.Price;
            return result;
        } 
        public static Order OrderFromDTO(OrderDTO orderdto)
        {
            Order result = new Order();
            result.phone = PhoneFromDTO(orderdto.phone);
            result.user = UserFromDTO(orderdto.user);
            result.time = orderdto.time;
            return result;
        }
        public static User UserFromDTO(UserDTO orderdto)
        {
            User result = new User();
            result.Name = orderdto.Name;
            result.Mail = orderdto.Mail;           
            return result;
        }
    }
}
