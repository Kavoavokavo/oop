using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasvitaslab
{
    public class Wire : Icomponent
    {
        public int Length { get; set; }
        public int Type { get; set; }
        public int Cost { get; set; }
        public string Connector { get; set; }

        public Wire(int cost, int length, string connector)
        {
            this.Cost = cost;
            this.Length = length;
            this.Connector = connector;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Стоимость провода "+this.Cost);
            Console.WriteLine("Длина провода "+this.Length);
            Console.WriteLine("Разъём провода "+this.Connector);
            Console.WriteLine();
        }
    }    
}
