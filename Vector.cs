using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoras
{
    class Vector
    {
        private List<double> _componentes;
        public List<double> Componentes
        {
            get { return _componentes; }
        }
        public int Dimension
        {
            get { return _componentes.Count; }
        }

        public Vector(List<double> argComponentes)
        {
            _componentes = argComponentes;
        }

        public double this[int i]
        {
            // Indexer declaration
            get { return _componentes[i]; }
            set { _componentes[i] = value; }
        }

        public Vector Suma(Vector vector)
        {
            if (Dimension != vector.Dimension)
                throw new Exception("Los vectores no tienen la misma dimensión.");

            List<double> componentes = new List<double>();
            for (int i = 0; i < Dimension; i++)
            {
                componentes.Add(this[i] + vector[i]);
            }
            return new Vector(componentes);
        }

        public static Vector operator +(Vector vector1, Vector vector2)
        {
            // Overloaded operator
            return vector1.Suma(vector2);
        }

        public double Promedio(params double[] numeros)
        {
            // params keyword for variable number of arguments
            double suma = 0;
            foreach (double numero in numeros)
            {
                suma += numero;
            }
            return suma / numeros.Length;
        }
    }
}
