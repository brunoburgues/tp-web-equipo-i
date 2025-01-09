﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseDatos;
using Dominio;


namespace TPWeb_equipo_i
{
    public partial class Premios : System.Web.UI.Page

    {
        public List<Articulo> ListaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloDB accesodedatos = new ArticuloDB();
            ListaArticulo = accesodedatos.ListarArticulosSP();
       

            if (!IsPostBack)
                {
                repRepetidor.DataSource = ListaArticulo;
                repRepetidor.DataBind();


            }

        }

        protected void repRepetidor_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "IdArticulo")
            {
                int idArticulo = Convert.ToInt32(e.CommandArgument);
                string cod = Request.QueryString["vou"].ToString();

                Response.Redirect("LogIn.aspx?vou=" + cod + "&id=" + idArticulo, false);
            }
        }
    }
}