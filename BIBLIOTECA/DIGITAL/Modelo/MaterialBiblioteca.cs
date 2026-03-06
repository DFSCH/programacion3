using System;
using System.Collections.Generic;
using System.Text;

namespace BIBLIOTECA.DIGITAL.Modelo
{
    public abstract class MaterialBiblioteca
    {
        public int íd { get; set; }
        public string título { get; set; }
        public string autor { get; set; }
        public DateTime añoPublicación { get; set; }
    }
}



