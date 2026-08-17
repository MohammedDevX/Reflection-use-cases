//using Main_system.Use_cases.Dynamic_mapping;
//using Main_system.Use_cases.Plugins_System;

//Product p1 = new Product
//{
//    Id = 1,
//    Name = "Omo",
//    Price = 120
//};

//Product p2 = new Product
//{
//    Id = 2,
//    Name = "Bic",
//    Price = 4
//};

//Mapper.Mappe(p1, p2);

//Mapper.ToString(p2);

//User user = new User
//{
//    Id = 1,
//    Name = "Mohammed",
//    Age = 22
//};

//Mapper.Mappe(p2, user);

//Mapper.ToString(user);

//Console.WriteLine("---------------------------");

//var res = Mapper.Map<Product>(user);
//Mapper.ToString(res);

//Runner.Run();



// DI test : 

using Main_system.Use_cases.Dependency_Injection_system;
using Main_system.Use_cases.Dependency_Injection_system.EmailService;
using Main_system.Use_cases.Dependency_Injection_system.User;
using Main_system.Use_cases.Dependency_Injection_system.UserService;

Container container = new();

container.AddTransiant<IUser, User>();
container.AddTransiant<IEmail, Email>();

var user = container.Resolve<IUser>();

user.CreateUser();