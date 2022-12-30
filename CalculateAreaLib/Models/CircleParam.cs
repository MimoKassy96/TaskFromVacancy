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
        private double _radius { get; set; }

        public CircleParam(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }
    }
}
