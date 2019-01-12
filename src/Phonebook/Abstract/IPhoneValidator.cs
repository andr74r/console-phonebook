using Phonebook.Entity;

namespace Phonebook.Abstract
{
    public interface IPhoneValidator
    {
        bool Validate(Phone phone);
    }
}
