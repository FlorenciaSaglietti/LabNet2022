using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Logic;

namespace TP5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ejercicosLogic = new EjerciciosLogic();

            ejercicosLogic.Ejecutar();
            Console.ReadLine();
        }
    }
}
