using System;

namespace DuckSim.Solution.Quakability
{
    public class NormalQuak : IQuakability
    {
        public void Quak() => Console.WriteLine("I quak normal!");
    }
}
