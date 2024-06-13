using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Security.Authentication.ExtendedProtection;

namespace FærdighedsPrøve
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection();

            serviceProvider.AddSingleton<IMemeberRepository, MemberRepository>();
            serviceProvider.AddSingleton<IDogRepository, DogRepository>();
            serviceProvider.BuildServiceProvider();

            var memberRepo = serviceProvider.BuildServiceProvider().GetService<IMemeberRepository>();
            var dogRepo = serviceProvider.BuildServiceProvider().GetService<IDogRepository>();

            Controller controller = new Controller(dogRepo, memberRepo);

            /*Logiken til at udregne alderen af Member*/
            /*DateTime birthdayyear = DateTime.Now;
            int age = DateTime.Now.Year - 2020;
            Console.WriteLine(age);
            */

            //Start below
            Console.WriteLine("Write the Dog number");

            int dogNumber = Convert.ToInt32(Console.ReadLine());

            controller.GetDog(dogNumber);

            Console.WriteLine($"{controller.DisplayDog(dogNumber)}");



            Console.WriteLine("Write the Member number");

            int memberNumber = Convert.ToInt32(Console.ReadLine());

            controller.GetMember(memberNumber);

            controller.AssignDog();

            Console.WriteLine($"{controller.DisplayMember(memberNumber)}");

            Console.WriteLine($"{controller.DisplayAge}");


        }
    }
}
