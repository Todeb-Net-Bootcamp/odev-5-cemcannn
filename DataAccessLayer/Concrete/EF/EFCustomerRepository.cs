using DataAccessLayer.Abstract;
using DataAccessLayer.DbContexts;
using Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Concrete.EF
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private TodebCampDbContext context;
        public EFCustomerRepository(TodebCampDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Insert(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }
        public void Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
    }
}
