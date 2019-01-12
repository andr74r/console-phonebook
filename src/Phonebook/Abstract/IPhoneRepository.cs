using System.Collections.Generic;
using Phonebook.Entity;

namespace Phonebook.Abstract
{
    public interface IPhoneRepository
    {
        void AddPhone(Phone phone);
        List<Phone> GetPhones();
    }
}
