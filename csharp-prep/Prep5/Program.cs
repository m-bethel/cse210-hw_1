using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayMessage();
        string YourName();
        int YourNumber();
        int YourNumberSquared();

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string YourName()
        {
            Console.WriteLine($"Please Enter your Name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int YourNumber()
        {
            Console.WriteLine($"Please Enter your Favotrite Number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int YourNumberSquared(int number)
        {
            int squared = number * number;
            return squared;
        }
       
    }
}