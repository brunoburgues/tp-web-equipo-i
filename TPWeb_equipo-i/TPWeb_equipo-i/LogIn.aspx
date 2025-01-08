<%@ Page Title="Registro" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="TPWeb_equipo_i.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <h1 class="text-center">Iniciar Sesión</h1>
    <br/>
    <div class="row">
        <div class="col-2">
        </div>
        <div class="col">
            <div class="mb-3">
              <label for="txtEmail" class="form-label">Email</label>
              <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail"/>
            </div>
            <div class="mb-3">
              <label for="txtContraseña" class="form-label">Contraseña</label>
              <asp:TextBox runat="server" CssClass="form-control" ID="txtContraseña" Type="password"/>
            </div>
            <p class="form-text">Si todavía no tienes una cuenta, puedes crearla <a href="SignIn.Aspx">aquí</a>.</p>
            <asp:Button Text="Ingresar" Cssclass="btn btn-secondary mb-3" ID="btnIniciarSesion" Onclick="btnIniciarSesion_Click" runat="server" />

        </div>
        <div class="col-2"></div>
    </div>
</asp:Content>