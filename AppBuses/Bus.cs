using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBuses
{
    public class Bus
    {
        public string BusPlate { get; set; } // placa del bus
        public string BusType { get; set; } // tipo de bus 
        public int[,] BusCapacity { get; set; } // capacidad del bus como matriz de asientos
        public int BusCapacity1 { get; set; }
        public Driver Driver { get; set; } // conductor del bus        
        public Passenger[] Passengers { get; set; } // array de pasajeros


    }
}
