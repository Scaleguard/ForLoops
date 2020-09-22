using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks for a number
             and displays he multiplication table for
            the given number, 1 to 10*/
            Console.WriteLine("Enter a number: ");
            int userNumber = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{userNumber} x {i} = {userNumber*i}");
            }

            for(int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"{userNumber} X {i} = {userNumber * i}");
            }
        }
    }
}
