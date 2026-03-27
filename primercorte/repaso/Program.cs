using repaso.ejercicios;

namespace repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Menú de Repaso ---");
            Console.WriteLine("Seleccione un ejercicio (1-5):");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    eje1.ejecutar();
                    break;
                case "2":
                    eje2.ejecutar();
                    break;
                case "3":
                    eje3.ejecutar();
                    break;
                case "4":
                    eje4.ejecutar();
                    break;
                case "5":
                    eje5.ejecutar();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}