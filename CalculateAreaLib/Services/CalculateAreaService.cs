using CalculateAreaLib.Models;
using CalculateAreaLib.Models.Base;
using CalculateAreaLib.Models.Enums;

namespace CalculateAreaLib.Services
{
    /// <summary>
    /// Service for calcule
    /// </summary>
    public class CalculateAreaService
    {
        public double CalculateAreaCircle(CircleParam param)
        {
            var area = Math.PI * Math.Pow(param.Radius, 2);
            return Math.Round(area,2);
        }

        public double CheckFigure(IParam param)
        {
            if (param.figure == Figure.Circle)
            {
                var circle = new CircleParam();
                circle = (CircleParam)param;
                return CalculateAreaCircle(circle);
            }
            else if(param.figure == Figure.Trialnge)
            {
                var triangle = new TriangleParam();
                triangle = (TriangleParam)param;
                return CalculateAreaTriangle(triangle);
            }
            //else if(param.figure == next figure)
            //...
            throw new NotImplementedException();
        }

        public double CalculateAreaTriangle(TriangleParam param)
        {
            var p = (param.SideA + param.SideB + param.SideC) / 2;
            var area = Math.Sqrt(p*(p-param.SideA)*(p-param.SideB)*(p-param.SideC));
            return area;
        }

        public bool CheckRightTriangle(TriangleParam param)
        {
            if (param.SideA > param.SideB && param.SideA > param.SideC)
                if (Math.Pow(param.SideA, 2) == Math.Pow(param.SideB, 2) + Math.Pow(param.SideC, 2))
                    return true;

            if (param.SideB > param.SideA && param.SideB > param.SideC)
                if (Math.Pow(param.SideB, 2) == Math.Pow(param.SideA, 2) + Math.Pow(param.SideC, 2))
                    return true;

            if (param.SideC > param.SideA && param.SideC > param.SideB)
                if (Math.Pow(param.SideC, 2) == Math.Pow(param.SideA, 2) + Math.Pow(param.SideB, 2))
                    return true;

            return false;
        }
    }
}
