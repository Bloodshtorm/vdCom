using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdCom
{
    /// <summary>
    /// Вагон
    /// </summary>
    public class RailwayCarriage
    {
        public bool Light { get; set; }
        public RailwayCarriage(bool light)
        {
            Light = light;
        }
    }
}
