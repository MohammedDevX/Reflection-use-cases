using System.Reflection;

namespace Main_system.Use_cases.Plugins_System
{
    public class Runner
    {
        public static void Run()
        {
            var assemblyExtension = Assembly.GetExecutingAssembly();
            var extnesionsLocation = Path.Combine(Path.Combine(Path.GetDirectoryName(assemblyExtension.Location)), "Extensions");

            foreach (var file in Directory.GetFiles(extnesionsLocation, "*.dll")) // Get only .dll files
            {
                var extensionAssembly = Assembly.LoadFrom(file);
                var extensiontype = extensionAssembly.GetType("Extrernal_plugin" + ".Entrypoint");
                var extensionMethod = extensiontype.GetMethod("Execute");

                extensionMethod?.Invoke(null, null);
            }
        }
    }
}
