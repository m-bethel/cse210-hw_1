using System;

class Program
{
    static void Main(string[] args)
    {
        //This is prep 2
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage?");
        string gradepercentage = Console.ReadLine();
        int number = int.Parse(gradepercentage);
        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;

        string letter = "";

        if (number >= A)
        {
            letter ="A";
        }
        else if (number >= B )
        {
            letter ="B";
        }
        else if (number >=C)
        {
            letter ="C";
        }
        else if (number >=D)
        {
            letter ="D";
        }
        else
        {
            letter ="F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (number >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("There is always next semester.");
        }
    }
}