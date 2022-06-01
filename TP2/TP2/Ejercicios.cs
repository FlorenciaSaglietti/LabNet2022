using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Ejercicios
    {
        public void Ejecutar()
        {
            var logic = new Logic();
            var division = new División();

            Console.WriteLine("Seleccione que ejercicio quiere probar (1-4): ");

            var seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    this.EjercicioUno(division);
                    break;
                case 2:
                    this.EjercicioDos(division);
                    break;
                case 3:
                    this.EjercicioTres(logic);
                    break;
                case 4:
                    this.EjercicioCuatro(logic);
                    break;
            }
        }

        private void EjercicioCuatro(Logic logic)
        {
            Console.WriteLine("Ejercicio 4");
            try
            {
                logic.DevuelveCE("Esta es la excepcion");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void EjercicioTres(Logic logic)
        {
            Console.WriteLine("Ejercicio 3");
            try
            {
                logic.DevuelveEx();
            }

            catch (Exception ex)
            {
                Console.WriteLine("el mensaje de la excepcion es: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("el tipo de la excepcion es: ");
                Console.WriteLine(ex.GetType());
            }
        }

        private void EjercicioDos(División division)
        {
            Console.WriteLine("Ejercicio 2");
            try
            {
                Console.WriteLine("ingrese un numero: ");
                decimal Dividendo = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("ingrese un numero: ");
                decimal Divisor = Convert.ToDecimal(Console.ReadLine());

                var resultado = division.Dividir(Dividendo, Divisor);
                Console.WriteLine("El resultado es: " + resultado.ToString());
            }
            catch (DivideByZeroException divEx)
            {
                Console.WriteLine(divEx.Message);
                Console.WriteLine("Solo Chuck Norris divide por cero!");
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
                Console.WriteLine(formatEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void EjercicioUno(División division)
        {
            Console.WriteLine("Ejercicio 1");
            decimal Numero;
            try
            {
                Console.WriteLine("ingrese un numero: ");
                Numero = Convert.ToDecimal(Console.ReadLine());
                division.Dividir(Numero);
                Console.WriteLine("Operacion finalizada");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Operacion finalizada");
            }
        }
    }
}
