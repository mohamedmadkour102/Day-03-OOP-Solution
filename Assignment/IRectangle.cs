﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}
