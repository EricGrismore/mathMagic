﻿using System;

namespace mathMagic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n1, n2;
            Random rnd = new Random();
            char selection = menu();
            while (selection != 'q')
            {
                n1 = rnd.Next(50) + 1;
                n2 = rnd.Next(50) + 1;
                switch (selection)
                {
                    case 'a':
                    case 'A':
                        addition(n1, n2);
                        break;
                    case 's':
                    case 'S':
                        subtraction(n1, n2);
                        break;
                    case 'm':
                    case 'M':
                        multiplication(n1, n2);
                        break;
                    case 'd':
                    case 'D':
                        division(n1, n2);
                        break;
                    default:
                        Console.WriteLine("You made an invalid selection, please try again");
                        break;
                }
                selection = menu();

            }
        }

        private static void addition(int n1, int n2)
        {
            try
            {
                int missed = 1;
                int result = n1 + n2;
                Console.Write($"{n1}+{n2}= ");
                int answer = int.Parse(Console.ReadLine());
                while (answer != result)
                {
                    wrongFeedback();
                    Console.Write($"{n1}+{n2}= ");
                    answer = int.Parse(Console.ReadLine());
                    missed++;
                    if (missed > 9)
                    {
                        Console.WriteLine("You have missed too many answers, please see tutoring");
                        break;
                    }

                }
                if (missed < 10)
                    rightFeedback();
            }
            catch (FormatException e)
            {
                Console.WriteLine("You have entered bad data");
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("An error occurred, please try again.");
            }
        }

        private static void subtraction(int n1, int n2)
        {
            try
            {
                int missed = 1;
                int result = n1 - n2;
                Console.Write($"{n1}-{n2}= ");
                int answer = int.Parse(Console.ReadLine());
                while (answer != result)
                {
                    wrongFeedback();
                    Console.Write($"{n1}-{n2}= ");
                    answer = int.Parse(Console.ReadLine());
                    missed++;
                    if (missed > 9)
                    {
                        Console.WriteLine("You have missed too many answers, please see tutoring");
                        break;
                    }

                }
                if (missed < 10)
                    rightFeedback();
            }
            catch (FormatException e)
            {
                Console.WriteLine("You have entered bad data");
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("An error occurred, please try again.");
            }
        }

        private static void multiplication(int n1, int n2)
        {
            try
            {
                int missed = 1;
                int result = n1 * n2;
                Console.Write($"{n1}*{n2}= ");
                int answer = int.Parse(Console.ReadLine());
                while (answer != result)
                {
                    wrongFeedback();
                    Console.Write($"{n1}*{n2}= ");
                    answer = int.Parse(Console.ReadLine());
                    missed++;
                    if (missed > 9)
                    {
                        Console.WriteLine("You have missed too many answers, please see tutoring");
                        break;
                    }

                }
                if (missed < 10)
                    rightFeedback();
            }
            catch (FormatException e)
            {
                Console.WriteLine("You have entered bad data");
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("An error occurred, please try again.");
            }
        }

        private static void division(int n1, int n2)
        {
            try
            {
                int missed = 1;
                int result = n1 / n2;
                Console.Write($"{n1}/{n2}= ");
                int answer = int.Parse(Console.ReadLine());
                while (answer != result)
                {
                    wrongFeedback();
                    Console.Write($"{n1}/{n2}= ");
                    answer = int.Parse(Console.ReadLine());
                    missed++;
                    if (missed > 9)
                    {
                        Console.WriteLine("You have missed too many answers, please see tutoring");
                        break;
                    }

                }
                if (missed < 10)
                    rightFeedback();
            }
            catch (FormatException e)
            {
                Console.WriteLine("You have entered bad data");
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("An error occurred, please try again.");
            }
        }

        private static void rightFeedback()
        {
            Random r = new Random();
            int num = r.Next(8) + 1;
            switch (num)
            {
                case 1:
                    Console.WriteLine("Amazing!");
                    break;
                case 2:
                    Console.WriteLine("Ya got it!");
                    break;
                case 3:
                    Console.WriteLine("Now your on a roll.");
                    break;
                case 4:
                    Console.WriteLine("We'll make a genius out of you yet.");
                    break;
                case 5:
                    Console.WriteLine("The knowledge os overflowing.");
                    break;
                case 6:
                    Console.WriteLine("You got it wrong. Just kidding, of course you got it right.");
                    break;
                case 7:
                    Console.WriteLine("Another one complete.");
                    break;
                default:
                    Console.WriteLine("That's Right!");
                    break;
            }
        }

        private static void wrongFeedback()
        {
            Random r = new Random();
            int num = r.Next(8) + 1;
            switch (num)
            {
                case 1:
                    Console.WriteLine("Incorrect, please try again");
                    break;
                case 2:
                    Console.WriteLine("Ooops, try it again");
                    break;
                case 3:
                    Console.WriteLine("Nope, better luck next time.");
                    break;
                case 4:
                    Console.WriteLine("No, just no.");
                    break;
                case 5:
                    Console.WriteLine("Wrong.");
                    break;
                case 6:
                    Console.WriteLine("Your bad.");
                    break;
                case 7:
                    Console.WriteLine("Aggggh.");
                    break;
                default:
                    Console.WriteLine("Incorrect");
                    break;
            }
        }

        private static char menu()
        {
            Console.WriteLine("Choose the type of math problem you want to solve");
            Console.WriteLine("a=addition, s=subtraction, m=multiplication, d=division, q=quit");
            int choice = Console.Read();
            Console.ReadLine(); 
            return Convert.ToChar(choice);
        }
    }
}
