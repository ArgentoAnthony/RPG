using RPG.Entities.Interfaces;
using RPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Monsters
{
    public abstract class Monster : Entity
    {
        public override void GenerateStats()
        {
            Strength = Dice.Throws(DiceType.D6, 3, 3);
            Stamina = Dice.Throws(DiceType.D6, 3, 3);

        }
    }
}
