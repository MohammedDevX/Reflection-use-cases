namespace Main_system.Use_cases.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class Command : Attribute
    {
        public string Name { get; set; }

        public Command(string name)
        {
            Name = name;
        }
    }
}
