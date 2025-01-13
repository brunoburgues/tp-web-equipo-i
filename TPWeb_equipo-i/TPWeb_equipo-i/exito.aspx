<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Exito.aspx.cs" Inherits="TPWeb_equipo_i.Exito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card text-center">
        <div class="card-header">
            ¡ÉXITO!
        </div>
        <div class="card-body">
            <h5 class="card-title">¡Ha participado exitosamente!</h5>
            <h6 class="card-title">Se le ha enviado una confirmación al email correspondiente.</h6>
            <p class="card-text">¡Aumente sus chances de ganar! <br /> Siga participando con la compra de más artículos.</p>
            <a href="Default.aspx" class="btn btn-success">Ir al Inicio</a>
        </div>
        <div class="card-footer text-body-secondary">
            Si el correo no le ha llegado, revise su bandeja de span.
        </div>
    </div>
</asp:Content>
