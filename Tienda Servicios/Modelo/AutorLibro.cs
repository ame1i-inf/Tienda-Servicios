using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Servicios.Modelo
{
    public class Autor_Libro
    {
        public int Autor_LibroId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public ICollection<GradoAcademico> ListaGradoAcademico { get; set; }
        public string AutorLibroGuid { get; set; }

    }
}