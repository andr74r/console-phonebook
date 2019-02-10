using Phonebook.Attributes;
using Phonebook.Helpers;
using System;
using System.Collections.Generic;

namespace Phonebook.Commands
{
    [Command(Name = "help")]
    public class HelpCommand : ICommand
    {
        public void Execute(List<string> args)
        {
            Console.WriteLine("Available commands:");

            var objs = ReflectionHelper.GetAttributesOfImplementations<ICommand, CommandAttribute>();

            foreach (var obj in objs)
            {
                var attr = obj as CommandAttribute;
                var message = $"'{attr.Name}' {(!string.IsNullOrWhiteSpace(attr.Format) ? $"- format: '{attr.Format}'" : string.Empty)}";
                Console.WriteLine(message);
            }
        }
    }
}
