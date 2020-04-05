using Phonebook.Commands.Abstract;
using Phonebook.Commands.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook.Commands
{
    public class CommandInvoker
    {
        private readonly CommandExecInfo _defaultCommand;
        private readonly List<CommandExecInfo> _commandExecInfos;
        private readonly Func<Type, object> _resolve;

        public CommandInvoker(
            List<CommandExecInfo> commandExecInfos,
            Func<Type, object> resolve)
        {
            _defaultCommand = commandExecInfos.Single(x => x.IsDefault);
            _commandExecInfos = commandExecInfos;
            _resolve = resolve;
        }

        public void Execute(List<string> args)
        {
            if (args?.Count > 0)
            {
                var commandName = args[0];

                var commandExecInfo = _commandExecInfos.FirstOrDefault(x => x.Name == commandName);

                var commandType = commandExecInfo?.CommandType ?? _defaultCommand.CommandType;

                var command = _resolve(commandType) as ICommand;

                command.Execute(args);
            }
        }
    }
}
