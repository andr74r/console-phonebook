using Autofac;
using Phonebook.Abstract;
using Phonebook.Commands;
using Phonebook.Concrete;
using Phonebook.Entity;

namespace Phonebook.Infrastructure
{
    public static class AutofacConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<PhoneRepository>().As<IPhoneRepository>();
            builder.RegisterType<DefaultSorter<Phone>>().As<ISorter<Phone>>();
            builder.RegisterType<PhoneValidator>().As<IPhoneValidator>();
            builder.RegisterType<PhoneManager>().As<IPhoneManager>();
            builder.RegisterType<ConsoleManager>().As<IOutputInputManager>();

            builder.RegisterType<CommandInvoker>().As<CommandInvoker>();
            builder.RegisterType<AddCommand>().As<AddCommand>();
            builder.RegisterType<HelpCommand>().As<HelpCommand>();
            builder.RegisterType<ListCommand>().As<ListCommand>();
            builder.RegisterType<DefaultCommand>().As<DefaultCommand>();

            return builder.Build();
        }

    }
}
