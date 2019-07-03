using System;
namespace ConsoleBattle
{
    public class Warrior
    {
        // define warrior properties
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // create and reuse single random instance else we'll get same value every time
        Random rnd = new Random();

        // constructor initializes warrior
        public Warrior(string name = "Warrior",
            double health = 0,
            double attkMax = 0,
            double blockMax =0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }

        // generate random attack value from 1 to warriors max attack value
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        // generate random block value
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
