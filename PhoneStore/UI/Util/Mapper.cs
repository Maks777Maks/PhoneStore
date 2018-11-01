using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Classes;
using WCF.DTOModels;

namespace UI.Util
{
    public static class Mapper
    {
        public static PhoneDTO PhoneFromUI(PhoneUI phonedto)
        {
            PhoneDTO result = new PhoneDTO();
            result.Mark = phonedto.Mark;
            result.Model = phonedto.Model;
            result.Price = phonedto.Price;
            return result;
        }


        public static PhoneUI PhoneFromDTO(PhoneDTO phonedto)
        {
            PhoneUI result = new PhoneUI();
            result.Mark = phonedto.Mark;
            result.Model = phonedto.Model;
            result.Price = phonedto.Price;
            return result;
        }


        public static OrderDTO OrderFromUI(OrderUI orderdto)
        {
            OrderDTO result = new OrderDTO();
            result.phone = PhoneFromUI(orderdto.Phone);
            result.user = UserFromUI(orderdto.User);
            result.time = orderdto.dateTime;
            return result;
        }


        public static OrderUI OrderFromDTO(OrderDTO orderdto)
        {
            OrderUI result = new OrderUI();
            result.Phone = PhoneFromDTO(orderdto.phone);
            result.User = UserFromDTO(orderdto.user);
            result.dateTime = orderdto.time;
            return result;
        }

        public static UserDTO UserFromUI(UserUI orderdto)
        {
            UserDTO result = new UserDTO();
            result.Name = orderdto.Name;
            result.Mail = orderdto.Mail;
            return result;
        }


        public static UserUI UserFromDTO(UserDTO orderdto)
        {
            UserUI result = new UserUI();
            result.Name = orderdto.Name;
            result.Mail = orderdto.Mail;
            return result;
        }
    }
}
