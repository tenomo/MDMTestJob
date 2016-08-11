using System.Collections.Generic;
using MDMTestJob.Domian.Abstract;
using MDMTestJob.Domian.Entity;

namespace MDMTestJob.Domian.Concrete
{
    public class CustomerRepository : Singleton<CustomerRepository>, ICustomerRepository
    {

        MdmTestJob_dbEntities context;
        public IEnumerable<Customer> Customers
        {
            get
            {
                return this.context.Customers;
            }
        }

        private CustomerRepository() : base()
        {
            this.context = new MdmTestJob_dbEntities();
        }






        public Customer Delete(int id)
        {
            Customer item = context.Customers.Find(id);
            if (item != null)
            {
                context.Customers.Remove(item);
                context.SaveChanges();
            }
            return item;
        }



        public void Save(Customer customer)
        {

            if (customer.CustomerId == 0)
            {

                this.context.Customers.Add(customer);
            }

            else
            {
                Customer changeableCustobmer = this.context.Customers.Find(customer.CustomerId);

                changeableCustobmer.Name = customer.Name;
                changeableCustobmer.PhoneNum = customer.PhoneNum;
                changeableCustobmer.Address = customer.Address;
            }
            this.context.SaveChanges();
        }




    }
}
