using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAll(); //IEnumerable ile bütün customer'ları çağırabiliriz.
        public void Insert(Customer customer); //Veritabanına yeni bir customer ekleme işlemi.
        public void Update(Customer customer); //Veritabanında customer'ı güncelleme işlemi.
        public void Delete(Customer customer); //Veritabanında customer'ı silme işlemi. 
    }
}
