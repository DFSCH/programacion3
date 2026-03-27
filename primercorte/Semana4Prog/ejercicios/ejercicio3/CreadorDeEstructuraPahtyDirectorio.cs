using System;
using System.Collections.Generic;
using System.Text;

namespace Semana4Prog.ejercicios.ejercicio3
{
    public class CreadorDeEstructuraPahtyDirectorio
    {
        public static void CrearEstructura()
        {
            Console.Write("Nombre del Proyecto: ");
            string nombreProy = Console.ReadLine();

            try
            {
                // Crear carpetas
                Directory.CreateDirectory(nombreProy);
                string[] subCarpetas = { "documentos", "imagenes", "codigo" };

                foreach (var sub in subCarpetas)
                    Directory.CreateDirectory(Path.Combine(nombreProy, sub));

                // Crear Readme
                Console.Write("Descripción del proyecto: ");
                string desc = Console.ReadLine();

                string rutaReadme = Path.Combine(nombreProy, "documentos", "readme.txt");
                File.WriteAllText(rutaReadme, desc);

                Console.WriteLine($"\nProyecto creado exitosamente en:");
                Console.WriteLine(Path.GetFullPath(nombreProy));
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de disco: {ex.Message}");
            }
        }
    }
}
