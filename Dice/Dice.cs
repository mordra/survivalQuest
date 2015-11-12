using System;

namespace ConsoleApplication1
{
    public static class Dice
    {
        private static readonly Random Random = new Random();

        public static int D(int max)
        {
            return Random.Next(max) + 1;
        }
    }
}