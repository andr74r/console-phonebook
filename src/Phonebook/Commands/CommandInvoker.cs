using Autofac;
using Phonebook.Consts;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook.Commands
{
    public class CommandInvoker
    {
        private readonly ICommand _addCommand;
        private readonly ICommand _listCommand;
        private readonly ICommand _helpCommand;
        private readonly ICommand _defaultCommand;

        public CommandInvoker(AddCommand addCommand, ListCommand listCommand,
            HelpCommand helpCommand, DefaultCommand defaultCommand)
        {
            _addCommand = addCommand;
            _listCommand = listCommand;
            _helpCommand = helpCommand;
            _defaultCommand = defaultCommand;
        }

        public void Execute(List<string> args)
        {
            if (args?.Count > 0)
            {
                var command = args.First();

                ICommand commandToExecute = null;

                switch(command)
                {
                    case CommandsList.List:
                        commandToExecute = _listCommand;
                        break;
                    case CommandsList.Add:
                        commandToExecute = _addCommand;
                        break;
                    case CommandsList.Help:
                        commandToExecute = _helpCommand;
                        break;
                    default:
                        commandToExecute = _defaultCommand;
                        break;
                }

                commandToExecute?.Execute(args);
            }
        }
    }
}
