using Phonebook.Data.Entities;
using Phonebook.Data.FakeData;
using System.Collections.Generic;

namespace Phonebook.Data.Repositories.PhoneRepository
{
    public class MemoryPhoneRepository : IPhoneRepository
    {
        private static readonly List<Phone> _phones = InitialData.PhoneList;

        public void AddPhone(Phone phone)
        {
            _phones.Add(phone);
        }

        public List<Phone> GetPhones()
        {
            return _phones;
        }
    }
}
