using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifitures.Heads
{
    abstract class HeadBase // abstract - you cannot instantiate you can only inherit
    {
        public LegoColor Color { get; set; }
        public virtual void SayHi() // this method can be changed (overridden) from class that inherits this.
        {
            Console.WriteLine("Hi.");
        }

        public abstract void Spin(); // this means that Spin needs to exist in each class
    }
}
