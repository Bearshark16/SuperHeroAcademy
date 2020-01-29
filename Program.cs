using System;
using System.Collections.Generic;

namespace SuperHeroAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heros = new List<Hero>();

            string input;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Superhero Academy");

                if (heros.Count > 0)
                {
                    for (int i = 0; i < heros.Count; i++)
                    {
                        Console.WriteLine(heros[i].GetName());
                    }
                }
                else
                {
                    Console.WriteLine("No heros in class!");
                }

                Console.WriteLine();
                Console.WriteLine("c) Create new Hero\n");

                Console.Write("> ");
                input = Console.ReadLine();

                if (input == "c")
                {
                    input = CreateNewHero(heros);
                }

                Console.ReadLine();
            }
        }

        private static string CreateNewHero(List<Hero> heros)
        {
            string input;
            Console.Clear();
            Console.WriteLine("What type of hero?\n");
            Console.WriteLine("1)" + HeroType.Combat);
            Console.WriteLine("2)" + HeroType.Rescue);
            Console.WriteLine("3)" + HeroType.Strategic);
            Console.Write("> ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine("Name your hero?\n");
                Console.Write("> ");
                input = Console.ReadLine();
                heros.Add(new CombatHero(input));
            }
            else if (input == "2")
            {
                Console.Clear();
                Console.WriteLine("Name your hero?\n");
                Console.Write("> ");
                input = Console.ReadLine();
                heros.Add(new RescueHero(input));
            }
            else if (input == "2")
            {
                Console.Clear();
                Console.WriteLine("Name your hero?\n");
                Console.Write("> ");
                input = Console.ReadLine();
                heros.Add(new StrategicHero(input));
            }

            return input;
        }
    }
}
