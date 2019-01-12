using Phonebook.Entity;
using System.Collections.Generic;

namespace Phonebook.Abstract
{
    public interface IPhoneManager
    {
        bool AddPhone(Phone phone);
        List<Phone> GetPhoneList();
    }
}
