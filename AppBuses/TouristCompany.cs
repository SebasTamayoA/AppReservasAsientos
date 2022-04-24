using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBuses
{
    internal class TouristCompany
    {
        public string Nit { get; set; } // Nit de la compañía
        public string CompanyName { get; set; } // Nombre de la compañía
        public string Address { get; set; } // Dirección de la compañía
        public string Phone { get; set; } // Teléfono de la compañía
        public Bus[] Buses { get; set; } // array de buses 
        public Driver[] Drivers { get; set; } // array de conductores 
        public Passenger[] Passengers { get; set; }  // array de pasajeros


    }
}
