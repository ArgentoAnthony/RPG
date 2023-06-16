using RPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Monsters
{
    public class Wolf : Monster
    {
        public override void Attack(Entity e)
        {
            Console.WriteLine("Ahouuu");
            e.TakeDamage(Dice.Throws(DiceType.D4));
        }
    }
}
