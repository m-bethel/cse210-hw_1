using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);
        int answer = -1;
        do
        {
            Console.WriteLine("What is the magic number between 1 and 100?");
            answer = int.Parse(Console.ReadLine());
            if (number > answer)
            {
                Console.WriteLine("Higher!");
            }
            else if (number < answer)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine($"You are Correct! The Answer was: {number}.");
            }
        } while (number != answer);
    }
}