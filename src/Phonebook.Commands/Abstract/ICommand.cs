using System.Collections.Generic;

namespace Phonebook.Commands.Abstract
{
    public interface ICommand
    {
        string Execute(List<string> args);
    }
}
