using AutoMapper;
using DTO.Customer;
using Models.Entities;

namespace Business.Configuration.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateCustomerRequest, Customer>();
            CreateMap<UpdateCustomerRequest, Customer>();
            CreateMap<Customer, SearchCustomerResponse>();
            CreateMap<Customer, SearchCustomerResponse2>();
        }
    }
}
