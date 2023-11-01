namespace Pitagoras
{ 
    class Program
    {
        class Persona
        {
            public string nombre;
            private int Edad = -1;
            public int edad
            {
                get
                {
                    return Edad;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("La edad no puede ser negativa");
                        Edad = 0;
                    } else
                    {
                        Edad = value;
                    }
                }
            }
            
            public Persona()
            {
                nombre = string.Empty;
            }

            public Persona (string argNombre, int argEdad)
            {
                nombre = argNombre;
                edad = argEdad;
            }

            public void setNombre()
            {
                Console.Write("Hola, ¿Como te llamas?: ");
                nombre = Console.ReadLine();
            }

            public void setEdad()
            {
                Console.Write("Ingresa tu edad: ");
                edad = int.Parse(Console.ReadLine());
            }
        }

        static void HelloWord()
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey(false);
            Console.Clear();
        }

        static void Saludar()
        {
            Persona jeniel = new Persona();

            if (jeniel.nombre == string.Empty && jeniel.edad == -1)
            {
                jeniel.setNombre();
                jeniel.setEdad();
            }

            Console.WriteLine($"Hola, {jeniel.nombre}, tienes {jeniel.edad} años de edad.");            
            Console.ReadKey(false);
            Console.Clear();
        }

        static void Operadores(int valor1, int valor2)
        {
            // Operadores aritméticos

            Console.WriteLine("Operadores aritméticos");
            Console.WriteLine($"Valor 1: {valor1}, valor 2: {valor2}");
            Console.WriteLine($"Suma: {valor1 + valor2}");
            Console.WriteLine($"Resta: {valor1 - valor2}");
            Console.WriteLine($"Multiplicación: {valor1 * valor2}");

            if (valor2 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            else
            {
                Console.WriteLine($"División: {(double)valor1 / (double)valor2}");
                Console.WriteLine($"Residuo: {(double)valor1 % (double)valor2}");
            }

            valor1++;
            valor2--;
            Console.WriteLine($"Incremento del valor 1: {valor1}");
            Console.WriteLine($"Decremento del valor 2: {valor2}");


            // Operadores de relación

            Console.WriteLine("\nOperadores de relación");
            Console.WriteLine($"¿{valor1} es mayor a {valor2}?: {valor1 > valor2}");
            Console.WriteLine($"¿{valor1} es menor a {valor2}?: {valor1 < valor2}");
            Console.WriteLine($"¿{valor1} es mayor o igual a {valor2}?: {valor1 >= valor2}");
            Console.WriteLine($"¿{valor1} es menor o igual a {valor2}?: {valor1 <= valor2}");
            Console.WriteLine($"¿{valor1} es igual a {valor2}?: {valor1 == valor2}");
            Console.WriteLine($"¿{valor1} es diferente de {valor2}?: {valor1 != valor2}"); 
            Console.WriteLine($"¿{valor1} es entero?: {valor1 is int}");
            Console.WriteLine($"¿{valor2} es una cadena de caracteres?: {valor2 is string}");

            // Operadores lógicos

            Console.WriteLine("\nOperadores lógicos");
            Console.WriteLine($"true and true: {true && true}");
            Console.WriteLine($"true or false: {true || false}");
            Console.WriteLine($"not true: {!true}");
            Console.WriteLine($"true ir false: {true ^ false}");
            Console.ReadKey(false);
            Console.Clear();
        }

        static void Menu()
        {
            int opcion;
            String menu = "1. Hello, World!\n" +
                          "2. Saludar\n" +
                          "3. Operadores\n" +
                          "0. Salir\n";

            do 
            {
                Console.WriteLine(menu);
                Console.Write("Elija una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        HelloWord();
                        break;

                    case 2:
                        Saludar();
                        break;

                    case 3:
                        Operadores(10, 5);
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
            while (opcion != 0);
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}