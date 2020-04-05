using Phonebook.Data.Entities;

namespace Phonebook.BLL.Validators.PhoneValidator
{
    public class PhoneValidator : IPhoneValidator
    {
        public bool Validate(Phone phone)
        {
            return phone != null && !string.IsNullOrWhiteSpace(phone.Number) && !string.IsNullOrWhiteSpace(phone.OwnerName);
        }
    }
}
