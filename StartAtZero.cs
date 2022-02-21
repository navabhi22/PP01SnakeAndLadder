using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class StartAtZero
    {
        public static int[] GamePlay()
        {
            int Position = 0;
            int counter = 0;
            while (Position < 100)

            {
                if (Position <= 0)
                {
                    Position = 0;
                    Position = Play.GamePlay(Position);
                    //Console.WriteLine(Position);
                }
                else
                {
                    Position = Play.GamePlay(Position);
                    //Console.WriteLine(Position);
                }
                counter++;
            }
            int[] arr = new int[2];
            arr[0] = counter;
            arr[1] = Position;
            return arr;
        }
    }
}