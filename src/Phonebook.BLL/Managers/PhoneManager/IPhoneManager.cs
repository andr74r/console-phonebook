using Phonebook.Data.Entities;
using System.Collections.Generic;

namespace Phonebook.BLL.Managers.PhoneManager
{
    public interface IPhoneManager
    {
        bool AddPhone(Phone phone);
        List<Phone> GetPhoneList();
    }
}
