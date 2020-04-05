using System.Collections.Generic;

namespace Phonebook.Commands.ArgsSplitter
{
    public interface IArgsSplitter
    {
        List<string> Split(string input);
    }
}
