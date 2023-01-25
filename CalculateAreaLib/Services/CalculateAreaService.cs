using CalculateAreaLib.Models;
using CalculateAreaLib.Models.Base;

namespace CalculateAreaLib.Services
{
    /// <summary>
    /// Service for calcule
    /// </summary>
    public class CalculateAreaService : ICalculateAreaService
    {
        public double GetFigureArea(IParam figure)
        {
            return figure.CalculateArea();
        }
    }
}
