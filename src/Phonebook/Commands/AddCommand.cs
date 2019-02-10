using Phonebook.Abstract;
using Phonebook.Attributes;
using Phonebook.Entity;
using System;
using System.Collections.Generic;

namespace Phonebook.Commands
{
    [Command(Name = "add", Format = "add {name} {phone}")]
    public class AddCommand : ICommand
    {
        private readonly IPhoneManager _phoneManager;
        private readonly IOutputInputManager _ioManager;

        public AddCommand(IPhoneManager phoneManager,
            IOutputInputManager ioManager)
        {
            _phoneManager = phoneManager;
            _ioManager = ioManager;
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
                    _ioManager.WriteMessage("Phone was added.");
                else
                    _ioManager.WriteMessage("Phone is invalid");
            }
            else
            {
                _ioManager.WriteMessage("Command 'add' has the following format: 'add {name} {phone}'");
            }
        }

        private bool IsArgsValid(List<string> args)
        {
            return args?.Count == 3;
        }
    }
}
