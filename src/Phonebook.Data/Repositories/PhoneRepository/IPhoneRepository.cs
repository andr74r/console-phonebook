using System.Collections.Generic;
using Phonebook.Data.Entities;

namespace Phonebook.Data.Repositories.PhoneRepository
{
    public interface IPhoneRepository
    {
        void AddPhone(Phone phone);
        List<Phone> GetPhones();
    }
}
