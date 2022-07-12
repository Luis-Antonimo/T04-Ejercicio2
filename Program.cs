using System;

namespace T04Ejercicio2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Diga un nombre de persona:");
            String nombre = Console.ReadLine ();
            Console.WriteLine("Diga un nombre de ciudad:");
            String ciudad = Console.ReadLine ();
            Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);
        }
    }
}