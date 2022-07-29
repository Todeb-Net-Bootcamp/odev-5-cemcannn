using DTO.Customer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest> //Fluent Validation içerisinde bulunan AbstractValidator içerisinden kalıtım alıyor ve CreateCustomerRequest sınıfının validator sınıfıdır.
    {
        public CreateCustomerRequestValidator() //Constructor oluşturuluyor
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required"); //NotEmpty boş geçilmeyeceğini ve WithMessage metodu ile mesajı ekliyoruz.
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname is required");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is required");
            RuleFor(x => x.Email).EmailAddress().NotEmpty().WithMessage("Email is required"); //NotEmpty boş geçilmeyeceğini, EmailAdress ile email validasyonunu ve WithMessage metodu ile mesajı ekliyoruz.
        }
    }
}
