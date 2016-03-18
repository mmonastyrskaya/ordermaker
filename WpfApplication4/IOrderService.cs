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
        List<Bludo> GetAllBludos();

        [OperationContract]
        List<BludoInOrder> GetAllBludosInOrder();

        [OperationContract]
        List<OrderInTime> GetAllOrdersInTime();

        [OperationContract]
        List<Table> GetAllTables();

        [OperationContract]
        List<Waiter> GetAllWaiters();
    }
}
