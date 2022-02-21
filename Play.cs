using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Play
    {
        public static int GamePlay(int Position)
        {
            int Snake = 0;
            int Ladder = 2;
            int roll = DiceRoll.RollTheDice();

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
            else
            {
                Console.WriteLine("NoPlay");
            }

           return Position;
        }
    }
}
