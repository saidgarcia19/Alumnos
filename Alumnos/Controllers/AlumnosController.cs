using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alumnos.Models;
using System.IO;
namespace Alumnos.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            return View();
        }

        public string Registro(Alumno alumno)
        {
            try
            {
                TextWriter registro = new StreamWriter("C:\\Users\\said_\\source\\repos\\Alumnos\\Alumnos\\Archivos\\Alumnos\\" + alumno.RFC.ToString() + ".txt");
                registro.WriteLine(alumno.Nombre.ToString());
                registro.WriteLine(alumno.ApellidoPaterno.ToString());
                registro.WriteLine(alumno.ApellidoMaterno.ToString());
                registro.WriteLine(alumno.FechaNacimiento.ToString());
                registro.WriteLine(alumno.Genero.ToString());
                registro.WriteLine(alumno.FechaIngreso.ToString());
                registro.WriteLine(alumno.Activo.ToString());
                registro.WriteLine(alumno.RFC.ToString());

                registro.Close();
                return "1";
            }
            catch (Exception ex)
            {

                return "Ocurrio un error" + ex;
            }
            
        }
    }
}