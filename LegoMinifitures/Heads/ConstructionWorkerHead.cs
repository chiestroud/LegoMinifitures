using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifitures.Heads
{
    class ConstructionWorkerHead : HeadBase // default is internal (private to the project)
    {
        public bool HasMullet { get; set; }// inside class - default is implicitely private
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }

        public bool ToggleWorking()
        {
            WearingHardHat = !WearingHardHat; // set the property to opposite value
            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : "is not ")} wearing its hard hat.");
            return WearingHardHat;
        }

        public override void Spin()
        {
            if (NumberOfTeeth > 0)
                NumberOfTeeth -= 1;
            
            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by girder");
        }
    }
}
