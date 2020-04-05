using System.Collections.Generic;

namespace Phonebook.Commands.Abstract
{
    public interface ICommand
    {
        void Execute(List<string> args);
    }
}
