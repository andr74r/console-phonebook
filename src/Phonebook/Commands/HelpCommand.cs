using System;
using System.Collections.Generic;

namespace Phonebook.Commands
{
    public class HelpCommand : ICommand
    {
        public void Execute(List<string> args)
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("'add' - format : 'add {name} {phone}'");
            Console.WriteLine("'list'");
        }
    }
}
