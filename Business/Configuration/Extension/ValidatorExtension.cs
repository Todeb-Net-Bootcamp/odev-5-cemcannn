using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Business.Configuration.Extension
{
    public static class ValidatorExtension
    {
        public static void ThrowIfException(this FluentValidation.Results.ValidationResult validationResult) //Burada sadece Vaalidate fonksiyonuna özel bir static metod yazılıyor.
        {
            if (validationResult.IsValid) //Eğer validation result true ise direkt döndürüyor.
                return;
            var message = string.Join(",", validationResult.Errors.Select(x => x.ErrorMessage)); //validationResult.Errors sınıfının ErrorMessage'lerini stringe çevirip aralarına virgül koyarak message nesnesine eşitliyoruz.
            throw new ValidationException(message); //ValidationException hatası
        }
    }
}
