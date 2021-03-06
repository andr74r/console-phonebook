﻿using Autofac;
using Phonebook.BLL;
using Phonebook.Commands;
using Phonebook.Data;

namespace Phonebook.Console
{
    public static class AutofacConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new DataModule());
            builder.RegisterModule(new BllModule());
            builder.RegisterModule(new CommandModule());

            return builder.Build();
        }
    }
}
