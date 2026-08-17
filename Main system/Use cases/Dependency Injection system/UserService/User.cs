using Main_system.Use_cases.Dependency_Injection_system.EmailService;
using Main_system.Use_cases.Dependency_Injection_system.User;

namespace Main_system.Use_cases.Dependency_Injection_system.UserService
{
    public class User(IEmail emailService) : IUser
    {
        public void CreateUser()
        {
            emailService.Send("User created");
        }
    }
}
