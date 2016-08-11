using MDMTestJob.Domian.Entity;
using System.Collections.Generic;

namespace MDMTestJob.Domian.Abstract
{
    interface ICustomerRepository
    {

        IEnumerable<Customer> Customers { get; } 
        Customer Delete(int id);
        void Save(Customer customer);
    }
}
