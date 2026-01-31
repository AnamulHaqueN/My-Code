using System;

class UserService
{
    public static void CreateUser()
    {

        User u = new User();
        u.Id = IdGenerator.Generate();

        Console.Write("Name: ");
        u.Name = Console.ReadLine() ?? "";
        if (Validator.IsEmpty(u.Name))
        {
            Console.WriteLine("Name cannot be empty\n");
            return;
        }

        Console.Write("Mobile: ");
        u.Mobile = Console.ReadLine() ?? "";
        if (!Validator.IsValidPhone(u.Mobile))
        {
            Console.WriteLine("Invalid phone number\n");
            return;
        }

        if (DataStore.Users.Exists(x => x.Mobile == u.Mobile))
        {
            Console.WriteLine("Phone already exists\n");
            return;
        }

        Console.Write("Email: ");
        u.Email = Console.ReadLine() ?? "";
        if (!Validator.IsValidEmail(u.Email))
        {
            Console.WriteLine("Invalid email\n");
            return;
        }

        if (DataStore.Users.Exists(x => x.Email == u.Email))
        {
            Console.WriteLine("Email already exists\n");
            return;
        }

        DataStore.Users.Add(u);
        Console.WriteLine("User created successfully!\n\n");
    }

    public static void ShowUsers()
    {
        foreach (var u in DataStore.Users)
            Console.WriteLine($"id: {u.Id} | name: {u.Name} | mobile: {u.Mobile} | email:{u.Email}\n\n");
    }
}
