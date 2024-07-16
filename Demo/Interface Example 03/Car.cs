using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_03
{
    internal class Car : Vehicle, IMovable
    {
        public void Backword()
        {
            throw new NotImplementedException();
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }
    }
}
