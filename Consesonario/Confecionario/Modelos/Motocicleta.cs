using Consesonario.Confecionario.Enums;
using Consesonario.Confecionario.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consesonario.Confecionario.Modelos
{
    public class Motocicleta : Vehiculo, IVendible
    {
        public int Cilindraje { get; set; }
        public bool EsDeportiva { get; set; }

        public Motocicleta(int id, string marca, string modelo, int anio, decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado, int cilindraje, bool deportiva)
            : base(id, marca, modelo, anio, precioBase, combustible, estado)
        {
            Cilindraje = cilindraje;
            EsDeportiva = deportiva;
        }

        public decimal CalcularPrecioFinal() => PrecioBase + (EsDeportiva ? Cilindraje * 10 : 0);

        public decimal CalcularComisionVendedor() => CalcularPrecioFinal() * 0.05m;

        public void GenerarFacturaVenta() => Console.WriteLine($"FACTURA MOTO: {Marca} {Modelo} - Total: {CalcularPrecioFinal():C}");
    }
}
