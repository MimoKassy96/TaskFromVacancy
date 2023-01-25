using CalculateAreaLib.Models.Base;

namespace CalculateAreaLib.Models
{
    public class TriangleParam : IParam
    {
        private double _sideA { get; set; }
        private double _sideB { get; set; }
        private double _sideC { get; set; }

        public TriangleParam(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea ()
        {
            var p = (_sideA + _sideB + _sideC) / 2;
            return Math.Round(Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC)),2);
        }

        public bool CheckRightTriangle(TriangleParam param)
        {
            if (_sideA > _sideB && _sideA > _sideC)
                if (Math.Pow(_sideA, 2) == Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2))
                    return true;

            if (_sideB > _sideA && _sideB > _sideC)
                if (Math.Pow(_sideB, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2))
                    return true;

            if (_sideC > _sideA && _sideC > _sideB)
                if (Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2))
                    return true;

            return false;
        }
    }
}
