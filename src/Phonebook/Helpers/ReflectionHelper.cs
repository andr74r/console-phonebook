using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Helpers
{
    public static class ReflectionHelper
    {
        public static List<Type> GetImplementationTypes<IType>()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => typeof(IType).IsAssignableFrom(p))
                    .ToList();
        }

        public static Type GetImplementationTypeByAttributeProperty<IType, AttributeType>(string propertyName, object propertyValue)
        {
            var impls = GetImplementationTypes<IType>();

            if (impls.Any())
            {
                foreach(var impl in impls)
                {
                    var attribute = GetImplementationAttribute<AttributeType>(impl);
                    if (attribute != null)
                    {
                        var value = attribute.GetType().GetProperty(propertyName).GetValue(attribute);
                        if (value.Equals(propertyValue))
                        {
                            return impl;
                        }
                    }
                }
            }

            return null;
        }

        public static List<object> GetAttributesOfImplementations<IType, AttributeType>()
        {
            var attributes = new List<object>();
            var impls = GetImplementationTypes<IType>();

            if (impls.Any())
            {
                foreach (var impl in impls)
                {
                    var attribute = GetImplementationAttribute<AttributeType>(impl);
                    if (attribute != null)
                    {
                        attributes.Add(attribute);
                    }
                }
            }

            return attributes;
        }

        private static object GetImplementationAttribute<AttributeType>(Type impl)
        {
            return impl.GetCustomAttributes(false).FirstOrDefault(a => a is AttributeType);
        }
    }
}
