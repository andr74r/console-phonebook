using Autofac;
using Phonebook.Commands;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AutofacConfig.ConfigureContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                var obj = scope.Resolve<List<CommandExecInfo>>();
                var commandInvoker = scope.Resolve<CommandInvoker>();

                while (true)
                {
                    System.Console.WriteLine("Enter the command:");
                    var line = System.Console.ReadLine();

                    commandInvoker.Execute(line);
                }
            }
        }
    }
}
