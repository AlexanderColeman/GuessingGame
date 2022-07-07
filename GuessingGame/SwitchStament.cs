using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class SwitchStament
    {
        public static void SchoolSubjects()
        {
            Console.WriteLine("We is your favoite school subject");
            
            var favoriteSubject = Console.ReadLine().ToLower();


            switch (favoriteSubject)
            {
                case "math":
                    Console.WriteLine("Math can be a fun subject");
                    break;
                case "english":
                    Console.WriteLine("I like math more than english");
                    break;
                case "science":
                    Console.WriteLine("Science is fun");
                    break;
                case "computer Science":
                    Console.WriteLine("Computer Science is the best overall im with you");
                    break;
                case "spanish":
                    Console.WriteLine("This will come in handy");
                    break;
                default:
                    Console.WriteLine("We must not like similar subjects");
                    break;

            }


        }


    }
}
