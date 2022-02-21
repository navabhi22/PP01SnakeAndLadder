using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class ExactPlay
    {
        public static int GamePlay(int Position, int roll)
        {
            int Snake = 0;
            int Ladder = 2;
            int NoPlay = 1;
            int option = CheckOption.Option();
            if (option == Snake)
            {
                Position = Position - roll;
                Console.WriteLine("snake");
            }
            else if (option == Ladder)
            {
                Position = Position + roll;
                Console.WriteLine("Ladder");
            }
            else if (option == NoPlay)
            {
                Console.WriteLine("NoPlay");
            }

            return Position;
        }
    }
}