using System;
using DuckSim.Solution.Flyability;
using DuckSim.Solution.Quakability;

namespace DuckSim.Solution.Ducks
{
    internal class MoorDuck : Duck
    {
        internal MoorDuck()
        {
            Flyability = new FlyWithWings();
            Quakability = new NormalQuak();
        }
        internal override void Show() => Console.WriteLine("Show as a Moor Duck");
    }
}
