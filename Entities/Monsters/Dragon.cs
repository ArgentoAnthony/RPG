using RPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Monsters
{
    public class Dragon : Monster
    {
        public override void Attack(Entity e)
        {
            Console.WriteLine("RRRRRRRrrrrrrr");
            e.TakeDamage(Dice.Throws(DiceType.D20));
        }
    }
}
