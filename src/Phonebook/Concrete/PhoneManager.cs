using System;
using System.Collections.Generic;
using Phonebook.Abstract;
using Phonebook.Entity;

namespace Phonebook.Concrete
{
    public class PhoneManager : IPhoneManager
    {
        private readonly IPhoneRepository _phoneRepo;
        private readonly ISorter<Phone> _phoneSorter;
        private readonly IPhoneValidator _phoneValidator;

        public PhoneManager(IPhoneRepository phoneRepo, ISorter<Phone> phoneSorter,
            IPhoneValidator phoneValidator)
        {
            _phoneRepo = phoneRepo;
            _phoneSorter = phoneSorter;
            _phoneValidator = phoneValidator;
        }

        public bool AddPhone(Phone phone)
        {
            bool isValid = _phoneValidator.Validate(phone);

            if (!isValid)
                return false;

            _phoneRepo.AddPhone(phone);

            return true;
        }

        public List<Phone> GetPhoneList()
        {
            var phones = _phoneRepo.GetPhones();
            return _phoneSorter.Sort(phones);
        }
    }
}
