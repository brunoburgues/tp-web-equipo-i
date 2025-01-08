<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="TPWeb_equipo_i.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <h2>Registrate para participar y ganar premios increíbles.</h2>
    <br/>
    <div class="row g-3">
      <div class="col-md-6">
        <label for="txtEmail" class="form-label">Correo Electrónico</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail"/>
      </div>
      <div class="col-md-6">
        <label for="txtContraseña" class="form-label">Contraseña</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtContraseña" Type="password"/>
      </div>
      <div class="col-12">
        <label for="txtNombre" class="form-label">Nombre Completo</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtNombre"/>
      </div>
      <div class="col-12">
        <label for="txtNombreUsuario" class="form-label">Nombre de Usuario</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtNombreUsuario"/>
      </div>
      <div class="col-12">
        <asp:Button Text="Registrarme" Cssclass="btn btn-success mb-3" ID="btnRegistrar" OnClick="btnRegistrar_Click" runat="server" />
      </div>
            <p class="form-text text-center">Si ya tienes una cuenta ingresa <a href="LogIn.Aspx">aquí</a>.</p>
    </div>
    <br/>
</asp:Content>

