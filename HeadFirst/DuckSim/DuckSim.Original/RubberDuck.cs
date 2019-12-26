using System;

namespace DuckSim.Original
{
    internal class RubberDuck : Duck
    {
        internal override void Quak() => Console.WriteLine("Quietsch");
        internal override void Show() => Console.WriteLine("Show as a Rubber Duck");
    }
}
