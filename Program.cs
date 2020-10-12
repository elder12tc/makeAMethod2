using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeAMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            age = displayGetUserAge();
        }

        static int displayGetUserAge()
        {
            int age;
            string userResponse;
            bool validResponse;

         
            do
            {
                validResponse = true;

                Console.Write("What is your age: ");
                //userResponse = Console.ReadLine();

                //if (!int.TryParse(userResponse, out age))
                //{
                //    Console.WriteLine("Please enter a proper age as an integer.");
                //    validResponse = false;
                //}


                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Please enter a proper age as an integer.");
                    validResponse = false;
                }

            } while (!validResponse);








            return age;
        }
    }
}
