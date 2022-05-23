using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdCom
{
    
    public class Train
    {
        private static List<RailwayCarriageLightOnOff> RailwayCarriages { get; set; }

        public Train(int QuantityRailwayCarriage)
        {
            RailwayCarriages = new List<RailwayCarriageLightOnOff>();
            
            for (int z=0; z< QuantityRailwayCarriage; z++)
            {
                RailwayCarriages.Add(new RailwayCarriageLightOnOff());
            }
            //первый и последний вагон это один и тот же
            //(иначе не придумал как реализовать циклично замкнутое N-ное количество объектов)
            RailwayCarriages.Add(RailwayCarriages[0]);

            Console.WriteLine("Сгенерирован поезд с рандомным количеством вагонов, рандомное значение: " + QuantityRailwayCarriage);
        }
        //просто возвращаю количество вагонов для удобства
        public int Count()
        {
            return RailwayCarriages.Count();
        }

        public void RailwayCarriageOffLight(int nubmer)
        {
            //провверка на последний вагон
            if (nubmer == RailwayCarriages.Count)
            {
                RailwayCarriages[0].Light = false;
            }
            
            RailwayCarriages[nubmer].Light = false;
            Console.WriteLine("Вагон: "+nubmer+". Выключаем свет");
        }

        public void RailwayCarriageOnLight(int nubmer)
        {
            //провверка на последний вагон
            if (nubmer == RailwayCarriages.Count)
            {
                RailwayCarriages[0].Light = true;
            }

            RailwayCarriages[nubmer].Light = true;
            Console.WriteLine("Вагон: " + nubmer + ". Включаем свет");
        }

        public bool TestSvetOn(int nubmer)
        {
            try
            {
                return RailwayCarriages[nubmer].Light;
            }
            catch
            {
                Console.WriteLine("Ошибка");
                return false;
            }
            
        }
    }
}
