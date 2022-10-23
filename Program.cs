
namespace ROCKPAPERSCISSORS
{
    class Program
    {
        private static int scorePlayer;
        private static int scoreCPU;

        static void Main()
        {   
            // variable if player wants to play or not
            string playgame;

            // ask user if they want to play
            Console.WriteLine("WANT TO PLAY A GAME: [Y] OR [N] ?");

            // takes user input
            playgame = Console.ReadLine().ToUpper();

            // if user says yes, continue to game
            // continues to play as long as user says "Y"
            while (playgame == "Y")
            {
                // start the game
                PlayGame();

                // ask user if they want to play again
                Console.WriteLine("PLAY AGAIN: [Y] OR [N] ?");

                // takes user input
                playgame = Console.ReadLine().ToUpper();
            }

        }

        static void PlayGame()
        {
            string inputPlayer, inputCPU;
            int randomInt;

            Console.WriteLine("Choose between ROCK, PAPER and SCISSORS:       ");
            inputPlayer = Console.ReadLine().ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(0, 3);

            switch (randomInt)
            {
                case 0:
                    inputCPU = "ROCK";
                    DisplayCPUInput(inputCPU);
                    CheckWinner(inputPlayer, inputCPU);
                    break;
                case 1:
                    inputCPU = "PAPER";
                    DisplayCPUInput(inputCPU);
                    CheckWinner(inputPlayer, inputCPU);
                    break;
                case 2:
                    inputCPU = "SCISSORS";
                    DisplayCPUInput(inputCPU);
                    CheckWinner(inputPlayer, inputCPU);
                    break;
                default:
                    break;
            }

            Console.WriteLine("CURRENT SCORE: \n PLAYER {0} || CPU {1}", scorePlayer, scoreCPU);
        }

        static void DisplayCPUInput(string args)
        {
            Console.WriteLine("Computer chose {0}", args);
        }
        static void CheckWinner(string inputPlayer, string inputCPU)
        {   
            switch(inputPlayer) 
            {
                case "PAPER":
                    if (inputCPU == "PAPER")
                    {
                        Console.WriteLine("DRAW!! \n \n");
                    }
                    else if (inputCPU == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS!! \n \n");
                        scorePlayer++;
                    }
                    else if (inputCPU == "SCISSORS")
                    {
                        Console.WriteLine("CPU WINS!! \n \n");
                        scoreCPU++;
                    }
                break;
                case "ROCK":
                    if (inputCPU == "PAPER")
                    {
                        Console.WriteLine("CPU WINS!! \n \n");
                        scoreCPU++;
                    }
                    else if (inputCPU == "ROCK")
                    {
                        Console.WriteLine("DRAW!! \n \n");
                    }
                    else if (inputCPU == "SCISSORS")
                    {
                        Console.WriteLine("PLAYER WINS!! \n \n");
                        scorePlayer++;
                    }
                    break;
                case "SCISSORS":
                    if (inputCPU == "PAPER")
                    {
                        Console.WriteLine("PLAYER WINS!! \n \n");
                        scorePlayer++;
                    }
                    else if (inputCPU == "ROCK")
                    {
                        Console.WriteLine("CPU WINS!! \n \n");
                        scoreCPU++;
                    }
                    else if (inputCPU == "SCISSORS")
                    {
                        Console.WriteLine("DRAW!! \n \n");
                    }
                    break;
                default:
                    Console.WriteLine("PLEASE CHOOSE A VALID OBJECT");
                    break;

            }
        }
    }
}