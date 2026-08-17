using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_system.Use_cases.CustomAttributes
{
    internal class UserCommands
    {
        [Command("Create")]
        public void CreateUser()
        {
            Console.WriteLine("User created");
        }

        [Command("Delete")]
        public void DeleteUser()
        {
            Console.WriteLine("User deleted");
        }
    }
}
