using System;
using Yolk;

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
                    } 
                    else
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

        static string AddWhiteSpace(string cadena, char caracter, int whiteSpaces)
        {
            int index = cadena.IndexOf(caracter);
            string newString = cadena.Insert(index, new string(' ', whiteSpaces));
            return newString;
        }

        static void WaitForUser()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey(false);
            Console.Clear();
        }

        static void HelloWord()
        {
            Console.WriteLine("Hello, World!");
            WaitForUser();
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
            WaitForUser();
        }

        static void Operadores(int valor1, int valor2)
        {
            // Operadores aritméticos

            Console.WriteLine("Operadores aritméticos");
            Console.WriteLine($"Valor 1: {valor1}, valor 2: {valor2}");
            Console.WriteLine($"Suma: {Calcular.Sumar(valor1, valor2)}");
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
            WaitForUser();
        }

        static void EjemploIf()
        {
            int edad = 0;
            Console.Write("Ingresa tu edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }

            WaitForUser();
        }

        static void EjemploFor()
        {
            Console.Write("Ingresa el número a mostrar su tabla de multiplicación: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {
                string output = $"{num} x {i} = {num * i}";
                if (i < 10)
                {
                    Console.WriteLine(AddWhiteSpace(output, '=', 1));
                }
                else
                {
                    Console.WriteLine(output);
                }
            }

            WaitForUser();
        }

        static void EjemploForEach()
        {
            Persona jeniel = new Persona("Jeniel", 22);
            Persona dioselina = new Persona("Dioselina", 20);
            Persona gadiel = new Persona("Gadiel", 21);
            Persona carmen = new Persona("Carmen", 40);
            Persona rachel = new Persona("Rachel", 20);
            Persona joseph = new Persona("Joseph", 25);
            Persona[] personas = { jeniel, dioselina, gadiel, carmen, rachel, joseph, };

            int longitudNombre = personas.Max(persona => persona.nombre.Length);
            int longitudSeparador = longitudNombre + 12;
            string separador = new string('-', longitudSeparador);
            string[] header = { "Nombre", "Edad" };

            Console.WriteLine("Personas existentes:\n");
            Console.WriteLine(separador);
            Console.WriteLine($"| {header[0].PadRight(longitudNombre)}  | {header[1].PadRight(3)} |");

            foreach (Persona persona in personas)
            {
                string nombre = persona.nombre.PadRight(longitudNombre);
                string edad = persona.edad.ToString().PadRight(3);
                string output = $"| {nombre}  |  {edad} |";
                Console.WriteLine(separador);
                Console.WriteLine(output);
            }

            Console.WriteLine(separador);
            WaitForUser();
        }

        static void EjemploWhile()
        {
            while (true)
            {
                Console.WriteLine("Este bucle solo terminará cuando se presione la tecla \"a\".");
                Console.Write("Presione cualquier tecla para continuar...: ");
                string key = Console.ReadLine();
                if (key.ToLower() == "a")
                {
                    break;
                }
                Console.Clear();
            }

            Console.WriteLine("Bucle terminado.");
            WaitForUser();
        }

        static void EjemploTryCatch()
        {
            int num1, num2;

            Console.WriteLine("Dividir dos números...\n");
            Console.Write("Ingresa el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("De entrada solo se admiten números.");
            }

            WaitForUser();
        }
        static void Menu()
        {
            int opcion;
            String menu = "1. Hello, World!\n" +
                          "2. Saludar\n" +
                          "3. Operadores\n" +
                          "4. Ejemplo If\n" +
                          "5. Ejemplo For\n" +
                          "6. Ejemplo ForEach\n" +
                          "7. Ejemplo While\n" +
                          "8. Ejemplo Try Catch\n" +
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

                    case 4:
                        EjemploIf();
                        break;

                    case 5:
                        EjemploFor();
                        break;
                    
                    case 6:
                        EjemploForEach();
                        break;

                    case 7:
                        EjemploWhile();
                        break;

                    case 8:
                        EjemploTryCatch();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        WaitForUser();
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        WaitForUser();
                        break;
                }
            }
            while (opcion != 0);
        }

        static void Main(string[] args)
        {
            //Menu();
            Animal vaca = new Animal("Vaca");
            Perro chispita = new Perro("Chispita");
            chispita.Sonido();
            vaca.Sonido();
            WaitForUser();
        }
    }
}

/*
 
    Hacer un programa que recoja la información de clientes, registre una factura con su fecha
    y su monto total, agregar el detalle de las facturas. Y posteriormente consultar.
 
 */