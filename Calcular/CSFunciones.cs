using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    class CSFunciones
    {
        public static int Suma(int operador1, int operador2)
        {
            int suma = operador1 + operador2;
            return (suma);
        }
        public static int Multiplicacion(int operador1, int operador2)
        {
            int multiplicacion = operador1 * operador2;
            return (multiplicacion);
        }

        //Editado por Adriela
        public static int Resta(int operador1, int operador2)
        {
            int resta = operador1 - operador2;
            return (resta);
        }

        //Editado por Adriela
        public static int Division(int operador1, int operador2)
        {
            int division = operador1 / operador2;
            return (division);
        }
        public static void MostrarResultados(int operador1, int operador2, int suma, int resta, int multiplicacion, int division)
        {
            Console.WriteLine("El resultado de la suma {0} y {1} es {2}", operador1, operador2, suma); // Modificado por Paula
            Console.WriteLine("El resultado de la multiplicacion {0} y {1} es {2}", operador1, operador2, multiplicacion); // Modificado por Paula
            Console.WriteLine("El resultado de la multiplicacion {0} y {1} es {2}", operador1, operador2, resta); // Modificado por Adriela
            Console.WriteLine("El resultado de la multiplicacion {0} y {1} es {2}", operador1, operador2, division); // Modificado por Adriela
        }
    }
}
