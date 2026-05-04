using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria.MODELO
{
    public class Mascota
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public DateTime FechaNac { get; set; }
        public string IDPropietario { get; set; }
    }
}
