using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class DiceRoll
    {
        public static int RollTheDice()
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            return roll;
        }
    }
}
