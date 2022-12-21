using CalculateAreaLib.Models.Base;
using CalculateAreaLib.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaLib.Models
{
    public class CircleParam : IParam
    {
        public double Radius { get; set; }
        public Figure figure { get; set; }
    }
}
