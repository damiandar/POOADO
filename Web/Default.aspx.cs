using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //MostrarGrilla();
        }
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            var alumnoBLL = new AlumnoBLL();
            alumnoBLL.InsertarAlumno(Int32.Parse( tbDni.Text), tbNombre.Text, tbApellido.Text);
            MostrarGrilla();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            var alumnoBLL = new AlumnoBLL();
            alumnoBLL.ModificarAlumno(Int32.Parse( tbDni.Text), tbNombre.Text, tbApellido.Text);
            MostrarGrilla();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var alumnoBLL = new AlumnoBLL();
                GridView1.DataSource = alumnoBLL.Buscar(Int32.Parse(tbDni.Text), tbApellido.Text, tbNombre.Text);
                GridView1.DataBind();
            }
            catch (Exception ex) {
                lblError.Text = ex.Message.ToString();
            }

        }


        protected void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                tbApellido.Text = "";
                tbDni.Text = "";
                tbNombre.Text = "";
                MostrarGrilla();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message.ToString();
            }

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            var alumnoBLL = new AlumnoBLL();
            alumnoBLL.BorrarAlumno(Int32.Parse(tbDni.Text));
            MostrarGrilla();
        }
        private void MostrarGrilla()
        {
            var alumnoBLL = new AlumnoBLL();
            GridView1.DataSource = alumnoBLL.MostrarListadoAlumnos();
            GridView1.DataBind();
        }

    }
}