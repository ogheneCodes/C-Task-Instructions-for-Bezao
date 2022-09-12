// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

class Program
{

    public static void Main(string[] args)
    {

        Random random = new Random();
        bool PlayAgain = true;
        int Min = 1;
        int Max = 200;
        int Guess;
        int Number;
        int Guesses;
        String Response;

        while (PlayAgain)
        {
            Guess = 0;
            Guesses = 0;
            Number = random.Next(Min, Max);
            Response = "";

            while (Guess != Number)
            {
                Console.WriteLine("Guess a Number between" + " " + Min + " - " + Max + ":  ");
                Guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + Guess);

                if (Guess > Number)
                {
                    Console.WriteLine(Guess + "\n" + "Guess it too high");
                }
                else if (Guess < Number)
                {
                    Console.WriteLine(Guess + "\n" + "Guess it too low");
                }
                Guesses++;
            }
            Console.WriteLine("Number: " + Number);
            Console.WriteLine("You Win Champion! 👑");
            Console.WriteLine("Guesses: " + Guesses);
            Console.WriteLine("Would you Like to play again?(Y/N):  ");
            Response = Console.ReadLine();
            Response = Response.ToUpper();

            if (Response == "Y")
            {
                PlayAgain = true;
            }
            else
            {
                PlayAgain = false;
            }
        }
        Console.WriteLine("Thank you for Playing this Game!");
        Console.ReadKey();
        Console.WriteLine("Hello World");
    }
}