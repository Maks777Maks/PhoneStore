using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.Contracts;
using WCF.DTOModels;
using WCF.Util;

namespace WCF.Services
{
    public class Contract : IContract
    {
        private readonly DbContext context;
        public Contract()
        {
            context = new DAL.Context();
        }


        public void AddUser(UserDTO user)
        {
            Repository<User> repository = new Repository<User>(context);
            User p = Mapper.UserFromDTO(user);
            repository.Create(p);
        }

        public void AddPhone(PhoneDTO phone)
        {
            Repository<Phone> repository = new Repository<Phone>(context);
            Phone p = Mapper.PhoneFromDTO(phone);
            repository.Create(p);
        }

        public void CreateOrder(OrderDTO order)
        {
            Repository<Order> repository = new Repository<Order>(context);
            Order o = Mapper.OrderFromDTO(order);

            Repository<User> userrep = new Repository<User>(context);
            o.user = userrep.GetById(o.user.ID);
            if (o.user == null)
            {
                throw new Exception("User = null");
            }

            Repository<Phone> phonerep = new Repository<Phone>(context);
            o.phone = phonerep.GetById(o.phone.ID);
            if (o.phone == null)
            {
                throw new Exception("o.phone == null");
            }

            repository.Create(o);
        }

        public List<PhoneDTO> GetPhones()
        {
            Repository<Phone> repository = new Repository<Phone>(context);

            List<PhoneDTO> result = new List<PhoneDTO>();

            foreach (var item in repository.GetAll())
            {
                var p = new PhoneDTO { ID = item.ID, Mark = item.Mark, Model = item.Model, Price=item.Price };
                result.Add(p);
            }
            return result;
        }

        public List<UserDTO> GetUsers()
        {
            Repository<User> repository = new Repository<User>(context);
            List<UserDTO> result = new List<UserDTO>();

            foreach (var item in repository.GetAll())
            {
                var p = new UserDTO { ID = item.ID, Name = item.Name, Mail=item.Mail };
                result.Add(p);
            }
            return result;
        }
    }
}
