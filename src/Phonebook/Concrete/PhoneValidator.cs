using Phonebook.Abstract;
using Phonebook.Entity;

namespace Phonebook.Concrete
{
    public class PhoneValidator : IPhoneValidator
    {
        public bool Validate(Phone phone)
        {
            return phone != null && !string.IsNullOrWhiteSpace(phone.Number) && !string.IsNullOrWhiteSpace(phone.OwnerName);
        }
    }
}
