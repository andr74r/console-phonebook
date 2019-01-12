using System;
using System.Collections.Generic;

namespace Phonebook.Commands
{
    public class DefaultCommand : ICommand
    {
        public void Execute(List<string> args)
        {
            Console.WriteLine("Unknown command. Enter 'help' to see list of the commands.");
        }
    }
}
