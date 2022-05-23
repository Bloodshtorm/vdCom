using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdCom
{
    /// <summary>
    /// Вагон с рандомным режимом света
    /// </summary>
    public class RailwayCarriageLightOnOff : RailwayCarriage
    {
        //public static Random randomLight = new Random();
        public static Random randomLight = new Random();
        public RailwayCarriageLightOnOff() : base(Convert.ToBoolean(randomLight.Next(0, 2)))
        {
            //Console.WriteLine(randomLight.Next(0,2));
            //Console.WriteLine(Convert.ToBoolean(randomLight.Next(0,2)));
        }
    }
}
