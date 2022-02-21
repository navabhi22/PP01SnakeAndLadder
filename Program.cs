using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This problem simulates a Snake and Ladder Game");
            Console.WriteLine(" Single Player Game, Player Start at zero ");
            int Start = 0;
            int End = 100;
            int ROll = DiceRoll.RollTheDice();
            Console.WriteLine("Checking for options Ladder, Snake or NoPlat");
            int Snake = 0;
            int NoPlay = 1;
            int Ladder = 2;
            int option = CheckOption.Option();
        }
    }
}
