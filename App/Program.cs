using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Username daxil edin :");
            string username = Console.ReadLine();
            Console.WriteLine("Password daxil edin :");
            string password = Console.ReadLine();
            User user1 = new User(username);
            user1.Password = password;

            Console.WriteLine(user1.Username + "  " + user1.Password);
        
        }
    }
}
