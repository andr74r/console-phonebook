using System.Collections.Generic;
using System.Linq;

namespace Phonebook.Commands.ArgsSplitter
{
    internal class DefaultArgsSplitter : IArgsSplitter
    {
        public List<string> Split(string input)
        {
            if (input?.Length > 0)
            {
                return input.Split(' ').ToList();
            }

            return null;
        }
    }
}
