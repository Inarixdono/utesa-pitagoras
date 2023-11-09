using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoras
{
    internal class Animal
    {
        string nombre;

        public Animal(string argNombre)
        {
            nombre = argNombre;
        }

        public virtual void Sonido()
        {
            // vitual makes this method overridable
            Console.WriteLine("El animal hace un sonido");
        }
    }

    internal class Perro : Animal // inheriance
    {        
        public Perro(string argNombre) : base(argNombre)
        {
        }

        public override void Sonido()
        {
            // polymorphism
            Console.WriteLine("El perro ladra");
        }
    }
}
