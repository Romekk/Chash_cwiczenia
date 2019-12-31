using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>()
            {
                "John Doe",
                "Jane Doe",
                "Jenna Doe",
                "Joe Doe",

            };
            var middleNames = names.Skip(1).Take(2).ToList();
            foreach (var name in middleNames)
                Console.WriteLine(name);
            // Get the names which are 8 characters or less, using LINQ
            //var shortNames = names.Where(name => name.Length <= 8);
            // Order it by length
            var shortNames = names.OrderBy(name => name.Length);
            // Add a name to the original list
            names.Add("Zoe Doe");
            names.Add("1");
            names.Add("1234");
            names.Add("1234567");
            names.Add("12345678");
            names.Add("123456789");
            // Iterate over it - the query has not actually been executed yet!
            // It will be as soon as we hit the foreach loop though!
            foreach (var name in shortNames)
                Console.WriteLine(name);

            List<User> listOfUsers = new List<User>()
        {
        new User() { Name = "John Doe", Mail = "john@doe.com", Age = 42 },
        new User() { Name = "Jane Doe", Mail = "jane@doe.com", Age = 34 },
        new User() { Name = "Joe Doe", Mail = "joe@doe.com", Age = 8 },
        new User() { Name = "Another Doe", Mail = "another@doe.com", Age = 15 },
        };

            List<User> usersByAge = listOfUsers.OrderByDescending(user => user.Age).ToList();
            foreach (User user in usersByAge)
                Console.WriteLine(user.Name + ": " + user.Age + " years");


        foreach (var name in middleNames)
                Console.WriteLine(name);
        }

        class User
        {
            public string Name { get; set; }
            public string Mail { get; set; }
            public int Age { get; set; }
        }
    }
}


   