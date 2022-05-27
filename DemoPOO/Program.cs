using System;

namespace DemoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ColeccionTransporte = new List<TransportePublico>
            {
                new Omnibus (100),
                new Omnibus (70),
                new Omnibus (50),
                new Omnibus (20),
                new Omnibus (10),
                new Taxi (5),
                new Taxi (4),
                new Taxi (3),
                new Taxi (2),
                new Taxi (1)

             };
            foreach (var c in ColeccionTransporte)
            {
                Console.WriteLine (c.TipoTransporte + ": cantidad de pasajeros " + c.Pasajeros);
            }
        }
    }
}