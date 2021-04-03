using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "! Welcome to the game!");
            int i;
            {
                {
                    Console.Write("MENU \n1) Game with PC \n2) Game with friend \n3) Exit from Game \n\nYour choose: ");
                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("1");
                            break;
                        case 2:
                            Console.WriteLine("2");
                            break;
                        case 3:
                            Console.WriteLine("3");
                            break;
                        default:
                            Console.WriteLine("Wrong number, choose again from 1 to 3: ");
                            break;
                    }

                    Console.Write("\nPress any button to start");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.WriteLine("Do you choose rock,paper or scissors");
                string userChoice = Console.ReadLine();
                Random r = new Random();
                int computerChoice = r.Next(4);

                if (computerChoice == 1)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer choose rock");
                        Console.WriteLine("It is a tie ");
                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer choose paper");
                        Console.WriteLine("It is a tie ");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer choose scissors");
                        Console.WriteLine("It is a tie ");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");

                    }

                }

                else if (computerChoice == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer choose paper");
                        Console.WriteLine(name + ", sorry you lose, paper beat rock");
                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer choose scissors");
                        Console.WriteLine(name + ", sorry you lose, scissors beat paper ");
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer choose rock");
                        Console.WriteLine(name + ", sorry you lose, rock beats scissors");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine(name + ", you win, rock beats scissors");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer choose rock");
                        Console.WriteLine(name + ", you win, paper beats rock");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer choose paper");
                        Console.WriteLine(name + ", you win, scissors beat paper");

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");
                    }
                    
                    Console.WriteLine("Try again? y/n");
                    ConsoleKeyInfo cki = Console.ReadKey();
                    keepPlaying = cki.KeyChar == 'y';
                }
            }
        }
    }
}
    
