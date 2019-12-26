using System;

namespace DuckSim.Solution.Flyability
{
    public class FlyWithRocket : IFlyability
    {
        public void Fly() => Console.WriteLine("Flying like a rocket!");
    }
}
