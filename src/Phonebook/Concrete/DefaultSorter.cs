using System;
using System.Collections.Generic;
using System.Linq;
using Phonebook.Abstract;

namespace Phonebook.Concrete
{
    public class DefaultSorter<T> : ISorter<T>
        where T : IComparable
    {
        public List<T> Sort(IEnumerable<T> list)
        {
            return list.OrderBy(x => x).ToList();
        }
    }
}
