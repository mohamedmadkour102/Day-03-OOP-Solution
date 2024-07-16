using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_01
{
    internal class MyType : IMyType
    {
        public int Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello world");
        }
    }
}
