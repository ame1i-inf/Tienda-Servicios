using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Servicios.Modelo
{
    public class GradoAcademico
    {
        public int GradoAcademicoId { get; set; }
        public string Nombre { get; set; }
        public string CentroAcademico { get; set; }
        public DateTime? FechaGrado { get; set; }
        public int Autor_LibroId { get; set; }
        public Autor_Libro Autor_Libro { get; set; }
        public string GradoAcademicoGuid { get; set; }
    }
}