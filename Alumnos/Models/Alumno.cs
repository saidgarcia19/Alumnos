using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alumnos.Models
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Activo { get; set; }
        public string RFC { get; set; }
    }
}