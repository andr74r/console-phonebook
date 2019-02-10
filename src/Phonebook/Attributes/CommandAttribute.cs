using System;

namespace Phonebook.Attributes
{
    public class CommandAttribute : Attribute
    {
        public string Name { get; set; }
        public string Format { get; set; }
        public string Description { get; set; }
    }
}
