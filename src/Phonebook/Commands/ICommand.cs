using System.Collections.Generic;

namespace Phonebook.Commands
{
    public interface ICommand
    {
        void Execute(List<string> args);
    }
}
