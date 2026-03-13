using Sistema_de_Restaurante_y_Cocina.Restaurante.Enums;
using Sistema_de_Restaurante_y_Cocina.Restaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Restaurante_y_Cocina.Restaurante.Modelos
{
    public class Postre : Plato, IPreparable
    {
        public bool ContieneLactosa { get; set; }

        public Postre(int id, string nom, decimal pre, TipoComida t, NivelDificultad d, bool lactosa)
            : base(id, nom, pre, t, d) => ContieneLactosa = lactosa;

        public TimeSpan CalcularTiempoPreparacion() => TimeSpan.FromMinutes(25 + (ContieneLactosa ? 5 : 0));

        public decimal CalcularCostoTotal() => PrecioBase;

        public void GenerarOrdenCocina() =>
            Console.WriteLine($"[COCINA - POSTRE] {Nombre} | Lactosa: {(ContieneLactosa ? "Sí" : "No")}");
    }
}
