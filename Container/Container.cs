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
            Type implementationType = typeRegistry[typeof(T)];
            return (T)Activator.CreateInstance(implementationType);
        }
    }
}
