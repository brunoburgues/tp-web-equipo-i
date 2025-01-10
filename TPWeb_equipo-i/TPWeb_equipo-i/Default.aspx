<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWeb_equipo_i.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1>Ingrese su voucher para participar.</h1>
    <br />
    <div class="row">
        <div class="col-2">
        </div>
        <div class="col">
            <div class="mb-3">
                <label for="txtCodigo" class="form-label" id = "lblCodigo">Código</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCodigo" />
                <asp:Label Text="" runat="server" ID="lblAlertaCodigo"/>
            </div>
            <asp:Button Text="Ingresar" CssClass="btn btn-secondary mb-3" ID="btnIngresarCodigo" OnClick="btnIngresarCodigo_Click" commandArgument='<%#Eval("FechaCanje") %>' runat="server" />
            <br/>
            <br/>
        </div>
        <div class="col-2"></div>
        <div class="card text-center">
            <div class="card-body">
                <h5 class="card-title">Encuentra nuestras ultimas promociones aquí.</h5>
                <p class="card-text">¡Preparate para ganar y disfrutar de nuestros productos!</p>
                <a href="LogIn.aspx" class="btn btn-primary">Iniciar Sesión</a>
            </div>
        </div>
    </div>
</asp:Content>
