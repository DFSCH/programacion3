using System;

namespace RepasoParcial1.Gloval.Modelos
{
    public enum TiposEnvio
    {
        Nacional,
        Internacional
    }

    public class paquete
    {
        public int guia { get; set; }
        public string destinatario { get; set; }
        public double peso { get; set; }
        public TiposEnvio tipo { get; set; }

        public override string ToString()
        {
            return $"{guia};{destinatario};{peso};{tipo}";
        }
    }
}