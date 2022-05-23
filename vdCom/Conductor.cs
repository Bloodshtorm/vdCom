using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdCom
{
    
    public class Conductor
    {
        private static int lastMarker { get; set; }
        private static bool theEnd { get; set; }
        private static Train train { get; set; }
        public Conductor(Train Z)
        {
            train = Z;
        }
            
        public int Counting()
        {
            //train.TestSvetOn
            theEnd = false;
            int CountRailwayCarriage = 0;
            //проверка на первый вагон
            if (!train.TestSvetOn(CountRailwayCarriage))
                train.RailwayCarriageOnLight(CountRailwayCarriage);

            CountRailwayCarriage++;
            //знаю что так нельзя, но как иначе сэмулировать бесконечный переход по вагонам зацикленного поезда
            for (; ; )
            {
                NextRailwayCarriage(CountRailwayCarriage);
                BackRailwayCarriage(lastMarker);
                if (theEnd == true)
                    break;
            }
            return lastMarker;
        }
        private void NextRailwayCarriage(int nextCount)
        {
            for (; ; nextCount++)
            {
                Console.WriteLine("Вперед: " + nextCount);
                if (train.TestSvetOn(nextCount))
                {
                    train.RailwayCarriageOffLight(nextCount);
                    lastMarker = nextCount;
                    break;
                }
            }
        }
        private void BackRailwayCarriage(int backCount)
        {
            for (; backCount > 0; backCount--)
            {
                Console.WriteLine("Назад: " + backCount);
                
            }

            Console.WriteLine("Вагон: " + backCount + ". "+ train.TestSvetOn(backCount));
            if (backCount == 0 && !train.TestSvetOn(backCount))
            {
                //Console.WriteLine("Количество: " + lastMarker);
                theEnd = true;
            }
        }
    }
}
