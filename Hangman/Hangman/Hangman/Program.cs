using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int life = 10;
            Console.Write("Enter a word: ");
            string player1 = Console.ReadLine().ToLower();
            Console.Clear();
            int treffer = 0;
            string answer = "";
            string answer2 = "";
            char player2;
            for (int i = 0; i < player1.Length; i++)
            {
                answer = answer + "*";

            }
            Console.WriteLine(answer);
            Console.WriteLine();

            while (life >= 1)
            {
                Console.WriteLine("Guess the next char: ");
                try
                {
                    player2 = Convert.ToChar(Console.ReadLine().ToLower());
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong Input. Enter Only one Char. Press enter to continue:");
                    player2 = '!';
                    Console.ReadLine();

                }

                for (int i = 0; i < answer.Length; i++)
                {
                    if (answer[i] == '*')
                    {
                        if (player2 == player1[i])
                        {
                            answer2 = answer2 + player1[i];
                            treffer = 1;
                        }
                        else
                        {
                            answer2 = answer2 + "*";
                            //Console.WriteLine();
                        }

                    }
                    else
                    {
                        answer2 = answer2 + answer[i];
                    }
                }
                Console.Clear();

                if (life == 1)
                {
                    Console.WriteLine("You lose");
                    break;
                }

                if (treffer == 0)
                {
                    life--;
                    Console.WriteLine("Ihr buschstabe kommt in gesuchten wort nicht vor");
                } 
                answer = answer2;
                treffer = 0;
                answer2 = "";
                Console.WriteLine("Your guess at this moment: " + answer + " \n Number of lives: " + life);

                if (answer == player1)
                {
                    Console.WriteLine("Player 2 WON");
                    break;
                }

            }
            
            Console.ReadLine();
        }
    }
}
