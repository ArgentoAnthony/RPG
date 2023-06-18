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
        public string Name { get; set; }
        public int Gold { get; set; } 
        public int Leather { get; set; }

        public void Heal()
        {
            CurrentHp = Hp;
        }

        public void Loot(Entity e)
        {
            if(e is IGold g)
            {
                this.Gold += g.Gold;
            }
            if (e is ILeather l)
            {
                Leather += l.Leather;
            }
        }


    }
}
