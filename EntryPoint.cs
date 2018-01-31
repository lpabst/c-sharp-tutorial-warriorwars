using System;
using Warriors.Enum;

namespace WarriorWArs
{
    class EntryPoint
    {
        static Random rng = new Random;

        static void Main()
        {
            Warrior goodGuy = new Warrior('Bob', Faction.GoodGuy);
            Warrior badGuy = new Warrior('Joe', Faction.BadGuy);

            while (goodGuy.isAlive && badGuy.isAlive){
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }
        }
    }
}