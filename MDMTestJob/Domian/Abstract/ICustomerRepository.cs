using MDMTestJob.Domian.Entity;
using System.Collections.Generic;

namespace MDMTestJob.Domian.Abstract
{
    interface ICustomerRepository
    {

        IEnumerable<Customer> Customers { get; }
        void Edit(int id);
        void Delete(int id);
        void Create(Customer customer);
    }
}
