using System;
using System.Collections.Generic;
using System.Linq;

namespace YYX.ReflectionSomething
{
    public static class ImplementInterfaceFinder
    {
        public static IEnumerable<T> Find<T>()
        {
            var type = typeof(T);
            var tEnumerable =
                AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(assembly =>
                {
                    var types = assembly.GetTypes();
                    var findTypes = types.Where(derivedClass => derivedClass.GetInterfaces().Contains(type));
                    return findTypes.Select(derivedClass => (T)assembly.CreateInstance(derivedClass.FullName, true));
                });
            return tEnumerable;
        }
    }
}
