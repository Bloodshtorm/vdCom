using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdCom
{
    class Program
    {
        static void Main(string[] args)
        {
            //тут можно задать любой ограничитель, просто 55-оптимально для примера
            Train tr = new Train(new Random().Next(2, 55));
            
            Conductor con = new Conductor(tr);
            Console.WriteLine("Создаем экземпляр класса Кондуктор(наблюдатель)");
            Console.WriteLine("Количество вагонов: " + con.Counting().ToString());

            Console.ReadLine();
        }
    }
}
