using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasvitaslab
{
    public interface Icomponent
    {
        int Cost { get; set; }
        void PrintInfo();
    }

}
