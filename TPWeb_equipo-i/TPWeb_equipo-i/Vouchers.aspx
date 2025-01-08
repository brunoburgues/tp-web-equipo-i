<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Vouchers.aspx.cs" Inherits="TPWeb_equipo_i.Vouchers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>Mis Vouchers</h2>
    <br />
    <asp:GridView runat="server" ID="dgvVouchers" Class="table" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Código" DataField="Codigo" />
            <asp:BoundField HeaderText="Fecha de Canje" DataField="FechaCanje" />
            <asp:BoundField HeaderText="Producto Seleccionado" DataField="idProducto" />
            <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
        </Columns>
    </asp:GridView>
    <div class="col-12">
        <asp:Button Text="Ingresar Voucher" CssClass="btn btn-success mb-3" ID="btnIngresarVoucher" OnClick="btnIngresarVoucher_Click" runat="server" />
    </div>
</asp:Content>
