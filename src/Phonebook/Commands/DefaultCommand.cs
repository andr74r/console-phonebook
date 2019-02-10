using Phonebook.Abstract;
using System;
using System.Collections.Generic;

namespace Phonebook.Commands
{
    public class DefaultCommand : ICommand
    {
        private readonly IOutputInputManager _ioManager;

        public DefaultCommand(IOutputInputManager ioManager)
        {
            _ioManager = ioManager;
        }

        public void Execute(List<string> args)
        {
            _ioManager.WriteMessage("Unknown command. Enter 'help' to see list of the commands.");
        }
    }
}
