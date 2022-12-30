using CalculateAreaLib.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaLib.Services
{
    public interface ICalculateAreaService
    {
        public double GetFigureArea(IParam figure);
    }
}
