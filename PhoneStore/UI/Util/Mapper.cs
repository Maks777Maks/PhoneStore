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
        public static PhoneDTO PhoneFromUI(PhoneUI phoneui)
        {
            PhoneDTO result = new PhoneDTO();
            result.Mark = phoneui.Mark;
            result.Model = phoneui.Model;
            result.Price = phoneui.Price;
            result.ID = phoneui.ID;
            return result;
        }


        public static PhoneUI PhoneFromDTO(PhoneDTO phonedto)
        {
            PhoneUI result = new PhoneUI();
            result.Mark = phonedto.Mark;
            result.Model = phonedto.Model;
            result.Price = phonedto.Price;
            result.ID = phonedto.ID;
            return result;
        }


        public static OrderDTO OrderFromUI(OrderUI orderui)
        {
            OrderDTO result = new OrderDTO();
            result.phone = PhoneFromUI(orderui.Phone);
            result.user = UserFromUI(orderui.User);
            result.time = orderui.dateTime;
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

        public static UserDTO UserFromUI(UserUI userui)
        {
            UserDTO result = new UserDTO();
            result.Name = userui.Name;
            result.Mail = userui.Mail;
            result.ID = userui.ID;
            return result;
        }


        public static UserUI UserFromDTO(UserDTO userdto)
        {
            UserUI result = new UserUI();
            result.Name = userdto.Name;
            result.Mail = userdto.Mail;
            result.ID = userdto.ID;
            return result;
        }
        
    }
}
