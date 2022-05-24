using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppassign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess what age the teacher is? ");
            int numberguess = Convert.ToInt32(Console.ReadLine());
            bool guessednumber = numberguess == 34;

            // This is a do statement
            do
            {
                switch (numberguess)
                {
                    case 24:
                        Console.WriteLine("You guessed 24. Try again.");
                        Console.WriteLine("Guess what age the teacher is? ");
                        numberguess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess what age the teacher is? ");
                        numberguess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 38:
                        Console.WriteLine("You guessed yellow. Try again.");
                        Console.WriteLine("Guess what age the teacher is? ");
                        numberguess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 34:
                        Console.WriteLine("You guessed the teachers age. That is correct.");
                        guessednumber = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.Write("Guess a number?");
                        numberguess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            // this is the while statement 
            while (!guessednumber);

            Console.Read();
        }
    }
}
