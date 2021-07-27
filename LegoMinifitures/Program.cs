using LegoMinifitures.Heads;
using System;
using System.Collections.Generic;

namespace LegoMinifitures
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerHead = new ConstructionWorkerHead();
            workerHead.Color = LegoColor.Brown;
            workerHead.SayHi();

            var batmanHead = new BatmanHead();
            batmanHead.SayHi();

            var astronautHead = new AstronautHead();
            astronautHead.SayHi();

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };
            // you can put everything in one collection if everything is inheriting from one particular class

            // if everything has "is a" relationship. The ability to treat dissimilar things with similarities
            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }
        }
    }
}
