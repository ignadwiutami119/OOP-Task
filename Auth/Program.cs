using System;
using Auth;
namespace Auth
{    
    class Program
    {
        static void Main(string[] args)
        {
            Auth auth = new Auth("igna","12345","001");
            Console.WriteLine("Account info :\n username : igna\n password : 12345");
            Console.WriteLine("enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("enter your password");
            string password = Console.ReadLine();
            Console.WriteLine("Draft Code of Intruction: \n 1. login\n 2. validate\n 3. user\n 4. id\n 5. check\n 6. guest\n 7. last login\n 8. logout");
            Console.WriteLine("Please pick the number of the intruction above");
            int code = Convert.ToInt32(Console.ReadLine());
            switch(code)
            {
                case 1: 
                auth.login(username,password);
                break;

                case 2:
                auth.validate(username,password);
                break;

                case 3:
                auth.user();
                break;

                case 4:
                auth.id();
                break;

                case 5:
                auth.login(username,password);
                auth.check();
                break;

                case 6:
                auth.guest();
                break;

                case 7:
                auth.login(username,password);
                auth.lastLogin();
                break;

                case 8:
                auth.login(username,password);
                auth.logout();
                break;
            }
        }
    }
}