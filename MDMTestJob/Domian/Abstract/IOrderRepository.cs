using MDMTestJob.Domian.Entity;
using System.Collections.Generic;

namespace MDMTestJob.Domian.Abstract
{
    interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        void Edit(int id);
        void Delete(int id);
        void Create(Order customer);
    }
}
