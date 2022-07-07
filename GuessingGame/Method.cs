using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class Method
    {
        public static int getRandomNumber()
        {
            var r = new Random();
            var randomNumber = r.Next(1,100);
            return randomNumber;
        }

        public static int getUserInput()
        {

            int output;
            string input;

            while (true)
            {
                Console.Write("Enter a guess between 1 and 100\n");
                input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {

                        return output;
                }
                else
                {
                    Console.WriteLine("That was not a valid number! press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        public static void GuessingGameLogic()
        {
            var randomNumber = getRandomNumber();
            while (true)
            {
                
                var playerGuess = getUserInput();

                if (randomNumber > playerGuess)
                {
                    Console.WriteLine("Your guess was to low");
                }
                else if (randomNumber < playerGuess)
                {
                    Console.WriteLine("Your guess was to high");
                } else if(playerGuess <=1 && playerGuess >= 100)
                {
                    Console.WriteLine("that number is out of bounds");
                }
                else
                {
                    Console.WriteLine("that was the guess");
                    return;
                }
            }
            
        }
    }
}
