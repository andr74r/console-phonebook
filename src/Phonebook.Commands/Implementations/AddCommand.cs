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

        public AddCommand(IPhoneManager phoneManager)
        {
            _phoneManager = phoneManager;
        }

        public string Execute(List<string> args)
        {
            if (IsArgsValid(args))
            {
                var phone = new Phone();
                phone.OwnerName = args[1];
                phone.Number = args[2];
                bool isValid = _phoneManager.AddPhone(phone);

                if (isValid)
                    return "Phone was added.";
                else
                    return "Phone is invalid";
            }
            else
            {
                return "Command 'add' has the following format: 'add {name} {phone}'";
            }
        }

        private bool IsArgsValid(List<string> args)
        {
            return args?.Count == 3;
        }
    }
}
