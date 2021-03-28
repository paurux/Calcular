using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proyecto de cálculo");
            int operador1 = 10;
            int operador2 = 5;
            int suma = CSFunciones.Suma(operador1, operador2);
            int resta = CSFunciones.Resta(operador1, operador2);
            int multiplicacion = CSFunciones.Multiplicacion(operador1, operador2);
            int division = CSFunciones.Division(operador1, operador2);
            Console.Write("Pulsa una tecla para finalizar...");
            Console.ReadKey(true);
        }
    }
}
