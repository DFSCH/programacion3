using System;
using System.Collections.Generic;
using System.Text;

namespace Semana4Prog.ejercicios.ejercicio2
{
    public class GestorDeContacto
    {
        class Contacto
        {
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }

            public string ToCSV() => $"{Nombre};{Telefono};{Correo.Trim().ToLower()}";
        }

        // Lógica de guardado
        public static void GuardarContacto()
        {
            string archivo = "contactos.csv";
            Contacto nuevo = new Contacto();

            Console.Write("Nombre: "); nuevo.Nombre = Console.ReadLine();
            Console.Write("Teléfono: "); nuevo.Telefono = Console.ReadLine();
            Console.Write("Correo: "); nuevo.Correo = Console.ReadLine();

            File.AppendAllLines(archivo, new[] { nuevo.ToCSV() });

            Console.Write("\n¿Desea listar los contactos? (s/n): ");
            if (Console.ReadLine().ToLower() == "s")
            {
                Console.WriteLine("\n{0,-15} | {1,-12} | {2,-20}", "Nombre", "Teléfono", "Correo");
                Console.WriteLine(new string('-', 55));

                foreach (var linea in File.ReadAllLines(archivo))
                {
                    var datos = linea.Split(';');
                    Console.WriteLine("{0,-15} | {1,-12} | {2,-20}", datos[0], datos[1], datos[2]);
                }
            }
        }
    }
}
