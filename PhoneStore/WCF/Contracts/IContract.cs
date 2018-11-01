using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.DTOModels;

namespace WCF.Contracts
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        List<PhoneDTO> GetPhones();

        [OperationContract]
        void AddPhone(PhoneDTO phone);

        [OperationContract]
        void CreateOrder(OrderDTO order);

        [OperationContract]
        void AddUser(UserDTO user);
    }
}
