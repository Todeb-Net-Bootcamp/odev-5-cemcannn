using AutoMapper;
using Business.Abstract;
using Business.Configuration.Extension;
using Business.Configuration.Response;
using Business.Configuration.Validator.FluentValidation;
using DataAccessLayer.Abstract;
using DTO.Customer;
using Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class KahveDunyasiCustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;  //ICustomerRepository sınıfının nesnesini oluşturuyoruz.
        private readonly IMapper _mapper; //IMapper sınıfının nesnesini oluşturuyoruz.

        public KahveDunyasiCustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository; //ICustomerRepository sınıfının nesnesini _customerRepository'a atıyoruz.
            _mapper = mapper; //IMapper sınıfının nesnesini _mapper'a atıyoruz.
        }

        public CommandResponse Delete(Customer customer)
        {
            _repository.Delete(customer);
            return new CommandResponse //CommandResponse sınıfının nesnesini oluşturuyoruz.
            {
                Status = true,
                Message = $"Customer deleted successfully. Id={customer.Id}"
            };
        }

        public IEnumerable<SearchCustomerResponse> GetAll()
        {
            var data = _repository.GetAll(); //_repository sınıfının GetAll() metodunu çağırıyoruz.
            var mappedData = data.Select(x => _mapper.Map<SearchCustomerResponse>(x)).ToList(); //_repository sınıfının GetAll() metodunun dönen değerini _mapper sınıfının Map() metodu ile DTO'ya dönüştürüyoruz ve mappedData'ye atıyoruz.
            return mappedData; //mappedData'yi döndürüyoruz.
        }
        
        public IEnumerable<SearchCustomerResponse2> GetAll2()
        {
            var data = _repository.GetAll(); //_repository sınıfının GetAll() metodunu çağırıyoruz.
            var mappedData = data.Select(x => _mapper.Map<SearchCustomerResponse2>(x)).ToList(); //_repository sınıfının GetAll() metodunun dönen değerini _mapper sınıfının Map() metodu ile DTO'ya dönüştürüyoruz ve mappedData'ye atıyoruz.
            return mappedData; //mappedData'yi döndürüyoruz.
        }
        
        public CommandResponse Insert(CreateCustomerRequest request)
        {
            //validation

            var validation = new CreateKDCustomerRequestValidator(); //CreateCustomerRequestValidation sınıfının nesnesini oluşturuyoruz.
            validation.Validate(request).ThrowIfException(); //CreateCustomerRequestValidation sınıfının Validate() metodunu çağırıyoruz. ThrowIfException metodu da hata oluştuğunda exception fırlatıyor.
            var entity = _mapper.Map<Customer>(request); //CreateCustomerRequest sınıfının nesnesini Customer sınıfına dönüştürüyoruz.
            _repository.Insert(entity); //ICustomerRepository sınıfının Insert() metodu ile yeni oluşturulan entity ekliyoruz.

            return new CommandResponse
            {
                Status = true,
                Message = $"Customer inserted successfully."
            };
        }

        public CommandResponse Update(UpdateCustomerRequest request)
        {
            var validator = new UpdateCustomerRequestValidator(); //UpdateCustomerRequestValidator sınıfının nesnesini oluşturuyoruz.
            validator.Validate(request).ThrowIfException(); //UpdateCustomerRequestValidator sınıfının Validate() metodunu çağırıyoruz. ThrowIfException metodu da hata oluştuğunda exception fırlatıyor.

            var mapped = _mapper.Map<Customer>(request); //UpdateCustomerRequest sınıfının nesnesini Customer sınıfına dönüştürüyoruz.
            _repository.Update(mapped); //Veritabanında customer'ı güncelleme işlemi.

            return new CommandResponse
            {
                Status = true,
                Message = $"Customer updated successfully."
            };
        }
    }
}
