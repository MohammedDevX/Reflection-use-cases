using System.Reflection;

namespace Main_system.Use_cases.Dependency_Injection_system
{
    public class Container
    {
        private static readonly Dictionary<Type, Type> register = new();

        public void AddTransiant<TAbstract, TImplementation>()
        {
            register[typeof(TAbstract)] = typeof(TImplementation);
        }

        public TAbstract Resolve<TAbstract>()
        {
            return (TAbstract)ObjectResolver(typeof(TAbstract));
        }

        private object Resolve(Type ob)
        {
            return ObjectResolver(ob);
        }

        private object ObjectResolver(Type abstractType)
        {
            Type type = register[abstractType];
            ConstructorInfo constructor = type.GetConstructors().OrderByDescending(c => c.GetParameters().Length).First();

            List<object> argsArray = new();

            foreach (var item in constructor.GetParameters())
            {
                var argumentType = item.ParameterType;
                argsArray.Add(Resolve(argumentType));
            }
            return constructor?.Invoke(argsArray.ToArray());
        }
    }
}
