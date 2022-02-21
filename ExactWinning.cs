using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class ExactWinning
    {
        public static void GamePlay()
        {
            int[] arr= StartAtZero.GamePlay();
            
            int Position = arr[1];
            int counter= arr[0]; 

            while (Position < 100)
            {
                int roll = DiceRoll.RollTheDice();

                if (Position == 99 && roll == 1)
                {
                   Position =ExactPlay.GamePlay(Position,roll);
                }
                else if (Position == 98 && roll <= 2)
                {
                    Position = ExactPlay.GamePlay(Position, roll);

                }
                else if (Position == 97 && roll <= 3)
                {
                    Position = ExactPlay.GamePlay(Position, roll);
                }
                else if (Position == 96 && roll <= 4)
                {
                    ExactPlay.GamePlay(Position, roll);
                }
                else if (Position == 95 && roll <= 5)
                {
                    Position = ExactPlay.GamePlay(Position, roll);
                }
                counter++;
                Console.WriteLine("position " + Position);
            }
            Console.WriteLine("Player has won in {0} no. of roll ", counter);
            
        }
    }
}