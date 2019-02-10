using Phonebook.Abstract;
using System;

namespace Phonebook.Concrete
{
    public class ConsoleManager : IOutputInputManager
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteMessage(string message, bool newLine = true)
        {
            if (newLine)
                Console.WriteLine(message);
            else
                Console.Write(message);
        }
    }
}
