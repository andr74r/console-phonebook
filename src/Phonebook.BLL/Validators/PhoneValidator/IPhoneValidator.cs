using Phonebook.Data.Entities;

namespace Phonebook.BLL.Validators.PhoneValidator
{
    public interface IPhoneValidator
    {
        bool Validate(Phone phone);
    }
}
