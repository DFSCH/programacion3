using System;
using Reto1;

class program
{
    static void Main()
    {
        List<Amigo> listaAmigo = new List<Amigo>();
        string rutaArchivo = "cumple.txt";
        Console.WriteLine("registro de cupleaños");

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"amigo {i}");
            Console.WriteLine("nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("fecha de nacimiento (dd/MM/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
            {
                listaAmigo.Add(new Amigo(nombre, fecha));
            }
            else
            {
                Console.WriteLine("formato de fecha invalido. intente nuevamente.");
                i--;
            }
        }

        try
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                Console.WriteLine("Ressultados:");
                foreach (var amigo in listaAmigo)
                {
                    int diasfaltantes = amigo.CalcularDiasParaCumpleaños();
                    Console.WriteLine($"{amigo.Nombre} le faltan {diasfaltantes} dias para su cumpleaños.");
                    writer.WriteLine($"{amigo.Nombre}-{amigo.FechaNacimiento:dd/MM/yyyy}-faltan {diasfaltantes}.");
                }
            }
            Console.WriteLine($"los datos han sido guardados en {rutaArchivo}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"error al guardar el archivo: {ex.Message}");

        }
    }
}
