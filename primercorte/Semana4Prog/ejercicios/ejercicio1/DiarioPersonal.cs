using System;
using System.Collections.Generic;
using System.Text;

namespace Semana4Prog.ejercicios.ejercicio1
{
    public class DiarioPersonal
    {

        static string path = "diario.txt";

        public static void Ejecutar()
        {
            Console.WriteLine("--- MI DIARIO PERSONAL ---");

            if (File.Exists(path))
            {
                // Leemos todas las líneas en un arreglo de strings
                string[] todasLasLineas = File.ReadAllLines(path);
                int total = todasLasLineas.Length;

                Console.WriteLine("Últimas entradas:");

                // Calculamos desde dónde empezar: 
                // Si hay menos de 3, empezamos desde 0. Si hay más, restamos 3 al total.
                int inicio = Math.Max(0, total - 3);

                for (int i = inicio; i < total; i++)
                {
                    Console.WriteLine(todasLasLineas[i]);
                }
                Console.WriteLine("--------------------------");
            }

            // Resto del código para guardar la entrada...
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("¿Qué piensas hoy?: ");
            string mensaje = Console.ReadLine();

            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string entrada = $"[{fecha}] - {nombre.ToUpper()}: {mensaje}{Environment.NewLine}";

            File.AppendAllText(path, entrada);
        }
    }
}
