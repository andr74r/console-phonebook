using Phonebook.BLL.Validators.PhoneValidator;
using Phonebook.Data.Entities;
using Phonebook.Data.Repositories.PhoneRepository;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook.BLL.Managers.PhoneManager
{
    public class PhoneManager : IPhoneManager
    {
        private readonly IPhoneRepository _phoneRepo;
        private readonly IPhoneValidator _phoneValidator;

        public PhoneManager(
            IPhoneRepository phoneRepo,
            IPhoneValidator phoneValidator)
        {
            _phoneRepo = phoneRepo;
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
            return _phoneRepo
                .GetPhones()
                .OrderBy(x => x.OwnerName)
                .ToList();
        }
    }
}
