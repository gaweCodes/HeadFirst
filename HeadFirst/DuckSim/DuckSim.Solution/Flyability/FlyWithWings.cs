using System;

namespace DuckSim.Solution.Flyability
{
    public class FlyWithWings : IFlyability
    {
        public void Fly() => Console.WriteLine("I fly with my wings!");
    }
}
