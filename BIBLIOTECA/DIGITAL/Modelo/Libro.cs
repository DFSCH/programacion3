using BIBLIOTECA.DIGITAL.Enums;
using BIBLIOTECA.DIGITAL.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace BIBLIOTECA.DIGITAL.Modelo
{
    internal class Libro : MaterialBiblioteca, IPrestable
    {
        public int NumeroPaginas { get; set; }
        public string ISBN { get; set; }

        public Libro(int id, string t, string a, int anio, TIpocategorias c, int pag, string isbn)
            : base(id, t, a, anio, c)
        {
            NumeroPaginas = pag; ISBN = isbn;
        }

        public DateTime CalcularFechaDevolucion() => DateTime.Now.AddDays(15);

        public void GenerarComprobantePrestramo() =>
            Console.WriteLine($"Comprobante LIBRO: {Titulo}. Devolver antes de: {CalcularFechaDevolucion().ToShortDateString()}");

        public decimal CalcularMultaPorRetraso(int dias) => dias * 1.50m;
    }

}


