using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WpfApplication4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        List<Entities.Bludo> GetAllBludos();

        [OperationContract]
        List<Entities.BludoInOrder> GetAllBludosInOrder();

        [OperationContract]
        List<Entities.OrderInTime> GetAllOrdersInTime();

        [OperationContract]
        List<Entities.Table> GetAllTables();

        [OperationContract]
        List<Entities.Waiter> GetAllWaiters();
    }
}
