using System;
using System.Collections.Generic;
using MDMTestJob.Domian.Abstract;
using MDMTestJob.Domian.Entity;

namespace MDMTestJob.Domian.Concrete
{
   public class CustomerRepository : AbstractRepository,  ICustomerRepository
    {
        MdmTestJob_dbEntities context;

        public IEnumerable<Customer> Customers
        {
            get
            {
                return this.context.Customers;
            }
        }

        public CustomerRepository()
        {
            this.context = new MdmTestJob_dbEntities();
        }




        public void Create(Customer other)
        {
            this.Save(other);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Customer other)
        {
            this.Save(other);
        }


        protected override void Save(object other)
        {
            Customer customer = other as Customer;
            
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
