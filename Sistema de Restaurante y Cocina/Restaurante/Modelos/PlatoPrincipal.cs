using Sistema_de_Restaurante_y_Cocina.Restaurante.Enums;
using Sistema_de_Restaurante_y_Cocina.Restaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Restaurante_y_Cocina.Restaurante.Modelos
{
    public class PlatoPrincipal : Plato, IPreparable
    {
        public string Proteina { get; set; }

        public PlatoPrincipal(int id, string nom, decimal pre, TipoComida t, NivelDificultad d, string prot)
            : base(id, nom, pre, t, d) => Proteina = prot;

        public TimeSpan CalcularTiempoPreparacion()
        {
            int minutosadicionales = (int)Dificultad * 15;
            return TimeSpan.FromMinutes(30 + minutosadicionales);
        }

        public decimal CalcularCostoTotal() => PrecioBase * 1.10m;

        public void GenerarOrdenCocina() =>
            Console.WriteLine($"[COCINA - PRINCIPAL] {Nombre} (Prot: {Proteina}) | Tiempo: {CalcularTiempoPreparacion().TotalMinutes} min.");
    }
}
