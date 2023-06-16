using RPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities
{
    public abstract class Entity
    {
        private int _currentHp;
        public Entity()
        {
            Strength = Dice.Throws(DiceType.D6, 5, 3);
            Stamina = Dice.Throws(DiceType.D6, 5, 3);
            Hp = Strength + Stamina;
            CurrentHp = Hp;        
        }
        public int Hp { get; protected set; } // HP max
        public int CurrentHp // Hp actuel
        {
            get { return _currentHp; }
            protected set { _currentHp = value < 0 ? 0 : value > Hp ? Hp : value; }
            // Si value < 0 affiche 0, sinon si value > Hp affiche Hp sinon affiche value
        }

        public bool isAlive { get { return CurrentHp > 0; } }
        public int Strength { get; protected set; }
        public int Stamina { get; protected set; }
        public abstract void Attack(Entity e);

        public void TakeDamage(int amount)
        {
            CurrentHp -= amount;
        }

        
    }
}
