﻿using RPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Heroes
{
    public class Dwarf : Hero
    {
        public Dwarf()
        {
            Stamina += 2;
        }
        public override void Attack(Entity e)
        {
            Console.WriteLine("Et ma hache!");
            e.TakeDamage(Dice.Throws(DiceType.D8,3));
        }
        public override void GenerateStats()
        {
            base.GenerateStats();
            Stamina += 2;
        }
    }
}
