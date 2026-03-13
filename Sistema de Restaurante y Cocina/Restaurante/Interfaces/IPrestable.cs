using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Restaurante_y_Cocina.Restaurante.Interfaces
{
    public interface IPreparable
    {
        TimeSpan CalcularTiempoPreparacion();
        void GenerarOrdenCocina();
        decimal CalcularCostoTotal();
    }
}
