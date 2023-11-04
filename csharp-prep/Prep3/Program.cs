using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Apoco si papito");

        //Console.Write("What is the magic number?");
        //string magicStri = Console.ReadLine();
        //int magic = int.Parse(magicStri);

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magic)
        {
            Console.Write("What is your guess from 1 to 100?");
            string guessStri = Console.ReadLine();
            guess = int.Parse(guessStri);
            
            if ( guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if ( guess == magic)
            {
                Console.WriteLine("Perfect!");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        
    }
}