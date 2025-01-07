<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaArticulos.aspx.cs" Inherits="TPWeb_equipo_i.ListaArticulos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>lista de articulos</h1>
            <asp:GridView ID="dgvArticulos" CssClass="table" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
