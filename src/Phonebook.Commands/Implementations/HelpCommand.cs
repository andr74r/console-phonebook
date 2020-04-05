using Phonebook.Commands.Abstract;
using Phonebook.Commands.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phonebook.Commands.Implementations
{
    [Command(Name = "help")]
    internal class HelpCommand : ICommand
    {
        private readonly List<CommandExecInfo> _commandExecInfos;

        public HelpCommand(List<CommandExecInfo> commandExecInfos)
        {
            _commandExecInfos = commandExecInfos;
        }

        public string Execute(List<string> args)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Available commands:");

            foreach (var info in _commandExecInfos.Where(x => !x.IsDefault))
            {
                stringBuilder.AppendLine($"'{info.Name}' {(!string.IsNullOrWhiteSpace(info.Format) ? $"- format: '{info.Format}'" : string.Empty)}");
            }

            return stringBuilder.ToString();
        }
    }
}
