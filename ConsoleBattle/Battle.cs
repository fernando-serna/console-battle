using System;
namespace ConsoleBattle
{
    public class Battle
    {
        // recieve both warrior objects
        public static void StartFight(Warrior warrior1,
            Warrior warrior2)
        {
            // loop giving each warrior chance to attack and block
            while (true)
            {
                if (GetAttackResults(warrior1, warrior2) == "Game Over" || GetAttackResults(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        // accept 2 warriors
        public static string GetAttackResults(Warrior warriorA,
            Warrior warriorB)
        {
            // calculate one warriors attack and the others block
            double warAAttkAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();

            // subtract block from attack
            double dmg2WarB = warAAttkAmt - warBBlkAmt;

            // if there was damage subtract that from the health
            if (dmg2WarB > 0)
            {
                warriorB.Health -= dmg2WarB;
            }
            else dmg2WarB = 0;

            // print out info on who attacked who and for how much
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                warriorA.Name, warriorB.Name, dmg2WarB);

            // provide output on the change to health
            Console.WriteLine($"{warriorB.Name} Has {warriorB.Health}\n");

            // check if the warriors health fell below zero and if so, end loop
            if (warriorB.Health <= 0)
            {
                Console.WriteLine($"{warriorB.Name} has Died and {warriorA.Name} is Victorious\n");
                return "Game Over";
            }
            else return "Fight Again";
        }
    }
}
