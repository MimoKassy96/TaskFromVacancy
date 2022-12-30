using CalculateAreaLib.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaLib.Models.Base
{
    /// <summary>
    /// IParam its abstraction for figure parametrs
    /// </summary>
    public interface IParam
    {
        public double CalculateArea();
    }
}
