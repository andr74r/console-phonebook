namespace Phonebook.Abstract
{
    public interface IOutputInputManager
    {
        void WriteMessage(string message, bool newLine = true);
        string ReadLine();
    }
}
