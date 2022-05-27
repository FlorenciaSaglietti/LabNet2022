using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    public abstract class TransportePublico
    {
        public string TipoTransporte { get; set; }
        public int Pasajeros { get; set; }
        public TransportePublico (int pasajeros, string tipoTransporte)
        {
            this.Pasajeros = pasajeros;
            this.TipoTransporte = tipoTransporte;
        }
        public abstract string Avanzar();
        public abstract string Detenerse();
    }
}
