using System;
using System.Collections.Generic;

namespace DuckSim.Original
{
    internal class Program
    {
        private static void Main()
        {
            var ducks = new List<Duck> {new MallardDuck(), new MoorDuck(), new RubberDuck()};
            ducks.ForEach(d =>
            {
                d.Show();
                d.Quak();
                d.Swim();
            });
            Console.ReadLine();
        }
    }
}
