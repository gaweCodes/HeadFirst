using System;
using DuckSim.Solution.Flyability;
using DuckSim.Solution.Quakability;

namespace DuckSim.Solution.Ducks
{
    internal class MallardDuck : Duck
    {
        internal MallardDuck()
        {
            Flyability = new FlyWithWings();
            Quakability = new NormalQuak();
        }
        internal override void Show() => Console.WriteLine("Show as a Mallard Duck");
    }
}
