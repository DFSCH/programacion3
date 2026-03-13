using System;
using System.Collections.Generic;
using System.Text;

namespace Consesonario.Confecionario.Interfaces
{

    public interface IVendible
    {
        decimal CalcularPrecioFinal();
        void GenerarFacturaVenta();
        decimal CalcularComisionVendedor();
    }

}
