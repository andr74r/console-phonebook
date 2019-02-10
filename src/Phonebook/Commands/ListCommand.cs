using Phonebook.Abstract;
using Phonebook.Attributes;
using System;
using System.Collections.Generic;

namespace Phonebook.Commands
{
    [Command(Name = "list")]
    public class ListCommand : ICommand
    {
        private readonly IPhoneManager _phoneManager;

        public ListCommand(IPhoneManager phoneManager)
        {
            _phoneManager = phoneManager;
        }

        public void Execute(List<string> args)
        {
            var list = _phoneManager.GetPhoneList();
            foreach (var elem in list)
            {
                Console.WriteLine($"{elem.OwnerName} : {elem.Number};");
            }
        }
    }
}
