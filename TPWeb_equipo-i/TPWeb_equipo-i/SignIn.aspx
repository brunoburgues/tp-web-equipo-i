﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="TPWeb_equipo_i.SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>Registrate para participar y ganar premios increíbles.</h2>
    <br />
    <div class="row g-3">
        <div class="col-md-6">
            <label for="txtEmail" class="form-label">Correo Electrónico</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" />
        </div>
        <div class="col-md-6">
            <label for="txtDNI" class="form-label">Documento</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDNI" />
        </div>
        <div class="col-12">
            <label for="txtNombre" class="form-label">Nombre</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtNombre" />
        </div>
        <div class="col-12">
            <label for="txtApellido" class="form-label">Apellido</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtApellido" />
        </div>
        <div class="col-12">
            <label for="txtDireccion" class="form-label">Dirección</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDireccion" />
        </div>
        <div class="col-12">
            <label for="txtCiudad" class="form-label">Ciudad</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtCiudad" />
        </div>
        <div class="col-12">
            <label for="txtCp" class="form-label">Código Postal</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtCp" />
        </div>
        <div class="col-12">
            <asp:Button Text="Registrarme" CssClass="btn btn-success mb-3" ID="btnRegistrar" OnClick="btnRegistrar_Click" runat="server" />
        </div>
        <p class="form-text text-center">Si ya tienes una cuenta ingresa <a href="LogIn.Aspx">aquí</a>.</p>
    </div>
    <br />
</asp:Content>

