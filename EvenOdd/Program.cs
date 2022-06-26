using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            char choice;
            do
            {
                Console.WriteLine("enter the number");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                    Console.WriteLine("the number is even");
                else
                    Console.WriteLine("the number is odd");
                Console.WriteLine();
                Console.WriteLine("do you want to continue. Y or N");

                choice = Console.ReadLine()[0];
            }
            while (choice != 'n' && choice != 'N');
        }
    }
}
