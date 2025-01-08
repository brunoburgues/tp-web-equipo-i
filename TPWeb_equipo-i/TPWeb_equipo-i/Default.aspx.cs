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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                lblAlertaCodigo.Visible = false;
        }

        protected void btnIngresarCodigo_Click(object sender, EventArgs e)
        {
            lblAlertaCodigo.ForeColor = System.Drawing.Color.Red;
            lblAlertaCodigo.Visible = false;

            VoucherDB voucherDB = new VoucherDB();
            string codigo = txtCodigo.Text.ToLower();
            if (string.IsNullOrEmpty(codigo))
            {
                lblAlertaCodigo.Text = "Ingrese un código para comenzar.";
                lblAlertaCodigo.Visible = true;
            }
            else
            {
                List<string> listaCodigos = voucherDB.ListarCodigos();
                string codigoEncontrado = (string)listaCodigos.Find(v => v.ToLower() == codigo);
                List<string> listaCodigosUsados = voucherDB.ListarCodigosUsados();
                string codigoUsado = (string)listaCodigosUsados.Find(v => v.ToLower() == codigo);


                if (string.IsNullOrEmpty(codigoEncontrado))
                {//Verifica si el código existe en la bd
                    lblAlertaCodigo.Visible = true;
                    lblAlertaCodigo.Text = "Código Inválido.";
                }
                else if (!string.IsNullOrEmpty(codigoUsado))
                {//Verifica si ya fue usado o no
                    lblAlertaCodigo.Visible = true;
                    lblAlertaCodigo.Text = "Este código ya ha sido ingresado. Ingrese un código nuevo.";
                }
                else
                {
                    
                    Response.Redirect("Premios.aspx?vou=" + codigo, false);
                }
            }

        }
    }
}