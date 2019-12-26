using System;
using DuckSim.Solution.Flyability;
using DuckSim.Solution.Quakability;

namespace DuckSim.Solution.Ducks
{
    internal class RubberDuck : Duck
    {
        internal RubberDuck()
        {
            Flyability = new NoFly();
            Quakability = new Quietsch();
        }
        internal override void Show() => Console.WriteLine("Show as a Rubber Duck");
    }
}
