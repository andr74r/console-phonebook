using Phonebook.Abstract;
using Phonebook.Entity;
using System;
using System.Collections.Generic;

namespace Phonebook.Commands
{
    public class AddCommand : ICommand
    {
        private readonly IPhoneManager _phoneManager;

        public AddCommand(IPhoneManager phoneManager)
        {
            _phoneManager = phoneManager;
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
                    Console.WriteLine("Phone was added.");
                else
                    Console.WriteLine("Phone is invalid");
            }
            else
            {
                Console.WriteLine("Command 'add' has the following format: 'add {name} {phone}'");
            }
        }

        private bool IsArgsValid(List<string> args)
        {
            return args?.Count == 3;
        }
    }
}
