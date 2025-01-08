<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="TPWeb_equipo_i.Premios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>PREMIOS</h1>
  
    <asp:Repeater  runat="server" id="repRepetidor">
        <ItemTemplate>

                <div class="card mb-3" style="max-width: 540px;">
  <div class="row g-0">
    <div class="col-md-4">
      <img src="<%#Eval("Imagenes") %>" class="img-fluid rounded-start" alt="...">
    </div>
    <div class="col-md-8">
      <div class="card-body">
        <h5 class="card-title"><%#Eval("Nombre") %></h5>
        <p class="card-text"><%#Eval("Descripcion") %></p>
        <asp:Button Text="Elegir"  cssclass="btn btn-primary" runat="server" id="botonElegir" CommandName="IdArticulo" CommandArgument='<%#Eval("Id")  %>'/>
      </div>
    </div>
  </div>
</div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
