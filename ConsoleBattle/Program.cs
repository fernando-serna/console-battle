using System;

namespace ConsoleBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of player1: ");
            string player1 = Console.ReadLine();

            Console.WriteLine("Enter the name of player2: ");
            string player2 = Console.ReadLine();

            Warrior warrior1 = new Warrior(player1, 1000, 120, 40);
            Warrior warrior2 = new Warrior(player2, 1000, 120, 40);

            Battle.StartFight(warrior1, warrior2);

            Console.ReadLine();
        }
    }
}
