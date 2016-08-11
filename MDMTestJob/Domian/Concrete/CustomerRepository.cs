using System.Collections.Generic;
using MDMTestJob.Domian.Abstract;
using MDMTestJob.Domian.Entity;
using System.Linq;
using System.Data.Entity;

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


        /// <summary>
        /// Delete customer by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer Delete(int id)
        {
            Customer item = context.Customers.Where(cust => cust.CustomerId == id).FirstOrDefault<Customer>();
            if (item != null)
            {
                context.Customers.Remove(item);
                context.SaveChanges();
            }
            return item;
        }


        /// <summary>
        /// Save input customer and save the changes if there is customer.
        /// </summary>
        /// <param name="customer"></param>
        public void Save(Customer customer)
        {
            if (customer.CustomerId == 0)
            {
                this.context.Customers.Add(customer);
            }

            else
            {
                Customer changeableCustobmer = this.context.Customers.Where(
                    cust => cust.CustomerId == customer.CustomerId).FirstOrDefault();

                changeableCustobmer.Name = customer.Name;
                changeableCustobmer.PhoneNum = customer.PhoneNum;
                changeableCustobmer.Address = customer.Address;
               // context.Entry(customer).State = EntityState.Modified;
            }
            

            
            this.context.SaveChanges();

        }

    }
}
