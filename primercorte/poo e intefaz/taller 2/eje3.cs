using System;
using System.Collections.Generic;
using System.Text;

namespace poo_e_intefaz.taller_2
{
    public interface IReproductor
    {
        void Play();
        void Stop();
    }

    public class Cancion : IReproductor
    {
        public string Titulo { get; set; }
        public void Play() => Console.WriteLine($"Reproduciendo canción: {Titulo} ");
        public void Stop() => Console.WriteLine("Música detenida.");
    }

    public class Podcast : IReproductor
    {
        public string Tema { get; set; }
        public void Play() => Console.WriteLine($"Escuchando podcast sobre: {Tema} ");
        public void Stop() => Console.WriteLine("Podcast detenido.");
    }

    public class eje3
    {
        public static void ejecutar()
        {
            IReproductor miReproductor;

            miReproductor = new Cancion { Titulo = "Bohemian Rhapsody" };
            miReproductor.Play();

            miReproductor = new Podcast { Tema = "Inteligencia Artificial" };
            miReproductor.Play();
        }
    }
}
