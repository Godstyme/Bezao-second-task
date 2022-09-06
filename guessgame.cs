using System;
using System.Collections.Generic;

public class GuessSecretNumber
{
    public static void Main(string[] args)
    {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 11);
            List<int> guessNumbers = new List<int>();
            int count = 0;
            int numberofAttempt = 5;

              Console.WriteLine("I am thinking of a secret number between  1 and 10");
              Console.WriteLine("You have only 5 chances to guess a secret number");
              Console.WriteLine("Can you guess it?");
              
             do{
            Console.Write("Guess a secret number:");
              int guessNumber = Convert.ToInt32(Console.ReadLine());
              if(guessNumbers.Contains(guessNumber)){
                  Console.WriteLine("Your guess num is already existing, try a another number");
              } else {
                  guessNumbers.Add(guessNumber);
                  if (guessNumber > secretNumber)
                {
                    Console.WriteLine("Your guess is too high ");
                    count++;
                    continue;
                }
                else if (guessNumber < secretNumber)
                {
                    Console.WriteLine("Your guess is too low");
                    count++;
                    continue;
                }
                else
                {
                    Console.WriteLine("Bravo!, You guessed the right number");
                    count++;
                     break;
                }
              }


            }
            while (count < numberofAttempt);
                Console.WriteLine($"You made {guessNumbers.Count} number of Guesses. Play again :)");
            
    }
}