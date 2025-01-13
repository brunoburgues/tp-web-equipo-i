using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseDatos;
using Dominio;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;
using servicios;

namespace TPWeb_equipo_i
{
    public partial class SignIn : System.Web.UI.Page
    {
        private Cliente cliente;
        //Métodos
        public bool clienteEncontrado(string criterio)
        {
            ClienteDB clienteDB = new ClienteDB();
            List<Cliente> clientes = clienteDB.ListarClientes();
            cliente = clientes.Find(c => c.Documento.ToLower() == criterio);
            if (cliente != null)
            {
                return  true;
            }
            return false;
        }
        
        //Eventos
        protected void Page_Load(object sender, EventArgs e)
        {

            string codigo = Request.QueryString["vou"].ToString();
            int idArt = Convert.ToInt32(Request.QueryString["id"]);
            linkLogIn.NavigateUrl = "LogIn.aspx?vou=" + codigo + "&id=" + idArt;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)

        {
            bool camposCompletos = true;
            string mensaje = "Por favor, complete los campos:\n";
            List<string> camposNoCompletados = new List<string>();
            string nombreCampo;
            ContentPlaceHolder contenedor = this.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox) 
                {
                    TextBox txt = (TextBox)control;
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        camposCompletos = false;
                        nombreCampo = txt.ID.ToString();
                        camposNoCompletados.Add(nombreCampo.Substring(3));
                    }
                }
            }

            if (!camposCompletos)
            {
                foreach (string campo in camposNoCompletados)
                {
                    mensaje += $" {campo},";
                }
                lblPrueba.Text = mensaje;
                lblPrueba.Visible = true;
                lblPrueba.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                //Carga el voucher
                lblPrueba.Visible = false;
                //Verificar que los datos ingresados sean correctos
                VoucherDB voucherDB = new VoucherDB();
                Voucher voucher = new Voucher();
                voucher.Articulo = new Articulo();
                voucher.FechaCanje = DateTime.Now;
                voucher.Articulo.Id = Convert.ToInt32(Request.QueryString["id"]);
                voucher.CodigoVoucher = Request.QueryString["vou"].ToString();
                if (clienteEncontrado(txtDNI.Text))
                {
                    voucher.IdCliente = cliente.Id;
                    voucherDB.Ingresar(voucher);
                }
                else
                {
                    ClienteDB clienteDB = new ClienteDB();
                    cliente.Ciudad = txtCiudad.Text;
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Documento = txtDNI.Text;
                    cliente.CP = Convert.ToInt32(txtCp.Text);
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Email = txtEmail.Text;
                    clienteDB.agregar(cliente);
                }
                //MuestraMensajeExito
                envioEmail emailService = new envioEmail();
                emailService.armarCorreo(txtEmail.Text, "", "");
                try
                {
                    emailService.enviarEmail();
                }
                catch (Exception ex)
                {
                    Session.Add("error", ex);
                }

                Response.Redirect("exito.aspx", false);
            }

          

            
        }

        protected void txtDNI_TextChanged(object sender, EventArgs e)
        {
            string Documento = txtDNI.Text.ToLower();
            
            if (clienteEncontrado(Documento))
            {
                txtApellido.Text = cliente.Apellido;
                txtCiudad.Text = cliente.Ciudad;
                txtCp.Text = cliente.CP.ToString();
                txtNombre.Text = cliente.Nombre;
                txtDireccion.Text= cliente.Direccion;
                txtEmail.Text = cliente.Email;
            }
        }
        
        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }
    }
}