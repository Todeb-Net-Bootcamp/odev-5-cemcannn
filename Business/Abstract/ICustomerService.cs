using Business.Configuration.Response;
using DTO.Customer;
using Models.Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        public IEnumerable<SearchCustomerResponse> GetAll(); //IEnumerable ile bütün customer'ları çağırabiliriz.
        public IEnumerable<SearchCustomerResponse2> GetAll2(); //IEnumerable ile bütün customer'ları çağırabiliriz.
        public CommandResponse Insert(CreateCustomerRequest request); //Veritabanına yeni bir customer ekleme işlemi.
        public CommandResponse Update(UpdateCustomerRequest request); //Veritabanında customer'ı güncelleme işlemi.
        public CommandResponse Delete(Customer customer); //Veritabanında customer'ı silme işlemi. 
    }
}
