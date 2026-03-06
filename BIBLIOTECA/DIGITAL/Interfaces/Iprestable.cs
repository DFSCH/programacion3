using System;
using System.Collections.Generic;
using System.Text;

namespace BIBLIOTECA.DIGITAL.Interfaces
{
    public interface Iprestable
    {
        DateTime CalcularLaFechaDeDevolucion();
        void GenerarComprobanteDePrestamo();
        decimal CalcularMultaPorRetraso(int diasRetrazo );
    }
}
