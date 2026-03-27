using Consesonario.Confecionario.Enums;
using Consesonario.Confecionario.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consesonario.Confecionario.Modelos
{
    public class Camion : Vehiculo, IVendible
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }

        public Camion(int id, string marca, string modelo, int anio, decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado, decimal carga, int ejes)
            : base(id, marca, modelo, anio, precioBase, combustible, estado)
        {
            CapacidadCarga = carga;
            NumeroEjes = ejes;
        }

        public decimal CalcularPrecioFinal() => PrecioBase + (CapacidadCarga * 500);

        public decimal CalcularComisionVendedor() => CalcularPrecioFinal() * 0.07m; // 7% Ejemplo

        public void GenerarFacturaVenta() => Console.WriteLine($"FACTURA CAMIÓN: {Marca} {Modelo} - Total: {CalcularPrecioFinal():C}");
    }
}
