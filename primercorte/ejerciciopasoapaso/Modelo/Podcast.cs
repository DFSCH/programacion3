using System;
using System.Collections.Generic;
using System.Text;
using ejerciciopasoapaso.interfaces;

namespace ejerciciopasoapaso.Modelo
{
    internal class Podcast : Ireproductor
    {
        public string Titulo { get; set; }
        public string Creador { get; set; }
        public string Episodio { get; set; }

        public Podcast(string titulo, string creador, string episodio)
        {
            Titulo = titulo;
            Creador = creador;
            Episodio = episodio;
        }

        public void Play() => Console.WriteLine($"Podcast: {Titulo} por {Creador} episodio {Episodio}");
        public void Stop() => Console.WriteLine($"Deteniendo podcast: {Titulo}");
    }
}
