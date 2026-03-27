using System;
using System.Collections.Generic;
using System.Text;

namespace RepasoParcial2.Parking.Modelo
{
    public class Carro : Vehiculo
    {
        public int NroPuertas { get; set; }
        public Carro(string placa, string marca, int puertas) : base(placa, marca)
            => NroPuertas = puertas;

        public override int CalcularTarifa(int minutos) => minutos * 100;
        public override string ToString() => $"CARRO {base.ToString()}";
    }


    public class Moto : Vehiculo
    {
        public int Cilindraje { get; set; }
        public Moto(string placa, string marca, int cilindraje) : base(placa, marca)
            => Cilindraje = cilindraje;

        public override int CalcularTarifa(int minutos) => minutos * 50;
        public override string ToString() => $"MOTO {base.ToString()}";
    }


}
