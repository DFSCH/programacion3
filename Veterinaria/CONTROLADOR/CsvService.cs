using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria.SERVICIO
{
    public static class CsvService
    {
        public static void GuardarLinea(string archivo, string linea)
        {
            // Asegura que el archivo exista antes de escribir
            if (!File.Exists(archivo))
            {
                File.WriteAllText(archivo, "ID,Col1,Col2,Col3...\n");
            }
            File.AppendAllLines(archivo, new[] { linea });
        }

        public static List<string[]> LeerTodo(string archivo)
        {
            if (!File.Exists(archivo)) return new List<string[]>();
            return File.ReadAllLines(archivo).Skip(1) // Saltamos encabezado
                       .Select(linea => linea.Split(',')).ToList();
        }
    }
}
