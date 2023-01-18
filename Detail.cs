using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasvitaslab
{
    public class Detail : Icomponent
    {
        public int Type { get; set; }
        public int Cost { get; set; }

        public int Power { get; set; }

        public Detail(int type, int cost, int power)
        {
            this.Type = type;
            this.Cost = cost;
            this.Power = power;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Тип комплектующей "+ this.Type);
            Console.WriteLine("Цена комплектующей "+ this.Cost);
            Console.WriteLine("Мощность комплектующей "+ this.Power);
            Console.WriteLine();
        }
    }
}
