using System;
using System.Collections.Generic;
using System.Text;

namespace poo_de_la_mañana.taller
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double[] Notas { get; set; } = new double[3];

        public Estudiante(string nombre, string materia)
        {
            Nombre = nombre;
            Materia = materia;
        }

        public double CalcularPromedio()
        {
            double suma = 0;
            foreach (double nota in Notas)
            {
                suma += nota;
            }
            return suma / Notas.Length;
        }

        public string EstadoFinal()
        {
            double promedio = CalcularPromedio();
            return promedio >= 3.0 ? "Aprobado" : "Reprobado";
        }
    }

  
    public class eje3
    {
        public static void ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE PROCESAMIENTO DE NOTAS ===");

            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Materia: ");
            string materia = Console.ReadLine();

            Estudiante alumno = new Estudiante(nombre, materia);

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese la nota del Parcial {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double nota))
                {
                    alumno.Notas[i] = nota;
                }
            }

            double promedioFinal = alumno.CalcularPromedio();
            string estado = alumno.EstadoFinal();

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"RESULTADOS DE: {alumno.Nombre.ToUpper()}");
            Console.WriteLine($"MATERIA: {alumno.Materia.ToUpper()}");
            Console.WriteLine($"PROMEDIO: {promedioFinal:F2}");
            Console.WriteLine($"ESTADO: {(estado == "Aprobado" ? "¡APROBADO!" : "REPROBADO")}");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
