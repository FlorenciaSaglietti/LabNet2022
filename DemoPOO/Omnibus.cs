using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros, "Omnibus" ) { }
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
