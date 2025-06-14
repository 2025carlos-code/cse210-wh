using System;

class Program
{
    static void Main(string[] args)
    {
        Random randonGenerator = new Random();
        //generate a random number between 1 and 100
        int magicNumber = randonGenerator.Next(1, 101);

        int guess = -1;
        int guessCount = 0;


        //loop until the user guesses the magic number
        while (guess != magicNumber)
        {

            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++; //increment the counter after each guess


            //determine if the guess needs to be higher or lower
            if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }

        }
        //display the number of guesses
        Console.WriteLine($"You guessed the magic number {magicNumber} in {guessCount} tries.");

        //display a congratulatory message          
        Console.WriteLine("Congratulations! You guessed the magic number!");







    }
}