using System;
using System.Collections.Generic;
using System.Text;

namespace poo_e_intefaz.taller_2
{
    public abstract class Mascota
    {
        public string Nombre { get; set; }
        public abstract void HacerTruco();
    }

    public class Loro : Mascota
    {
        public override void HacerTruco() => Console.WriteLine($"{Nombre} dice: ¡Quiero galleta!");
    }

    public class Gato : Mascota
    {
        public override void HacerTruco() => Console.WriteLine($"{Nombre} está amasando pan en la manta...");
    }

    public class eje1
    {
        public static void ejecutar()
        {
            List<Mascota> misMascotas = new List<Mascota> {
                new Loro { Nombre = "Paco" },
                new Gato { Nombre = "Michi" }
            };

            Console.WriteLine("Elige una mascota para ver su truco: 0. Loro, 1. Gato");
            if (int.TryParse(Console.ReadLine(), out int opcion) && opcion < misMascotas.Count)
            {
                misMascotas[opcion].HacerTruco();
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}

