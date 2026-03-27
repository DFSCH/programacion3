using BIBLIOTECA.DIGITAL.Enums;
using BIBLIOTECA.DIGITAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIBLIOTECA.DIGITAL.Modelo
{
    public class AudioLibro : MaterialBiblioteca, IPrestable
    {
        public TimeSpan Duracion { get; set; }
        public string Narrador { get; set; }

        public AudioLibro(int id, string t, string a, int anio, TIpocategorias c, TimeSpan dur, string nar)
            : base(id, t, a, anio, c)
        {
            Duracion = dur; Narrador = nar;
        }

        public DateTime CalcularFechaDevolucion() => DateTime.Now.AddDays(7); // Menos días por ser digital

        public void GenerarComprobantePrestramo() =>
            Console.WriteLine($"Comprobante AUDIOLIBRO: {Titulo} (Narrado por {Narrador})");

        public decimal CalcularMultaPorRetraso(int dias) => dias * 0.50m;
    }
}
