using System;
using System.Collections.Generic;
using System.Text;
using Consesonario.Confecionario.Interfaces;
using Consesonario.Confecionario.Enums;

namespace Consesonario.Confecionario.Modelos
{       
        public abstract class Vehiculo
        {
            public int Id { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Anio { get; set; }
            public decimal PrecioBase { get; set; }
            public TipoCombustible Combustible { get; set; }
            public EstadoVehiculo Estado { get; set; }

            protected Vehiculo(int id, string marca, string modelo, int anio, decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado)
            {
                Id = id;
                Marca = marca;
                Modelo = modelo;
                Anio = anio;
                PrecioBase = precioBase;
                Combustible = combustible;
                Estado = estado;
            }

            public virtual void MostrarEspecificaciones()
            {
                Console.WriteLine($"[{Id}] {Marca} {Modelo} ({Anio}) - Estado: {Estado} - Combustible: {Combustible}");
            }
        }
    }
}
