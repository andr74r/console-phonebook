using System;
using System.Linq;
using Autofac;
using Phonebook.Commands;
using Phonebook.Infrastructure;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AutofacConfig.ConfigureContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                var commandInvoker = scope.Resolve<CommandInvoker>();

                while (true)
                {
                    Console.Write("Enter the command:");
                    var line = Console.ReadLine();

                    if (line?.Length > 0)
                    {
                        var arguments = line.Split(' ').ToList();

                        commandInvoker.Execute(arguments);
                    }
                }
            }
        }
    }
}
