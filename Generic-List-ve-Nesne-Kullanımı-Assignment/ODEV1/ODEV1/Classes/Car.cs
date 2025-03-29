using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1.Classes
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double FuelConsumption { get; set; } // 100 km'de yaktığı yakıt (litre)
        public double TotalDistance { get; set; } // Toplam mesafe (km)

        public double CalculateTotalFuel()
        {
            return (FuelConsumption / 100) * TotalDistance;
        }

    }
}
