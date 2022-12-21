using CalculateAreaLib.Models.Base;
using CalculateAreaLib.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaLib.Models
{
    public class TriangleParam : IParam
    {
        public double SideA { get; set; } 
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Figure figure { get; set; }
    }
}
