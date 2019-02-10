using Phonebook.Attributes;
using Phonebook.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook.Commands
{
    public class CommandInvoker
    {
        private readonly ICommand _defaultCommand;

        public CommandInvoker(DefaultCommand defaultCommand)
        {
            _defaultCommand = defaultCommand;
        }

        public void Execute(List<string> args, Func<Type, object> createInstance)
        {
            if (args?.Count > 0)
            {
                var command = args.First();

                ICommand commandToExecute = null;

                var type = ReflectionHelper.GetImplementationTypeByAttributeProperty<ICommand, CommandAttribute>(nameof(CommandAttribute.Name), command);

                if (type != null)
                {
                    commandToExecute = createInstance(type) as ICommand;
                }
                else
                {
                    commandToExecute = _defaultCommand;
                }

                commandToExecute?.Execute(args);
            }
        }
    }
}
