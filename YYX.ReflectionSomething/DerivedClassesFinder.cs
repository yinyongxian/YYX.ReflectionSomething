using System;
using System.Collections.Generic;
using System.Linq;

namespace YYX.ReflectionSomething
{
    public static class DerivedClassesFinder
    {
        public static IEnumerable<T> Find<T>()
            where T : class
        {
            var type = typeof(T);
            var tEnumerable =
                AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(assembly =>
                {
                    var types = assembly.GetTypes();
                    var findTypes = types.Where(derivedClass => derivedClass.IsSubclassOf(type) && !derivedClass.IsAbstract);
                    return findTypes.Select(derivedClass => (T)assembly.CreateInstance(derivedClass.FullName, true));
                });
            return tEnumerable;
        }
    }
}
