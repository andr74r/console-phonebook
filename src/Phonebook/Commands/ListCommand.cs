using Phonebook.Abstract;
using System;
using System.Collections.Generic;

namespace Phonebook.Commands
{
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
