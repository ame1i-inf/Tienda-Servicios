using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Servicios.Aplicacion
{
    public class AutorDto
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string AutorLibroGuid { get; set; }
    }
}