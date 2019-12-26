using System;
using DuckSim.Solution.Flyability;
using DuckSim.Solution.Quakability;

namespace DuckSim.Solution.Ducks
{
    internal class FuturisticDuck : Duck
    {
        internal FuturisticDuck()
        {
            Flyability = new NoFly();
            Quakability = new NormalQuak();
        }
        internal override void Show() => Console.WriteLine("Show as a Futuristic Duck");
    }
}
