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
            Console.WriteLine("Draft Code of Intruction: \n 1. validate\n 2. user\n 3. id\n 4. check\n 5. guest\n 6. last login\n 7. logout");
            Console.WriteLine("Please pick the number of the intruction above");
            int code = Convert.ToInt32(Console.ReadLine());
            auth.login(username,password);
            switch(code)
            {
                case 1:
                auth.validate(username,password);
                break;

                case 2:
                auth.user();
                break;

                case 3:
                auth.id();
                break;

                case 4:
                auth.check();
                break;

                case 5:
                auth.guest();
                break;

                case 6:
                auth.lastLogin();
                break;

                case 7:
                auth.logout();
                break;
            }
        }
    }
}