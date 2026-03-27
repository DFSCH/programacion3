using Semana4Prog.ejercicios.ejercicio1;
using Semana4Prog.ejercicios.ejercicio2;
using Semana4Prog.ejercicios.ejercicio3;

namespace Semana4Prog
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
                Console.WriteLine("2. mi casa");
                Console.WriteLine("3. salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Asegúrate de que el método en DiarioPersonal sea 'public static void Ejecutar()'
                        DiarioPersonal.Ejecutar();
                        break;
                    case "2":
                        GestorDeContacto.GuardarContacto();
                        break;
                    case "3":
                        CreadorDeEstructuraPahtyDirectorio.CrearEstructura();
                        break;
                    case "4":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para intentar de nuevo.");
                        break;
                }

                if (opcion != "4")
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }

    }

}