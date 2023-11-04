using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Time to rock");

        Console.Write("What is your grade?:");
        string initialGrade = Console.ReadLine();
        int grade = int.Parse(initialGrade);

        if (grade >= 90)
        {
            Console.WriteLine($"Your grade is A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"Your grade is B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"Your grade is C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"Your grade is D");
        }
        else
        {
            Console.WriteLine("Your gade is F");
        }



        if (grade >= 70 )
        {
            Console.WriteLine("Congratulations, you passed the course");
        }
        else 
        {
            Console.WriteLine("Sorry, you didn't approve the course");
        }

        
        
    }
}