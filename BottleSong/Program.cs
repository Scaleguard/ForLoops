using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall! {i} bottles of beer! Take one down, pass it around, {i} bottles of beer on the wall! ");
            }

            Console.WriteLine("No bottles of beer on the wall! ;(");


        }
    }
}
