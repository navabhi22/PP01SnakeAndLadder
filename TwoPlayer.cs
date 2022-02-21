using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class TwoPlayer
    {
        public static void TwoPlayerGame()
        {
            int Player1Position=0;
            int Player2Position=0;
            Console.WriteLine("Player1 first roll the dice");
            while (Player1Position <100 && Player2Position <= 100)
            {                
                Player1Position = SnakeAndLadder.TwoPlayerGame.GamePlay(Player1Position);
                Console.WriteLine("Player 1 position is " + Player1Position);
                if (Player1Position >= 100)
                    break;
                Player2Position = SnakeAndLadder.TwoPlayerGame.GamePlay(Player1Position);
                Console.WriteLine("Player 2 position is " + Player2Position);
                if (Player2Position >= 100)
                    break;
            }
            if (Player1Position > Player2Position)
            {
                Console.WriteLine("Player 1 has won");
            }
            else
            {
                Console.WriteLine("Player 2 has won");
            }
        }
    }
}
