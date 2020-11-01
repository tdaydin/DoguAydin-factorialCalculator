using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the facorial of a given number");
            Console.WriteLine("This program will exit when entered a negative number" + "\n");
            int input = 0;
            //int output = 1;

            while (input >= 0)
            {
                Console.Write("Please enter a number: ");
                input = Convert.ToInt32(Console.ReadLine());
                int output = 1;

                if (input == 0)
                {
                    output = 1;
                }
                else
                {
                    for (int i = 1; i < (input + 1); i++)
                    {
                        output = output * i;
                    }
                }

                Console.WriteLine(output);


            }
        }
    }
}
