﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Entities;
using TP3.Logic;

namespace TP3.UI
{
     class Program
    {
        static void Main(string[] args)
        {
            var ejerciciosLogic = new EjerciciosLogic();

            ejerciciosLogic.Ejecutar();

            Console.ReadLine();

        }
    }
}
