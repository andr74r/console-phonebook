using Autofac;
using Phonebook.BLL.Managers.PhoneManager;
using Phonebook.BLL.Validators.PhoneValidator;

namespace Phonebook.BLL
{
    public class BllModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PhoneManager>()
                .As<IPhoneManager>();

            builder.RegisterType<PhoneValidator>()
                .As<IPhoneValidator>();
        }
    }
}
