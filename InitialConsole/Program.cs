using System;

namespace InitialConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTimes = 6;

            for (int i = 1; i < numberOfTimes; i++)
            {
                Console.WriteLine($"Writing in console. Line {i};");
            }
            Console.WriteLine("And the good old:\nHello World!");
        }
    }
}
