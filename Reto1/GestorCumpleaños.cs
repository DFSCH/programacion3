using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Reto1
{
    public class Amigo
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Amigo(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
        }


        public int CalcularDiasParaCumpleaños()
        {
            DateTime hoy = DateTime.Today;
            DateTime proximoCumpleaños = new DateTime(hoy.Year, FechaNacimiento.Month, FechaNacimiento.Day);
            if (proximoCumpleaños < hoy)
            {
                proximoCumpleaños = proximoCumpleaños.AddYears(1);
            }
            return (proximoCumpleaños - hoy).Days;
        }
    }
}
