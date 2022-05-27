using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    public class Taxi : TransportePublico
    {
        public Taxi (int pasajeros) :base(pasajeros, "Taxi") { }
        public override string Avanzar()
        {
            return "Avanza";
        }

        public override string Detenerse()
        {
            return "Se detiene";
        }
    }
}
