using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBuses
{
    public class Passenger : Person
    {
        public String Seat { get; set; } // silla
        public int Row { get; set; }
        public int Colum { get; set; }
        public int ReservationNumber { get; set; } // Número de reserva
        public String BusPlate { get; set;}
    }
}
