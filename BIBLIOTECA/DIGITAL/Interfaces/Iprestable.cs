using System;
using System.Collections.Generic;
using System.Text;

namespace BIBLIOTECA.DIGITAL.Interfaces
{
    public interface IPrestable
    {
        DateTime CalcularFechaDevolucion();
        void GenerarComprobantePrestramo();
        decimal CalcularMultaPorRetraso(int diasRetraso);
    }
}
