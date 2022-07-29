using DTO.Customer;
using FluentValidation;

namespace Business.Configuration.Validator.FluentValidation
{
    public class UpdateCustomerRequestValidator : AbstractValidator<UpdateCustomerRequest> //Fluent Validation içerisinde bulunan AbstractValidator içerisinden kalıtım alıyor ve CreateCustomerRequest sınıfının validator sınıfıdır.
    {
        public UpdateCustomerRequestValidator() //Constructor oluşturuluyor
        {
            RuleFor(x => x.Id).GreaterThan(0); //Id değeri 0 dan büyük olmalıdır.
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required"); //NotEmpty boş geçilmeyeceğini ve WithMessage metodu ile mesajı ekliyoruz.
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname is required");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is required");
            RuleFor(x => x.Email).EmailAddress().NotEmpty().WithMessage("Email is required"); //NotEmpty boş geçilmeyeceğini, EmailAdress ile email validasyonunu ve WithMessage metodu ile mesajı ekliyoruz.
        }
    } 
}
