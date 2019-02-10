using System.Collections.Generic;
using Phonebook.Entity;
using Phonebook.Abstract;
using Phonebook.Data;

namespace Phonebook.Concrete
{
    public class PhoneRepository : IPhoneRepository
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
