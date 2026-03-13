using System;
using System.Collections.Generic;
using System.Text;
using Consesonario.Confecionario.Interfaces;
using Consesonario.Confecionario.Enums;

namespace Consesonario.Confecionario.Modelos
{
    public class Auto : Vehiculo, IVendible
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }

        public Auto(int id, string marca, string modelo, int anio, decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado, int puertas, bool aire)
            : base(id, marca, modelo, anio, precioBase, combustible, estado)
        {
            NumeroPuertas = puertas;
            TieneAireAcondicionado = aire;
        }

        public decimal CalcularPrecioFinal() => PrecioBase + (TieneAireAcondicionado ? 2000 : 0);

        public decimal CalcularComisionVendedor() => CalcularPrecioFinal() * 0.03m; 

        public void GenerarFacturaVenta() => Console.WriteLine($"FACTURA AUTO: {Marca} {Modelo} - Total: {CalcularPrecioFinal():C}");
    }
}
