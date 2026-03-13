using Sistema_de_Restaurante_y_Cocina.Restaurante.Enums;
using Sistema_de_Restaurante_y_Cocina.Restaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Restaurante_y_Cocina.Restaurante.Modelos
{
    public class Entrada : Plato, IPreparable
    {
        public bool EsFria { get; set; }
        public int Porciones { get; set; }

        public Entrada(int id, string nom, decimal pre, TipoComida t, NivelDificultad d, bool fria)
            : base(id, nom, pre, t, d) => EsFria = fria;

        public TimeSpan CalcularTiempoPreparacion() => TimeSpan.FromMinutes(EsFria ? 10 : 20);

        public decimal CalcularCostoTotal() => PrecioBase;

        public void GenerarOrdenCocina() =>
            Console.WriteLine($"[COCINA - ENTRADA] {Nombre} | Tiempo Est.: {CalcularTiempoPreparacion().TotalMinutes} min.");
    }
}
