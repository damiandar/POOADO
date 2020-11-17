using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DAL;
using System.Data;

namespace BLL
{
   public class AlumnoBLL
    {
        public Alumno MostrarUnAlumno(int DNI)
        {
            var alumno = new Alumno();

            var alumnoDal = new AlumnoDAL(); 
            var dataTable = new DataTable();

            var dt = alumnoDal.MostrarUnAlumno(DNI);
            foreach(DataRow dr in dt.Rows)
            {
                alumno.DNI= Int32.Parse( dr["dni"].ToString() );
                alumno.Apellido = dr["apellido"].ToString();
                alumno.Nombre = dr["nombre"].ToString();
            }
 
            return alumno;
        }
        
        public List<Alumno> MostrarListadoAlumnos()
        {
            var ListadoAlumnos = new List<Alumno>();

            var alumnoDal = new AlumnoDAL();
            var dataTable = new DataTable();

            var dt = alumnoDal.MostrarListadoAlumnos();
            foreach (DataRow dr in dt.Rows)
            {
                var alumno = new Alumno();
                alumno.DNI = Int32.Parse(dr["dni"].ToString());
                alumno.Apellido = dr["apellido"].ToString();
                alumno.Nombre = dr["nombre"].ToString();
                ListadoAlumnos.Add(alumno);
            }

            return ListadoAlumnos;
        }

        public List<Alumno> Buscar(int Dni, string Apellido, string Nombre)
        {
            var ListadoAlumnos = new List<Alumno>();

            var alumnoDal = new AlumnoDAL();
            var dataTable = new DataTable();

            var dt = alumnoDal.Buscar( Dni,Nombre,Apellido);
            foreach (DataRow dr in dt.Rows)
            {
                var alumno = new Alumno();
                alumno.DNI = Int32.Parse(dr["dni"].ToString());
                alumno.Apellido = dr["apellido"].ToString();
                alumno.Nombre = dr["nombre"].ToString();
                ListadoAlumnos.Add(alumno);
            }

            return ListadoAlumnos;
        }


        public int InsertarAlumno(int DNI, string Nombre, string Apellido)
        {
            var alumnoDal = new AlumnoDAL();
            return alumnoDal.InsertarAlumno(DNI, Nombre, Apellido);
        }

        public int ModificarAlumno(int DNI, string Nombre, string Apellido)
        {
            var alumnoDal = new AlumnoDAL();
            alumnoDal.ModificarAlumno(DNI, Nombre, Apellido);
            return 0;
        }

        public int BorrarAlumno(int DNI)
        {
            var alumnoDal = new AlumnoDAL();
            alumnoDal.BorrarAlumno(DNI);
            return 0;
        }
    }
}
