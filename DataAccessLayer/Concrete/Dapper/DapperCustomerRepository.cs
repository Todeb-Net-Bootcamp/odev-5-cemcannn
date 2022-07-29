using DataAccessLayer.Abstract;
using Models.Entities;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Concrete.Dapper
{
    public class DapperCustomerRepository : ICustomerRepository
    {
        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
