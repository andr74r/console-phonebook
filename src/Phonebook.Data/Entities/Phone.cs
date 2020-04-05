using System;

namespace Phonebook.Data.Entities
{
    public class Phone : IComparable
    {
        public string Number { get; set; }
        public string OwnerName { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is Phone))
                throw new ArgumentException();
            return this.OwnerName.CompareTo(((Phone)obj).OwnerName);
        }
    }
}
