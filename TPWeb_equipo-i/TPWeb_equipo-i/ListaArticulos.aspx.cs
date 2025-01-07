using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseDatos;


namespace TPWeb_equipo_i
{
    public partial class ListaArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos();
            dgvArticulos.DataSource = accesoBaseDatos.ListarArticulosSP();
            dgvArticulos.DataBind();
        }
    }
}