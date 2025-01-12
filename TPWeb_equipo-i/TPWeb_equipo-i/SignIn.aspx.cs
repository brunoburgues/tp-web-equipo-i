using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseDatos;
using Dominio;

namespace TPWeb_equipo_i
{
    public partial class SignIn : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                txtDNI.Text= "Empiece por AQUI";

            string codigo = Request.QueryString["vou"].ToString();
            int idArt = Convert.ToInt32(Request.QueryString["id"]);
            linkLogIn.NavigateUrl = "LogIn.aspx?vou=" + codigo + "&id=" + idArt;

            //Codigo para probar si se pasaron los datos correctamente
            string cod = Request.QueryString["vou"] != null ? Request.QueryString["vou"].ToString() : "No paso el código";
            int idArticulo = Request.QueryString["id"] != null ? Convert.ToInt32(Request.QueryString["id"]) : 999;
            lblPrueba.Text = "El voucher ingresado fue: " + cod + " Y el Id del Articulo seleccionado fue: " + idArticulo;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        protected void txtDNI_TextChanged(object sender, EventArgs e)
        {
            string Documento = txtEmail.Text.ToLower();
            ClienteDB clienteDB = new ClienteDB();
            List<Cliente> clientes = clienteDB.ListarClientes();
            Cliente cliente = clientes.Find(c => c.Documento.ToLower() == Documento);                                                             

        }
    }
}