using System;

namespace Phonebook.Commands
{
    public class CommandExecInfo
    {
        public string Name { get; set; }

        public string Format { get; set; }

        public string Description { get; set; }

        public bool IsDefault { get; set; }

        public Type CommandType { get; set; }
    }
}
