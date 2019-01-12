using System;
using System.Collections.Generic;

namespace Phonebook.Abstract
{
    /// <summary>
    /// Sorts list of objects
    /// </summary>
    /// <typeparam name="T">The item. Must be Comparable.</typeparam>
    public interface ISorter<T>
        where T : IComparable
    {
        List<T> Sort(IEnumerable<T> list);
    }
}
