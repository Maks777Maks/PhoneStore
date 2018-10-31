using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
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
        public void AddPhone(PhoneDTO phone)
        {
            Repository<Phone> repository = new Repository<Phone>(new DAL.Context());
            Phone p = Mapper.PhoneFromDTO(phone);
            repository.Create(p);
        }

        public void CreateOrder(OrderDTO order)
        {
            Repository<Order> repository = new Repository<Order>(new DAL.Context());
            Order o = Mapper.OrderFromDTO(order);
            repository.Create(o);
        }

        public List<PhoneDTO> GetPhones()
        {
            Repository<Phone> repository = new Repository<Phone>(new DAL.Context());

            List<PhoneDTO> result = new List<PhoneDTO>();

            foreach (var item in repository.GetAll())
            {
                var p = new PhoneDTO { ID = item.ID, Mark = item.Mark, Model = item.Model, Price=item.Price };
                result.Add(p);
            }
            return result;
        }
    }
}
