using System.Reflection;

namespace Main_system.Use_cases.CustomAttributes
{
    internal class Runner
    {
        public void ExecuteCommand(UserCommands userCommands, string method)
        {
            var userCommandType = userCommands.GetType();

            foreach (var item in userCommandType.GetMethods())
            {
                var attribute = item.GetCustomAttribute<Command>();

                if (attribute == null)
                    Console.WriteLine("This method doesn't existe");
                else 
                    if (attribute.Name == method)
                        item?.Invoke(userCommands, null);
            }
        }
    }
}
