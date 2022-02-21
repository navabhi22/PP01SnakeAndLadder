using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class CheckOption
    {
        public static int Option()
        {
            Random random = new Random();
            int option = random.Next(0, 3);
            return option;
        }
    }
}
