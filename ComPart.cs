using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasvitaslab
{
    public class ComPart : Detail
    {
        public int WorkTemperature { get; set; }
        public ComPart(int type, int cost, int power, int worktemperature) : base(type, cost, power)
        {
            this.WorkTemperature = worktemperature;
        }

        public override void PrintInfo ()
        {
            Console.WriteLine("Тип компьютерной комплектующей "+this.Type);
            Console.WriteLine("Цена компьютерной комплектующей "+this.Cost);
            Console.WriteLine("Мощность компьютерной комплектующей " + this.Power);
            Console.WriteLine("Рабочая температура компьютерной комплектующей " + this.WorkTemperature);
            Console.WriteLine();
        }
    }
}
