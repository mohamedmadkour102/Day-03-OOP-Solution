using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_01
{
    internal interface IMyType
    {
         // default access modifier inside the interface is public 
        // what u can write inside the interface 

        // 1) signature for property
           int Salary { get; set; }
        // 2) signature for method
           void MyFun();
        // 3) default implemented method 

        void Print()
        {

            Console.WriteLine("c# 8.0 , .net core 3.1 2017");
        }

    }
}
