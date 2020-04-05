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
        private readonly ISystemNotifier _systemNotifier;

        public ListCommand(
            IPhoneManager phoneManager,
            ISystemNotifier systemNotifier)
        {
            _phoneManager = phoneManager;
            _systemNotifier = systemNotifier;
        }

        public void Execute(List<string> args)
        {
            var list = _phoneManager.GetPhoneList();

            var stringBuilder = new StringBuilder();
            foreach (var elem in list)
            {
                stringBuilder.AppendLine($"{elem.OwnerName} : {elem.Number}");
            }

            _systemNotifier.Notify(stringBuilder.ToString());
        }
    }
}
