using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_03
{
    class Airplane : Vehicle, IMovable, IFlyable
    {
        public void Backword() // Implicitly 
        {
            Console.WriteLine("Airplane move back on ground");
        }

        void IMovable.Forward() // Explicitly 
        {
            Console.WriteLine("Airplane move forw on ground");

        }

        void IFlyable.Forward() // Explicitly
        {
            Console.WriteLine("Airplane move forw on Air");

        }
    }
}
