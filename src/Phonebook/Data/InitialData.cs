using Phonebook.Entity;
using System.Collections.Generic;

namespace Phonebook.Data
{
    public static class InitialData
    {
        public static List<Phone> PhoneList = new List<Phone>()
        {
            new Phone()
            {
                OwnerName = "Microsoft",
                Number = "(866) 857-9850"
            },
            new Phone()
            {
                OwnerName = "Google",
                Number = "1-877-355-5787"
            },
            new Phone()
            {
                OwnerName = "Apple",
                Number = "1-877-355-5787"
            }
        };
    }
}
