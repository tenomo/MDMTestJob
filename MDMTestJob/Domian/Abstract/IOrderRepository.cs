using MDMTestJob.Domian.Entity;
using System.Collections.Generic;

namespace MDMTestJob.Domian.Abstract
{
    interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; } 
        Order Delete(int id);
        void Save(Order order);
    }
}
