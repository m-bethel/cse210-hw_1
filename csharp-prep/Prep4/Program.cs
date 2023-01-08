using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of number, type 0 when finished.");
        int number = -1;
        //do-while loop seems to make the most sense
        do
        {
            Console.WriteLine("Enter a number:");        
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            
        }while (number !=0 );
        //Calculating the Sum
        int sum = 0;
        foreach (int value in numbers)
        {
            sum += value;
        }
        Console.WriteLine($"The total is: {sum}");
        //Calculating the Average
        float average = ((float)sum) / (numbers.Count-1);
        //It will count the "0" as an answer in the average calculation
        Console.WriteLine($"The Average is: {average}");

        //Finding the max in the list
        Console.WriteLine("Maximum Value: "+numbers.Max());
        
    
    }
}