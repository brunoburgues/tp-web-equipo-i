using BaseDatos;
using Dominio;
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
            if(!IsPostBack)
                lblAlertaEmail.Visible = false;
            //Tomar datos del cliente si ya esta registrado o pedir los datos
            //VoucherDb : para ingresar un vaucher cargado
            string cod = Request.QueryString["vou"] != null ? Request.QueryString["vou"].ToString() : "No paso el código";
            int idArt = Request.QueryString["id"] != null ? Convert.ToInt32(Request.QueryString["id"]) : 999;
            lblPrueba.Text = "El voucher ingresado fue: " + cod + " Y el Id del Articulo seleccionado fue: " + idArt;

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            lblAlertaEmail.Visible = false;
            lblAlertaEmail.ForeColor = System.Drawing.Color.Red;
            string email = txtEmail.Text.ToLower();

            if (string.IsNullOrEmpty(email))
            {
                lblAlertaEmail.Visible=true;
                lblAlertaEmail.Text = "Por favor, ingrese un correo para ingresar.";
            }
            else
            {
                ClienteDB clienteDB = new ClienteDB();
                List<Cliente> clientes = clienteDB.ListarClientes();
                Cliente cliente = clientes.Find(c => c.Email.ToLower() == email);
                if (cliente != null)
                {
                    VoucherDB voucherDB = new VoucherDB();
                    Voucher voucher = new Voucher();
                    voucher.CodigoVoucher = Request.QueryString["vou"].ToString();
                    voucher.IdCliente = cliente.Id;
                    //SE requiere seleccionar el premio primero
                    //voucher.Articulo.Id = articulo.Id;
                    voucher.FechaCanje = DateTime.Now;
                    voucherDB.Ingresar(voucher);
                }
                else
                {
                    lblAlertaEmail.Text = "El correo ingresado es incorrecto.";
                    lblAlertaEmail.Visible=true;
                }
            }

        }
    }
}