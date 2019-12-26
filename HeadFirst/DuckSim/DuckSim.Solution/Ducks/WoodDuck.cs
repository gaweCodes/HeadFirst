using System;
using DuckSim.Solution.Flyability;
using DuckSim.Solution.Quakability;

namespace DuckSim.Solution.Ducks
{
    internal class WoodDuck : Duck
    {
        internal WoodDuck()
        {
            Flyability = new NoFly();
            Quakability = new NoQuak();
        }
        internal override void Show() => Console.WriteLine("Show as a Wood Duck");
    }
}
