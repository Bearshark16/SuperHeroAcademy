using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    public enum HeroType { Combat, Rescue, Strategic };

    class Hero
    {
        public Random generator = new Random();

        protected string name;
        protected HeroType heroType;

        protected int strength;
        protected int agility;

        public string GetName()
        {
            return name;
        }

        public HeroType GetHeroType()
        {
            return heroType;
        }

        public int GetStrength()
        {
            return strength;
        }

        public int GetAgility()
        {
            return agility;
        }
    }
}
