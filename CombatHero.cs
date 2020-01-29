using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class CombatHero : Hero
    {
        private int battleSense;

        public CombatHero(string _name)
        {
            name = _name;
            heroType = HeroType.Combat;

            strength = generator.Next(10, 21);
            agility = generator.Next(10, 16);
            battleSense = generator.Next(10, 30);
        }
    }
}
