using System;

namespace SpaceInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Invader invader = new("#");
            Space s = new(10, 10, invader);
            s.tirer(10);
        }
    }
}
