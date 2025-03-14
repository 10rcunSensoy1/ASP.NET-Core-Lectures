using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV4.Company
{
    public class Programci : Calisan
    {
        public override double maasinizNedir()
        {
            return 40000.0;
        }
        public override string ID()
        {
            return "Ben Mehmet Ural Trendyol'da junior software developer olarak calisiyorum maasim: " + maasinizNedir();
        }
    }
}
