using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectProp
{
   
   class Program
   
    {
      
        static void Main(string[] args)
        {
            List<User> listOfUsers = new List<User>()
        {
        new User() { Name = "John Doe", Mail = "john@doe.com", Age = 42 },
        new User() { Name = "Jane Doe", Mail = "jane@doe.com", Age = 34 },
        new User() { Name = "Joe Doe", Mail = "joe@doe.com", Age = 8 },
        new User() { Name = "Another Doe", Mail = "another@doe.com", Age = 15 },
        };

            var simpleUsers = listOfUsers.Select(user => new
            {
                Name = user.Name,
                Age = user.Age
            });
            foreach (var user in simpleUsers)
                Console.WriteLine(user.Name);
            Console.WriteLine("hello");
        }

        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Mail { get; set; }
        }
    }
}