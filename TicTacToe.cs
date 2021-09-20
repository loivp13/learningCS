using System;

namespace LearningVisualStudioC
{
    internal class TicTacToe
    {
        private static char[,] playField =
        {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' }
        };
        private static char[,] initialField =
        {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' }
        };

        int turns = 0;
        int player = 2;
        int input = 0;
        bool inputCorrect = true;
        public void SetField()
        {
            Console.WriteLine("    |    |   ");
            //replace variable
            Console.WriteLine("  {0} |  {1} |  {2}  ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |   ");
            Console.WriteLine("  {0} |  {1} |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |   ");
            Console.WriteLine("  {0} |  {1} |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("    |    |   ");
        }
        public void startGame()
        {
            do
            {
                if (player == 2)
                {
                    player = 1;
                } else
                {
                    player = 2;
                }

                SetField();


                do
                {
                    try
                    {
                        Console.WriteLine("\n Player {0}, Choose your field", player);
                        input = Convert.ToInt32(Console.ReadLine());
                    }catch
                    {
                        Console.WriteLine("Please enter a number");
                    }

                    if(input == 1 & (playField[0,0] == '1')){
                        inputCorrect = true;
                    }
                    else if(input == 2 & playField[0,1] == '2'){
                        inputCorrect = true;
                    }else if(input == 3 & playField[0,2] == '3'){
                        inputCorrect = true;
                    }else if(input == 4 & playField[1,0] == '4'){
                        inputCorrect = true;
                    }else if(input == 5 & playField[1,1] == '5'){
                        inputCorrect = true;
                    }else if(input == 6 & playField[1,2] == '6'){
                        inputCorrect = true;
                    }else if(input == 7 & playField[2,0] == '7'){
                        inputCorrect = true;
                    }else if(input == 8 & playField[2,1] == '8'){
                        inputCorrect = true;
                    }else if(input == 9 & playField[2,2] == '9'){
                        inputCorrect = true;
                    }else
                    {
                        Console.WriteLine("\n Please enter another field");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);

                EnterXorO(player, input);
                turns++;
                CheckWinner();


            } while (true);
        }
        public  void  EnterXorO (int player,int input)
        {
            Console.Clear();
            char playerSign = ' ';
            if(player == 1)
            {
                playerSign = 'X';
            }else
            {
                playerSign = 'Y';
            }
            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
        }
        public  void CheckWinner()
        {
            if(playField[0,0] == playField[0,1] & playField[0,1] == playField[0, 2])
            {
                RestartGamePrompt(false);
            }else if(playField[1, 0] == playField[1, 1] & playField[1, 1] == playField[1, 2])
            {
                RestartGamePrompt(false);
            }
            else if (playField[2, 0] == playField[2, 1] & playField[2, 1] == playField[2, 2])
            {
                RestartGamePrompt(false);
            }
            else if (playField[0, 0] == playField[1, 0] & playField[1, 0] == playField[2, 0])
            {
                RestartGamePrompt(false);
            }
            else if (playField[0, 1] == playField[1, 1] & playField[1, 1] == playField[2, 1])
            {
                RestartGamePrompt(false);
            }
            else if (playField[0, 2] == playField[1, 2] & playField[1, 2] == playField[2, 2])
            {
                RestartGamePrompt(false);
            }
            else if (playField[0, 0] == playField[1, 1] & playField[1, 1] == playField[2, 2])
            {
                RestartGamePrompt(false);
            }
            else if (playField[0, 2] == playField[1, 1] & playField[1, 1] == playField[2, 0])
            {
                RestartGamePrompt(false);
            }else if(turns == 9)
            {
                RestartGamePrompt(true);
            }
            {

            }
        }
        public void RestartGamePrompt(bool isDraw)
        {
            do
            {
                if (isDraw)
                {
                    Console.WriteLine("Draw,  \n Play again? Y/N");
                }else
                {
                Console.WriteLine("Player{0} wins! \n Play again? Y/N", player);
                }
                try
                {
                    string playAgain = Console.ReadLine();
                    if (playAgain == "Y")
                    {
                        turns = 0;
                        playField = initialField;
                        break;
                    }
                    else if (playAgain == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter Y for yes or N for no.");
                }
            } while (true);
        }
    }
}