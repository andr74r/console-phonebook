using Autofac;
using Phonebook.BLL;
using Phonebook.Commands;
using Phonebook.Data;

namespace Phonebook.WebApi
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new DataModule());
            builder.RegisterModule(new BllModule());
            builder.RegisterModule(new CommandModule());
        }
    }
}
