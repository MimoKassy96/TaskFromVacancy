using CalculateAreaLib.Models.Base;

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
