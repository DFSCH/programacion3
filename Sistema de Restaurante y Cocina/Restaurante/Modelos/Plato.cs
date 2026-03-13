using Sistema_de_Restaurante_y_Cocina.Restaurante.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Restaurante_y_Cocina.Restaurante.Modelos
{
    public abstract partial class Plato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoComida Tipo { get; set; }
        public NivelDificultad Dificultad { get; set; }

        protected Plato(int id, string nombre, decimal precio, TipoComida tipo, NivelDificultad dificultad)
        {
            Id = id;
            Nombre = nombre;
            PrecioBase = precio;
            Tipo = tipo;
            Dificultad = dificultad;
        }
    }

    public abstract partial class Plato
    {
        public virtual void MostrarInformacionNutricional()
        {
            Console.WriteLine($"Plato: {Nombre} | Categoría: {Tipo} | Dificultad: {Dificultad}");
        }
    }
}
