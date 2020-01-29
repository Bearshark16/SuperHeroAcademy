using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class StrategicHero : Hero
    {
        private int tacticalAnalysis;

        public StrategicHero(string _name)
        {
            name = _name;
            heroType = HeroType.Strategic;

            strength = generator.Next(10, 15);
            agility = generator.Next(10, 15);
            tacticalAnalysis = generator.Next(10, 30);
        }
    }
}
