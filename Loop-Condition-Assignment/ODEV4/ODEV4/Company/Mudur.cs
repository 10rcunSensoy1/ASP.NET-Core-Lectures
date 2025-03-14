using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV4.Company
{
    public class Mudur : Calisan
    {
        public override double maasinizNedir()
        {
            return 60000.0;
        }
        public override string ID()
        {
            return "Ben Kerem Altan Trendyol'da Mudurum maasim: " + maasinizNedir();
        }
    }
}
