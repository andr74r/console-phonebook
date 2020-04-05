using Phonebook.Commands.Abstract;
using Phonebook.Commands.Attributes;
using System.Collections.Generic;

namespace Phonebook.Commands.Implementations
{
    [Command(Name = "default", IsDefault = true)]
    internal class DefaultCommand : ICommand
    {
        public string Execute(List<string> args)
        {
           return "Unknown command. Enter 'help' to see list of the commands.";
        }
    }
}
