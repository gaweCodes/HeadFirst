using System;
using DuckSim.Solution.Flyability;
using DuckSim.Solution.Quakability;

namespace DuckSim.Solution.Ducks
{
    internal abstract class Duck
    {
        internal IFlyability Flyability { get; set; }
        internal IQuakability Quakability  { get; set; }
        internal void DoFly() => Flyability.Fly();
        internal void DoQuak() => Quakability.Quak();
        internal void Swim() => Console.WriteLine("Swim");
        internal abstract void Show();
    }
}
