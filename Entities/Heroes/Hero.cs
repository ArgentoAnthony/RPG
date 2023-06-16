using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Heroes
{
    public abstract class Hero : Entity
    {
        public string Name { get; set; }
        public void Heal()
        {
            CurrentHp = Hp;
        }

        public void Loot(Entity e)
        {
            //TODO
        }


    }
}
