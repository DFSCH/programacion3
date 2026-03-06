using System;
using System.Collections.Generic;
using System.Text;
using ejerciciopasoapaso.interfaces;

namespace ejerciciopasoapaso.Modelo
{
    internal class Cancion : Ireproductor
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Año { get; set; }

        // Constructor necesario
        public Cancion(string titulo, string artista, string año)
        {
            Titulo = titulo;
            Artista = artista; 
            Año = año;
        }

        public void Play() => Console.WriteLine($"Reproduciendo: {Titulo} de {Artista} estrenada en el año {Año} ");
        public void Stop() => Console.WriteLine($"Deteniendo: {Titulo}");
    }
}
