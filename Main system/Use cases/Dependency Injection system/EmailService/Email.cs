namespace Main_system.Use_cases.Dependency_Injection_system.EmailService
{
    internal class Email : IEmail
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
