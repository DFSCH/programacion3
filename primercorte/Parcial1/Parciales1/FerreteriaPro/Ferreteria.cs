using Parcial1.Parciales1.FerreteriaPro.clases;
using Parcial1.Parciales1.FerreteriaPro.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Parciales1.FerreteriaPro
{
    public class Ferreteria
    {

        private List<HerramientasPropiedades> herramientas;

        public Ferreteria()
        {
            herramientas = new List<HerramientasPropiedades>();
        }

        public void AgregarHerramienta(HerramientasPropiedades herramienta)
        {
            herramientas.Add(herramienta);
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario de herramientas:");
            foreach (var h in herramientas)
            {
                h.MostrarEspecificaciones();
            }
        }

        public HerramientasPropiedades BuscarPorId(int id)
        {
            return herramientas.Find(h => h.Id == id);
        }




        public static void Ejecutar()
        {
            Ferreteria ferreteria = new Ferreteria();

            ferreteria.AgregarHerramienta(new HerramientasPropiedades(1, "Martillo", 25.5, TipoHerramienta.Manual));
           // ferreteria.AgregarHerramienta(new HerramientasPropiedades(2, "Taladro", 150.0, TipoHerramienta.electrica));
            ferreteria.AgregarHerramienta(new HerramientasPropiedades(3, "Cinta métrica", 10.0, TipoHerramienta.Medicion));

            ferreteria.MostrarInventario();

            var herramientaBuscada = ferreteria.BuscarPorId(2);
            if (herramientaBuscada != null)
            {
                Console.WriteLine("Herramienta encontrada:");
                herramientaBuscada.MostrarEspecificaciones();
            }
        }


    }
}
