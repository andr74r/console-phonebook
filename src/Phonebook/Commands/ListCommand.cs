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
        private readonly IOutputInputManager _ioManager;

        public ListCommand(IPhoneManager phoneManager,
            IOutputInputManager ioManager)
        {
            _phoneManager = phoneManager;
            _ioManager = ioManager;
        }

        public void Execute(List<string> args)
        {
            var list = _phoneManager.GetPhoneList();
            foreach (var elem in list)
            {
                _ioManager.WriteMessage($"{elem.OwnerName} : {elem.Number};");
            }
        }
    }
}
