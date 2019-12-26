using System;
using System.Collections.Generic;
using DuckSim.Solution.Ducks;
using DuckSim.Solution.Flyability;

namespace DuckSim.Solution
{
    internal class Program
    {
        private static void Main()
        {
            var ducks = new List<Duck> { new MallardDuck(), new MoorDuck(), new RubberDuck(), new WoodDuck(), new FuturisticDuck() };
            ducks.ForEach(d =>
            {
                d.Show();
                d.DoFly();
                d.Swim();
                d.DoQuak();
                Console.WriteLine();
            });

            
            ducks[^1].Flyability = new FlyWithRocket();
            Console.WriteLine("Round 2");
            ducks.ForEach(d =>
            {
                d.Show();
                d.DoFly();
                d.Swim();
                d.DoQuak();
                Console.WriteLine();
            });
        }
    }
}
