using DTO.Customer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class CreateKDCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateKDCustomerRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required"); //NotEmpty boş geçilmeyeceğini ve WithMessage metodu ile mesajı ekliyoruz.
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname is required");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email is required"); //NotEmpty boş geçilmeyeceğini, EmailAdress ve WithMessage metodu ile mesajı ekliyoruz.
        }
    }
}
