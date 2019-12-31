using System;
using System.Collections.Generic;



namespace CHtutorial
{
    class program
    {
        static void Main(string[] args)
        {
            List<User> listOfUsers = new List<User>()
        {
        new User() { Name = "John Doe", Age = 42 },
        new User() { Name = "Jane Doe", Age = 34 },
        new User() { Name = "Joe Doe", Age = 8 },
        new User() { Name = "Jon Doe", Age = 8 },
        };

           List<string> listOfNames = new List<string>()
{
    "Joe Doe"
};
            // Insert at the top (index 0)
            listOfNames.Insert(0, "John Doe");
            // Insert in the middle (index 1)
            listOfNames.Insert(1, "Jane Doe");

            for (int i = 0; i < listOfUsers.Count; i++)
            {
                Console.WriteLine(listOfUsers[i].Name + " is " + listOfUsers[i].Age + " years old");
            }

        }
    }
    class User
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}


