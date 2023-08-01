using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            //using (AppDbContext context = new AppDbContext())
            //{


            //    context.Users.Add(new User("Gari", "Devdson", "Nagibator2000", "2000Nagi", "NudeGator2002@gmail.com"));
            //    context.Users.Add(new User("John", "Doe", "JDoe_123", "JDoe1234", "jdoe@example.com"));
            //    context.Users.Add(new User("Alice", "Smith", "ASmith_456", "ASmith4567", "alice.smith@example.com"));
            //    context.Users.Add(new User("Bob", "Johnson", "BobJ_789", "BobJ7890", "bjohnson@example.com"));
            //    context.Users.Add(new User("Emily", "Williams", "Em_Will", "EmWill123", "emilyw@example.com"));
            //    context.Users.Add(new User("Michael", "Brown", "MBrown_101", "MBrown1010", "mbrown@example.com"));
            //    context.Users.Add(new User("Sophia", "Jones", "Soph_J", "SophJones12", "sophia.jones@example.com"));
            //    context.Users.Add(new User("James", "Lee", "James_L", "JamesLee123", "james.lee@example.com"));
            //    context.Users.Add(new User("Olivia", "Wang", "O_Wang", "OWang456", "olivia.wang@example.com"));

            //    context.SaveChanges();

            //}

            using (AppDbContext context = new AppDbContext())
            {


                var listUser = context.Users.ToList();

                for (int i = 0; i < listUser.Count; i++)
                {
                    if (i == 1 || i == 5 || i == 0 || i == 7)
                    {
                        Console.WriteLine($"{listUser[i].Id} " +
                        $"| {listUser[i].Name} " +
                        $"| {listUser[i].LastName} " +
                        $"| {listUser[i].Login} " +
                        $"| {listUser[i].Email} ");
                    }
                }

                Console.WriteLine(new String('-',50));

                var listUser2 = context.Users.ToList().Where(x => x.Id == 3 || x.Id == 5);

                foreach (var item in listUser2)
                {
                    Console.WriteLine($"{item.Id} " +
                        $"| {item.Name} " +
                        $"| {item.LastName} " +
                        $"| {item.Login} " +
                        $"| {item.Email} ");
                }

                Console.WriteLine(new String('-', 50));



                var listUser3 = context.Users.ToList().Where(x => x.Name == "Gari" || x.Name == "James");

                foreach (var item in listUser3)
                {
                    Console.WriteLine($"{item.Id} " +
                        $"| {item.Name} " +
                        $"| {item.LastName} " +
                        $"| {item.Login} " +
                        $"| {item.Email} ");
                }




                Console.ReadKey();



            }

        }
    }
}
