using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
 public class AlumnoDAL
    {
        public DataTable MostrarUnAlumno(int DNI)
        {
            var oDatos = new datos();
            var parametro1 = new SqlParameter("@Pdni", DNI ); 
            var vecparams = new SqlParameter[] { parametro1  };

            return oDatos.MostrarDatatable("select * from alumno where dni=@Pdni ", vecparams);
        }

        public DataTable MostrarListadoAlumnos( )
        {
            var oDatos = new datos();
            return oDatos.MostrarDatatable("select * from alumno",null);
        }

        public DataTable Buscar(int DNI, string Nombre, string Apellido )
        {
            var oDatos = new datos();
            var parametro1 = new SqlParameter("@Pdni", DNI);
            var parametro2 = new SqlParameter("@Papellido", Apellido);
            var parametro3 = new SqlParameter("@Pnombre", Nombre);
            var vecparams = new SqlParameter[] { parametro1, parametro2, parametro3 };

            return oDatos.MostrarDatatable("select * from alumno where  apellido=isnull(@Papellido,apellido) and nombre=isnull(@Pnombre,nombre)", vecparams);
        }

        public int InsertarAlumno(int DNI, string Nombre, string Apellido)
        {
            var oDatos = new datos();
            var parametro1 = new SqlParameter("@Pdni",DNI);
            var parametro2 = new SqlParameter("@Papellido", Apellido);
            var parametro3 = new SqlParameter("@Pnombre", Nombre);
            var vecparams = new SqlParameter[] { parametro1, parametro2, parametro3 };
            return (int)oDatos.EjecutarSinResultado("insert into alumno (dni,apellido,nombre) values (@Pdni,@Papellido,@Pnombre)", vecparams);

        }

        public int ModificarAlumno(int DNI, string Nombre, string Apellido)
        {
            var oDatos = new datos();
            var parametro1 = new SqlParameter("@Pdni", DNI);
            var parametro2 = new SqlParameter("@Papellido", Apellido);
            var parametro3 = new SqlParameter("@Pnombre", Nombre);
            var vecparams = new SqlParameter[] { parametro1, parametro2, parametro3 };
            return oDatos.EjecutarSinResultado("update alumno set apellido=@Papellido, nombre=@Pnombre where dni=@Pdni", vecparams);
         }

        public int BorrarAlumno(int DNI)
        {
            var oDatos = new datos();
            var parametro1 = new SqlParameter("@Pdni", DNI); 
            var vecparams = new SqlParameter[] { parametro1  };
            return oDatos.EjecutarSinResultado("delete alumno where dni=@Pdni", vecparams);
        }
    }
}
