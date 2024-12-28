using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace rohitDotNet
{
    internal class MyClass {
        

        public void Addition()
        {

                Console.WriteLine("Enter the number");

                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the number");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Addition= " + (x + y));

            }
        }

}
