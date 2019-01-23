using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPlayerOne = false;
            bool restart = true;
            int turns = 0;

            string[,] array2D = new string[,]
            {
                {"       " , "|"},
                {"   1   " , "   2   "},
                {"   3   " , "   4   "},
                {"   5   " , "   6   "},
                {"   7   " , "   8   "},
                {"   9   " , "-------"},
                {"------" , "------"}

            };

            string player1 = "   0   ";
            string player2 = "   X   ";
            string num1 = array2D[1, 0];
            string num2 = array2D[1, 1];
            string num3 = array2D[2, 0];
            string num4 = array2D[2, 1];
            string num5 = array2D[3, 0];
            string num6 = array2D[3, 1];
            string num7 = array2D[4, 0];
            string num8 = array2D[4, 1];
            string num9 = array2D[5, 0];

            do
            {

                do
                {
                    Console.Clear();


                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 2)
                        {
                            Console.WriteLine(array2D[0, 0] + array2D[0, 1] + array2D[0, 0] + array2D[0, 1]);
                            Console.WriteLine(array2D[4, 0] + array2D[0, 1] + array2D[4, 1] + array2D[0, 1] + array2D[5, 0]);
                            Console.WriteLine(array2D[0, 0] + array2D[0, 1] + array2D[0, 0] + array2D[0, 1]);

                        }
                        else
                        {
                            if (i == 0)
                            {
                                Console.WriteLine(array2D[0, 0] + array2D[0, 1] + array2D[0, 0] + array2D[0, 1]);
                                Console.WriteLine(array2D[1, 0] + array2D[0, 1] + array2D[1, 1] + array2D[0, 1] + array2D[2, 0]);
                                Console.WriteLine(array2D[0, 0] + array2D[0, 1] + array2D[0, 0] + array2D[0, 1]);
                                Console.WriteLine(array2D[5, 1] + array2D[0, 1] + array2D[5, 1] + array2D[0, 1] + array2D[5, 1]);
                            }
                            else if (i == 1)
                            {
                                Console.WriteLine(array2D[0, 0] + array2D[0, 1] + array2D[0, 0] + array2D[0, 1]);
                                Console.WriteLine(array2D[2, 1] + array2D[0, 1] + array2D[3, 0] + array2D[0, 1] + array2D[3, 1]);
                                Console.WriteLine(array2D[0, 0] + array2D[0, 1] + array2D[0, 0] + array2D[0, 1]);
                                Console.WriteLine(array2D[5, 1] + array2D[0, 1] + array2D[5, 1] + array2D[0, 1] + array2D[5, 1]);
                            }

                        }

                    }

                    Console.WriteLine();


                    if (num1 == player1 && num2 == player1 && num3 == player1 ||
                        num4 == player1 && num5 == player1 && num6 == player1 ||
                        num7 == player1 && num8 == player1 && num9 == player1 ||
                        num1 == player1 && num4 == player1 && num7 == player1 ||
                        num2 == player1 && num5 == player1 && num8 == player1 ||
                        num3 == player1 && num6 == player1 && num9 == player1 ||
                        num1 == player1 && num5 == player1 && num9 == player1 ||
                        num3 == player1 && num5 == player1 && num7 == player1)
                    {
                        Console.WriteLine("Player ONE won");
                        break;
                    }
                    else if (num1 == player2 && num2 == player2 && num3 == player2 ||
                        num4 == player2 && num5 == player2 && num6 == player2 ||
                        num7 == player2 && num8 == player2 && num9 == player2 ||
                        num1 == player2 && num4 == player2 && num7 == player2 ||
                        num2 == player2 && num5 == player2 && num8 == player2 ||
                        num3 == player2 && num6 == player2 && num9 == player2 ||
                        num1 == player2 && num5 == player2 && num9 == player2 ||
                        num3 == player2 && num5 == player2 && num7 == player2)
                    {
                        Console.WriteLine("Player TWO won");
                        break;
                    }

                    if (isPlayerOne == false)
                    {
                        while (true)
                        {
                            try
                            {
                                PlayerOne();
                                isPlayerOne = true;
                                turns++;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please choose a number on Field: ");
                                continue;
                            }
                            break;
                        }
                    }
                    else
                    {
                        while (true)
                        {
                            try
                            {
                                PlayerTwo();
                                isPlayerOne = false;
                                turns++;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please choose a number on Field: ");
                                continue;
                            }
                            break;
                        }
                    }
                } while (turns < 9);

                Console.WriteLine("Press any key to restart the game");
                Console.ReadLine();
                array2D = new string[,]
            {
                {"       " , "|"},
                {"   1   " , "   2   "},
                {"   3   " , "   4   "},
                {"   5   " , "   6   "},
                {"   7   " , "   8   "},
                {"   9   " , "-------"},
                {"------" , "------"}
            };

                num1 = array2D[1, 0];
                num2 = array2D[1, 1];
                num3 = array2D[2, 0];
                num4 = array2D[2, 1];
                num5 = array2D[3, 0];
                num6 = array2D[3, 1];
                num7 = array2D[4, 0];
                num8 = array2D[4, 1];
                num9 = array2D[5, 0];
                turns = 0;

            } while (restart);





            void PlayerOne()
            {
                Console.WriteLine("PLAYER 1:");
            start:
                int userInput = int.Parse(Console.ReadLine());
                while (userInput >= 10 || userInput <= 0)
                {
                    Console.WriteLine("Wrong Input ! Input the number on the field:");
                    userInput = int.Parse(Console.ReadLine());
                }
                switch (userInput)
                {
                    case 1:
                        if (num1 == player2 || player1 == num1)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[1, 0] = player1;
                        num1 = player1;
                        break;
                    case 2:
                        if (num2 == player2 || player1 == num2)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[1, 1] = player1;
                        num2 = player1;
                        break;
                    case 3:
                        if (num3 == player2 || player1 == num3)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[2, 0] = player1;
                        num3 = player1;
                        break;
                    case 4:
                        if (num4 == player2 || player1 == num4)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[2, 1] = player1;
                        num4 = player1;
                        break;
                    case 5:
                        if (num5 == player2 || player1 == num5)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[3, 0] = player1;
                        num5 = player1;
                        break;
                    case 6:
                        if (num6 == player2 || player1 == num6)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[3, 1] = player1;
                        num6 = player1;
                        break;
                    case 7:
                        if (num7 == player2 || player1 == num7)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[4, 0] = player1;
                        num7 = player1;
                        break;
                    case 8:
                        if (num8 == player2 || player1 == num8)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[4, 1] = player1;
                        num8 = player1;
                        break;
                    case 9:
                        if (num9 == player2 || player1 == num9)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[5, 0] = player1;
                        num9 = player1;
                        break;

                    default:
                        break;
                }


            }
            void PlayerTwo()
            {
                Console.WriteLine("PLAYER 2");
            start:
                int userInput = int.Parse(Console.ReadLine());
                while (userInput >= 10 || userInput <= 0)
                {
                    Console.WriteLine("Wrong Input ! Input the number on the field:");
                    userInput = int.Parse(Console.ReadLine());
                }
                switch (userInput)
                {
                    case 1:
                        if (num1 == player2 || player1 == num1)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[1, 0] = player2;
                        num1 = player2;
                        break;
                    case 2:
                        if (num2 == player2 || player1 == num2)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[1, 1] = player2;
                        num2 = player2;
                        break;
                    case 3:
                        if (num3 == player2 || player1 == num3)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[2, 0] = player2;
                        num3 = player2;
                        break;
                    case 4:
                        if (num4 == player2 || player1 == num4)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[2, 1] = player2;
                        num4 = player2;
                        break;
                    case 5:
                        if (num5 == player2 || player1 == num5)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[3, 0] = player2;
                        num5 = player2;
                        break;
                    case 6:
                        if (num6 == player2 || player1 == num6)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[3, 1] = player2;
                        num6 = player2;
                        break;
                    case 7:
                        if (num7 == player2 || player1 == num7)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[4, 0] = player2;
                        num7 = player2;
                        break;
                    case 8:
                        if (num8 == player2 || player1 == num8)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[4, 1] = player2;
                        num8 = player2;
                        break;
                    case 9:
                        if (num9 == player2 || player1 == num9)
                        {
                            Console.WriteLine("This field is already taken ! Try again:");
                            goto start;
                        }
                        array2D[5, 0] = player2;
                        num9 = player2;
                        break;

                    default:
                        break;
                }
            }

        }


    }

}
