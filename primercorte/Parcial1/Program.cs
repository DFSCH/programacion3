using System;
using Parcial1.Parciales1.micasa;
//using Parcial1.Parciales1.FerreteriaPro;

namespace Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ DE EJERCICIOS - SEMANA 4 ===");
                Console.WriteLine("1. Ferreteria pro");
                Console.WriteLine("2. Mi casa");
                Console.WriteLine("3. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                   // case "1":
                    //    Ferreteria.Ejecutar();
                     //   break;
                    case "2":
                        MiCasa.guardar_fecha();
                        break;
                    case "3":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para intentar de nuevo.");
                        break;
                }

                if (opcion != "3")
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }
    }
}