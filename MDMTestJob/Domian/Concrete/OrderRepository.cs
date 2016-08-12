using MDMTestJob.Domian.Abstract;
using MDMTestJob.Domian.Entity;
using System.Collections.Generic;
using System;
using System.Linq;

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
            Order item = context.Orders.Where(order =>order.OrderId == id).FirstOrDefault();

            if (item != null)
            {
                context.Orders.Remove(item);
                context.SaveChanges();
            }
            return item;
        }

       

       public void Save(Order order)
        { 

            if (order.OrderId == 0)
            {

                this.context.Orders.Add(order);
            }

            else
            {
                Order changeableOrder = this.context.Orders.Where(ord => ord.OrderId == order.OrderId).First(); ;

                changeableOrder.Amount = order.Amount;
                changeableOrder.CustomerId = order.CustomerId;
                changeableOrder.Description = order.Description;
                changeableOrder.DueTime = order.DueTime;
                changeableOrder.ProcessedTime = order.ProcessedTime;
                changeableOrder.Number = order.Number;
            }
            this.context.SaveChanges();
        }

        public void DeleteByCustomer(int customerID)
        {
            Orders.ToList().RemoveAll(order => order.CustomerId == customerID);
        }
    }
}
