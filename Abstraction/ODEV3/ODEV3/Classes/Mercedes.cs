using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV3.Classes
{
    public class Mercedes : Cars
    {
        public override double yakitBilgi()
        {
            return 70.0;
        }
        public double fuel()
        {
            double fuel1 = 0.0;
            fuel1 += yakitBilgi();
            return fuel1;
        }
    }
}
