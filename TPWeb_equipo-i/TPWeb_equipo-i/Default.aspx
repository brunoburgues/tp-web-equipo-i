<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWeb_equipo_i.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="mt-5 text-center">Ingrese su voucher para participar.</h1>
    <div class="row">
        <div class="col-2">
        </div>
        <div class="col mt-4">
            <div class="mb-3">
                <label for="txtCodigo" class="form-label" id = "lblCodigo">Código</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCodigo" />
                <asp:Label Text="" runat="server" ID="lblAlertaCodigo"/>
            </div>
            <div class="text-end">

                <asp:Button Text="Ingresar" CssClass="btn btn-secondary mb-3" ID="btnIngresarCodigo" OnClick="btnIngresarCodigo_Click" commandArgument='<%#Eval("FechaCanje") %>' runat="server" />
            </div>
        </div>
        <div class="col-2"></div>
    </div>
</asp:Content>
