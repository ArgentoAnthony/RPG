using RPG.Entities.Interfaces;
using RPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Heroes
{
    public abstract class Hero : Entity, IGold, ILeather
    {
        public Hero()
        {
            Strength = Dice.Throws(DiceType.D10, 5, 3);
            Stamina = Dice.Throws(DiceType.D10, 5, 3);
        }
        public string Name { get; set; }
        public int Gold { get; set; } 
        public int Leather { get; set; }

        public void Heal()
        {
            CurrentHp = Hp;
        }

        public void Loot(Entity e)
        {
            if (e is IGold g)
            {
                Console.WriteLine($"{this.Name} loot {g.GetType().Name} et obtient {g.Gold} or");
                this.Gold += g.Gold;
            }
            if (e is ILeather l)
            {
                Console.WriteLine($"{this.Name} loot {l.GetType().Name} et obtient {l.Leather} cuir");
                Leather += l.Leather;
            }
            Heal();
        }
        public override void GenerateStats()
        {
           Strength = Dice.Throws(DiceType.D10, 5, 3);
           Stamina = Dice.Throws(DiceType.D10, 5, 3);
        }

    }
}
