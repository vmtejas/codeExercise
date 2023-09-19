using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private Dictionary<Type, Type> typeRegistry = new();

        public void Bind(Type interfaceType, Type implementationType)
        {
            typeRegistry[interfaceType] = implementationType;
        }

        public T Get<T>()
        {
            try
            {
                Type implementationType = typeRegistry[typeof(T)];
                return (T)Activator.CreateInstance(implementationType);
            }
            catch (KeyNotFoundException)
            {
                throw new Exception($"No binding registered for type {typeof(T).FullName}");
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while resolving the type", ex);
            }
        }
    }
}
