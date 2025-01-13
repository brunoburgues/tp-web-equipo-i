using BaseDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace TPWeb_equipo_i
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                lblAlertaDni.Visible = false;
            string codigo = Request.QueryString["vou"].ToString();
            int idArt = Convert.ToInt32(Request.QueryString["id"]);
            linkSignIn.NavigateUrl = "SignIn.aspx?vou=" + codigo + "&id=" +idArt;
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            lblAlertaDni.Visible = false;
            lblAlertaDni.ForeColor = System.Drawing.Color.Red;
            string dni = txtDni.Text.ToLower();

            if (string.IsNullOrEmpty(dni))
            {
                lblAlertaDni.Visible=true;
                lblAlertaDni.Text = "Por favor, ingrese su DNI para continuar.";
            }
            else
            {
                ClienteDB clienteDB = new ClienteDB();
                List<Cliente> clientes = clienteDB.ListarClientes();
                Cliente cliente = clientes.Find(c => c.Documento.ToLower() == dni);
                if (cliente != null)
                {
                    VoucherDB voucherDB = new VoucherDB();
                    Voucher voucher = new Voucher();
                    voucher.CodigoVoucher = Request.QueryString["vou"].ToString();
                    voucher.IdCliente = cliente.Id;
                    voucher.Articulo = new Articulo();
                    voucher.Articulo.Id = Convert.ToInt32(Request.QueryString["id"]);
                    voucher.FechaCanje = DateTime.Now;
                    voucherDB.Ingresar(voucher);
                    lblPrueba.ForeColor = System.Drawing.Color.Green;
                    lblPrueba.Text = "Voucher registrado Exitosamente";
                }
                else
                {
                    lblAlertaDni.Visible = true;
                    lblAlertaDni.Text = "El DNI ingresado es incorrecto. Si no se ha registrado anteriormente, puede hacerlo en el link de abajo.";
                }
            }

        }
    }
}