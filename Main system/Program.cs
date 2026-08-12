using Main_system.Use_cases.Dynamic_mapping;

Product p1 = new Product
{
    Id = 1,
    Name = "Omo",
    Price = 120
};

Product p2 = new Product
{
    Id = 2,
    Name = "Bic",
    Price = 4
};

Mapper.Mappe(p1, p2);

Mapper.ToString(p2);

User user = new User
{
    Id = 1,
    Name = "Mohammed",
    Age = 22
};

Mapper.Mappe(p2, user);

Mapper.ToString(user);