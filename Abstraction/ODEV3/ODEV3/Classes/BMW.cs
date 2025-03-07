using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV3.Classes
{
    public class BMW : Cars
    {
        public override double yakitBilgi()
        {
            return 80.0;
        }
        public double fuel()
        {
            double fuel1 = 0.0;
            fuel1 += yakitBilgi();
            return fuel1;
        }
    }
}
