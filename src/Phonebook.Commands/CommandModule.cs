using Autofac;
using Phonebook.Commands.Abstract;
using Phonebook.Commands.ArgsSplitter;
using Phonebook.Commands.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook.Commands
{
    public class CommandModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CommandInvoker>();

            builder.RegisterType<DefaultArgsSplitter>()
                .As<IArgsSplitter>();

            builder.Register<Func<Type, object>>((x) =>
            {
                var context = x.Resolve<IComponentContext>();
                return (type) => context.Resolve(type);
            });

            RegisterCommands(builder);
        }

        private void RegisterCommands(ContainerBuilder builder)
        {
            var commandExecInfos = new List<CommandExecInfo>();

            var types = typeof(CommandModule)
                .Assembly
                .GetTypes()
                .Where(p => typeof(ICommand).IsAssignableFrom(p) && !p.IsAbstract);

            foreach (var type in types)
            {
                builder.RegisterType(type).SingleInstance();

                commandExecInfos.Add(GetCommandExecInfo(type));
            }

            builder.Register((context) => commandExecInfos);
        }

        private CommandExecInfo GetCommandExecInfo(Type type)
        {
            var attr = type
                .GetCustomAttributes(true)
                .Single(x => x.GetType() == typeof(CommandAttribute)) as CommandAttribute;

            return new CommandExecInfo
            {
                Name = attr.Name,
                Format = attr.Format,
                Description = attr.Description,
                IsDefault = attr.IsDefault,
                CommandType = type
            };
        }
    }
}
