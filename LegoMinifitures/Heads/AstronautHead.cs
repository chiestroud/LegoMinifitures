using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifitures.Heads
{
    class AstronautHead : HeadBase
    {
        public bool WearingHelmet { get; set; }
        public FacialHair FacialHair { get; set; }

        public override void SayHi()
        {
            base.SayHi(); // interact directly from the base file
            Console.WriteLine("Major Tom to Groud Control...");
        }

        public override void Spin()
        {
            Console.WriteLine("The Astronaut head spins to tak in the beauty of the cosmos...");
        }

        public void Shave()
        {
            Console.WriteLine($"The Astronaut head shaves its {FacialHair}.");
            FacialHair = FacialHair.None;
        }
    }
}
