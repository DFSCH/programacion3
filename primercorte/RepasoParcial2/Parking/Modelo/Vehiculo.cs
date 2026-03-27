using RepasoParcial2.Parking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepasoParcial2.Parking.Modelo
{
    public abstract class Vehiculo : ICobrable
    {
        public string Placa { get; set; }
        public string Marca { get; set; }

        protected Vehiculo(string placa, string marca)
        {
            Placa = placa;
            Marca = marca;
        }

        public abstract int CalcularTarifa(int minutos);

        public override string ToString()
        {
            return $"{Placa.ToUpper()} - MARCA: {Marca.ToUpper()}";
        }
    }
}
