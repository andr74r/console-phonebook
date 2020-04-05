using Phonebook.BLL.Managers.PhoneManager;
using Phonebook.Commands.Abstract;
using Phonebook.Commands.Attributes;
using Phonebook.Data.Entities;
using System.Collections.Generic;

namespace Phonebook.Commands.Implementations
{
    [Command(Name = "add", Format = "add {name} {phone}")]
    internal class AddCommand : ICommand
    {
        private readonly IPhoneManager _phoneManager;
        private readonly ISystemNotifier _systemNotifier;

        public AddCommand(IPhoneManager phoneManager,
            ISystemNotifier systemNotifier)
        {
            _phoneManager = phoneManager;
            _systemNotifier = systemNotifier;
        }

        public void Execute(List<string> args)
        {
            if (IsArgsValid(args))
            {
                var phone = new Phone();
                phone.OwnerName = args[1];
                phone.Number = args[2];
                bool isValid = _phoneManager.AddPhone(phone);

                if (isValid)
                    _systemNotifier.Notify("Phone was added.");
                else
                    _systemNotifier.Notify("Phone is invalid");
            }
            else
            {
                _systemNotifier.Notify("Command 'add' has the following format: 'add {name} {phone}'");
            }
        }

        private bool IsArgsValid(List<string> args)
        {
            return args?.Count == 3;
        }
    }
}
