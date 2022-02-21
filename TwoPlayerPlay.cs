using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class TwoPlayerGame
    {
        public static int GamePlay(int Position)
        { 
            
                if (Position <= 0)
                {
                    Position = 0;
                    Position = Play.GamePlay(Position);
                }
                else
                {
                    Position = Play.GamePlay(Position);
                }
               
            
            return Position;
        }
    }
}