using Phonebook.Abstract;
using Phonebook.Attributes;
using Phonebook.Helpers;
using System;
using System.Collections.Generic;

namespace Phonebook.Commands
{
    [Command(Name = "help")]
    public class HelpCommand : ICommand
    {
        private readonly IOutputInputManager _ioManager;

        public HelpCommand(IOutputInputManager ioManager)
        {
            _ioManager = ioManager;
        }

        public void Execute(List<string> args)
        {
            _ioManager.WriteMessage("Available commands:");

            var objs = ReflectionHelper.GetAttributesOfImplementations<ICommand, CommandAttribute>();

            foreach (var obj in objs)
            {
                var attr = obj as CommandAttribute;
                var message = $"'{attr.Name}' {(!string.IsNullOrWhiteSpace(attr.Format) ? $"- format: '{attr.Format}'" : string.Empty)}";
                _ioManager.WriteMessage(message);
            }
        }
    }
}
