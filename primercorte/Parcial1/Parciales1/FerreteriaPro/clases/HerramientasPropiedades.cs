using Parcial1.Parciales1.FerreteriaPro.enums;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;


namespace Parcial1.Parciales1.FerreteriaPro.clases

{
    public class HerramientasPropiedades
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public TipoHerramienta TipoHerramienta { get; set; }

        public HerramientasPropiedades(int id, string descripcion, double precio, TipoHerramienta tipoHerramienta)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            TipoHerramienta = tipoHerramienta;
        }

        public virtual void MostrarEspecificaciones()
        {
            Console.WriteLine($"[{Id}] {Descripcion} - ${Precio} ({TipoHerramienta})");
        }
    }


}

