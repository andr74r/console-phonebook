using System;

namespace Phonebook.Commands.Attributes
{
    internal class CommandAttribute : Attribute
    {
        public string Name { get; set; }

        public string Format { get; set; }

        public string Description { get; set; }

        public bool IsDefault { get; set; }
    }
}
