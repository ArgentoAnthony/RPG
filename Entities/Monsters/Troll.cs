using RPG.Entities.Interfaces;
using RPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Monsters
{
    public class Troll : Monster, IGold
    {
        public int Gold { get; } = Dice.Throws(DiceType.D6);
        public override void Attack(Entity e)
        {
            Console.WriteLine("Tire mon doigt");
            e.TakeDamage(Dice.Throws(DiceType.D6));
        }
    }
}
