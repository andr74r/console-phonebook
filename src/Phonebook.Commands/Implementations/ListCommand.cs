using Phonebook.BLL.Managers.PhoneManager;
using Phonebook.Commands.Abstract;
using Phonebook.Commands.Attributes;
using System.Collections.Generic;
using System.Text;

namespace Phonebook.Commands.Implementations
{
    [Command(Name = "list")]
    internal class ListCommand : ICommand
    {
        private readonly IPhoneManager _phoneManager;

        public ListCommand(
            IPhoneManager phoneManager)
        {
            _phoneManager = phoneManager;
        }

        public string Execute(List<string> args)
        {
            var list = _phoneManager.GetPhoneList();

            var stringBuilder = new StringBuilder();
            foreach (var elem in list)
            {
                stringBuilder.AppendLine($"{elem.OwnerName} : {elem.Number}");
            }

            return stringBuilder.ToString();
        }
    }
}
