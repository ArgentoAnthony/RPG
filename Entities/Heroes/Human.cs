﻿using RPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Heroes
{
    public class Human : Hero
    {
        public Human() 
        {
            Strength += 1;
            Stamina += 1;
        }
        public Human(string name)
        {
            Name = name;
            if (name == "Dante") 
            {
                Strength *= 100;
                Stamina *= 100;
                Hp *= 1000;
                CurrentHp = Hp;
            }
        }
        public override void Attack(Entity e)
        {
            Console.WriteLine("Jackpot");
            e.TakeDamage(Dice.Throws(DiceType.D10,5));
        }

        public override void GenerateStats()
        {
            base.GenerateStats();
            Strength += 1;
            Stamina += 1;
        }
    }
}
