using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoras
{
    static partial class Calcular
    {
        // static classes cannot be instantiated.
        // internal classes are accessible only within the current assembly.
        // static methods can only be used in static classes.
        // static methods can be called without creating an instance of the class.

        public static double Sumar(double a, double b)
        {
            return a + b;
        }

        public static double Restar(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            return a / b;
        }
    }
}
