using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's is your name: ");
            string name = Console.ReadLine();

            int num = int.Parse (Console.ReadLine());
            while (num > 0)
            {
                Console.WriteLine(name);
                num--;
            }
                
        }
    }
}
