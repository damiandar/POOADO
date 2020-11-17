using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class datos
    {
        SqlConnection oConexion = new SqlConnection();

        public datos()
        {
            oConexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["isteaConnectionString"].ToString();
        }

        /// <summary>
        /// Ejecuta la consulta y devuelve la primer columna de la primer fila en el resultset retornado por la consulta.
        /// </summary>
        /// <param name="Consulta"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public object EjecutarScalar(string Consulta, SqlParameter[] parametros)
        {
            object resultado = null;
            SqlCommand comando = new SqlCommand(Consulta, oConexion);
            if (parametros != null && parametros.Length > 0)
                comando.Parameters.AddRange(parametros);
                 
            try
            {
                ///ABRO CONEXION
                oConexion.Open();
                resultado =comando.ExecuteScalar();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                ///CIERRO CONEXION
                oConexion.Close();
            }
            return resultado;
        }

        /// <summary>
        /// Devuelve la cantidad de filas afectadas
        /// </summary>
        /// <param name="Consulta"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public int EjecutarSinResultado(string Consulta, SqlParameter[] parametros)
        {
            int cantFilasAfectadas = 0;
            SqlCommand comando = new SqlCommand(Consulta, oConexion);
            if (parametros != null && parametros.Length > 0)
                comando.Parameters.AddRange(parametros);

            try
            {
                ///ABRO CONEXION
                oConexion.Open();
                cantFilasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ///CIERRO CONEXION
                oConexion.Close();
            }
            return cantFilasAfectadas;
        }

        /// <summary>
        /// Nos devuelve un datatable 
        /// </summary>
        /// <param name="Consulta"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public DataTable MostrarDatatable(string Consulta, SqlParameter[] parametros)
        { 
            var dt = new DataTable();
            SqlCommand comando = new SqlCommand(Consulta, oConexion);
            if (parametros != null && parametros.Length > 0)
                comando.Parameters.AddRange(parametros);
           
            var da = new SqlDataAdapter( );
            da.SelectCommand = comando;

            try
            {
                ///ABRO CONEXION
                oConexion.Open();
                da.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                ///CIERRO CONEXION
                oConexion.Close();
            }
            return dt;
        }


    }
}