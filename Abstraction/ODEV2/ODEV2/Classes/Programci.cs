using ODEV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV2.Classes
{
    public class Programci : Calisan , ISalary
    {
        public override double maasinizNedir()
        {
            return 40000.0;
        }
        public double Salary()
        {
            double Salary1 = 0.0;
            Salary1 += maasinizNedir();
            return Salary1;
        }


    }
}
