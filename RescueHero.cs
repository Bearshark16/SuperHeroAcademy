using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class RescueHero : Hero
    {
        private int protection;

        public RescueHero(string _name)
        {
            name = _name;
            heroType = HeroType.Rescue;

            strength = generator.Next(10, 16);
            agility = generator.Next(10, 21);
            protection = generator.Next(10, 30);
        }
    }
}
