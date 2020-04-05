using Phonebook.Commands.Abstract;

namespace Phonebook.Console.Implementations
{
    internal class SystemNotifier : ISystemNotifier
    {
        public void Notify(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
