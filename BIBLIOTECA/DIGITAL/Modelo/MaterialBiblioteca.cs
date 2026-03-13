using BIBLIOTECA.DIGITAL.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace BIBLIOTECA.DIGITAL.Modelo
{
    public abstract class MaterialBiblioteca
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }
        public TIpocategorias Categoria { get; set; }

        //protected para que solo las clases derivadas/hijas puedan acceder a este constructor
        protected MaterialBiblioteca(int id, string titulo, string autor, int anio, TIpocategorias categoria)
        {
            Id = id; Titulo = titulo; Autor = autor; AnioPublicacion = anio; Categoria = categoria;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"[{Id}] {Titulo} - {Autor} ({AnioPublicacion}) | Categoria: {Categoria}");
        }
    }
}



