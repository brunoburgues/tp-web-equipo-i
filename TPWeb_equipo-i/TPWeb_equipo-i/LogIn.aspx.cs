using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWeb_equipo_i
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cod = Request.QueryString["vou"] != null ? Request.QueryString["vou"].ToString() : "No paso el código";
            lblPrueba.Text = cod;
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}