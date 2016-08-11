using MDMTestJob.Domian.Abstract;
using MDMTestJob.Domian.Entity;
using System.Collections.Generic;

namespace MDMTestJob.Domian.Concrete
{
    public class OrderRepository : Singleton<OrderRepository>, IOrderRepository 
    {
        MdmTestJob_dbEntities context;

        public IEnumerable<Order> Orders
        {
            get
            {
                return this.context.Orders;
            }
        }

        private OrderRepository() : base()
        {
            this.context = new MdmTestJob_dbEntities();
        }

        


         

        public Order Delete(int id)
        {
            Order item = context.Orders.Find(id);
            if (item != null)
            {
                context.Orders.Remove(item);
                context.SaveChanges();
            }
            return item;
        }

       

       public void Save(Order order)
        { 

            if (order.CustomerId == 0)
            {

                this.context.Orders.Add(order);
            }

            else
            {
                Order changeableOrder = this.context.Orders.Find(order.CustomerId);

                changeableOrder.Amount = order.Amount;
                changeableOrder.CustomerId = order.CustomerId;
                changeableOrder.Description = order.Description;
                changeableOrder.DueTime = order.DueTime;
                changeableOrder.Number = order.Number;
            }
            this.context.SaveChanges();
        }
 
    }
}
