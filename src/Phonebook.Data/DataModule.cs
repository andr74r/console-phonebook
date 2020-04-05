using Autofac;
using Phonebook.Data.Repositories.PhoneRepository;

namespace Phonebook.Data
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MemoryPhoneRepository>()
                .As<IPhoneRepository>();
        }
    }
}
