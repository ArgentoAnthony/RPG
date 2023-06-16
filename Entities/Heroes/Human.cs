using RPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Heroes
{
    public class Human : Hero
    {
        public Human(string name)
        {
            Name = name;
            if (name == "Dante") 
            {
                Strength *= 10;
                Stamina *= 10;
                Hp *= 10;
                CurrentHp *= 10;
            }
        }
        public override void Attack(Entity e)
        {
            Console.WriteLine("Que trépasse si je faiblis!");
            e.TakeDamage(Dice.Throws(DiceType.D10,5));
        }
    }
}
