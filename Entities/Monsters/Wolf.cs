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
        public int Leather { get; } = Dice.Throws(DiceType.D6);
        public override void Attack(Entity e)
        {
            Console.WriteLine("Ahouuu");
            e.TakeDamage(Dice.Throws(DiceType.D4));
        }
    }
}
