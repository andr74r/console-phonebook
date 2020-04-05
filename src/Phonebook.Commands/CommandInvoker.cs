using Phonebook.Commands.Abstract;
using Phonebook.Commands.ArgsSplitter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook.Commands
{
    public class CommandInvoker
    {
        private readonly IArgsSplitter _argsSplitter;

        private readonly CommandExecInfo _defaultCommand;
        private readonly List<CommandExecInfo> _commandExecInfos;
        private readonly Func<Type, object> _resolve;

        public CommandInvoker(
            IArgsSplitter argsSplitter,
            List<CommandExecInfo> commandExecInfos,
            Func<Type, object> resolve)
        {
            _argsSplitter = argsSplitter;
            _defaultCommand = commandExecInfos.Single(x => x.IsDefault);
            _commandExecInfos = commandExecInfos;
            _resolve = resolve;
        }

        public string Execute(string input)
        {
            var args = _argsSplitter.Split(input);

            if (args?.Count > 0)
            {
                var commandName = args[0];

                var commandExecInfo = _commandExecInfos.FirstOrDefault(x => x.Name == commandName);

                var commandType = commandExecInfo?.CommandType ?? _defaultCommand.CommandType;

                var command = _resolve(commandType) as ICommand;

                return command.Execute(args);
            }

            return null;
        }
    }
}
