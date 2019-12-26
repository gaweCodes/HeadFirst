using System;

namespace DuckSim.Original
{
    internal abstract class Duck
    {
        internal void Swim() => Console.WriteLine("Swim");
        internal virtual void Quak() => Console.WriteLine("Quak");
        internal abstract void Show();
    }
}
