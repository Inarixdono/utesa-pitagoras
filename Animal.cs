using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoras
{
    internal abstract class Animal
    {
        // abstract class cant be instantiated
        // abstract classes are templates for classes
        // it means a class has to implement all the methods included in the abstract class

        public string nombre;

        public Animal(string argNombre)
        {
            nombre = argNombre;
        }

        public virtual void Sonido()
        {
            // vitual makes this method overridable, polymorphic
            Console.WriteLine("El animal hace un sonido");
        }
    }

    internal class Perro : Animal 
    {
        // inheriance
        public Perro(string argNombre) : base(argNombre)
        {
        }

        public override void Sonido()
        {
            // override overrides this method, uses polymorphism
            Console.WriteLine("El perro ladra");
        }
    }

    internal class Gato : Animal
    {
        public Gato(string argNombre) : base(argNombre)
        {
        }

        public override void Sonido()
        {
            Console.WriteLine("El gato maulla");
        }
    }
}
