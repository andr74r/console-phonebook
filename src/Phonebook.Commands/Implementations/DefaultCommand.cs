using Phonebook.Commands.Abstract;
using Phonebook.Commands.Attributes;
using System.Collections.Generic;

namespace Phonebook.Commands.Implementations
{
    [Command(Name = "default", IsDefault = true)]
    internal class DefaultCommand : ICommand
    {
        private readonly ISystemNotifier _systemNotifier;

        public DefaultCommand(ISystemNotifier systemNotifier)
        {
            _systemNotifier = systemNotifier;
        }

        public void Execute(List<string> args)
        {
            _systemNotifier.Notify("Unknown command. Enter 'help' to see list of the commands.");
        }
    }
}
