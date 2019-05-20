using System;
using System.Collections.Generic;
using System.Linq;

namespace YYX.ReflectionSomething
{
    public static class DerivedClassesFinder
    {
        public static IEnumerable<T> Find<T>()
            where T : class//, new()
        {
            var type = typeof(T);
            var tEnumerable = 
                AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(assembly =>
                {
                    var types = assembly.GetTypes();
                    var derivedClassTypes = types.Where(derivedClass => derivedClass.IsSubclassOf(type));
                    return derivedClassTypes.Select(derivedClass => (T)assembly.CreateInstance(derivedClass.FullName, true));
                });
            return tEnumerable;
        }
    }
}
