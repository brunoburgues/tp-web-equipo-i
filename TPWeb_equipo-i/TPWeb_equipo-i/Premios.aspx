<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="TPWeb_equipo_i.Premios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>PREMIOS</h1>
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <asp:Repeater runat="server" ID="repRepetidor" OnItemCommand="repRepetidor_ItemCommand">
                <ItemTemplate>
                    <div class="card mb-3" style="max-width: 540px;">
                        <div class="row g-0">
                            <div class="col-md-8">
                                <div class="card-body">
                                    <!-- Ejecuta el código dentro de %>. Para acceder a los datos se dirige a aspx.cs y los busca por el ID del Repeater-->
                                    <!--Lo encuentra y toma la lista de Articulos-->
                                    <!--Se posiciona en el primer articulo-->
                                    <h5 class="card-title"><%# Eval("Nombre") %></h5>
                                    <!--Accede a la propiedad Nombre y lo muestra-->
                                    <p class="card-text"><%# Eval("Descripcion") %></p>
                                    <asp:Button Text="Elegir" CssClass="btn btn-success" runat="server" ID="btnElegir" CommandName="IdArticulo" CommandArgument='<%# Eval("Id") %>' />
                                    <!--Falta la accion del boton-->
                                </div>
                            </div>
                            <div class="col-md-4">
                                <!--Pegamos el carousel de B-->
                                <!--Debe existir un carrousel por cada producto. 
                                    Por eso accedemos al ID del Art y lo insertamos al id del carousel-->
                                <div id="carousel<%# Eval("Id") %>" class="carousel slide carousel-fade" data-bs-ride="carousel">
                                    <div class="carousel-inner">
                                        <!--Creamos un repeater para manejar la imagenes-->
                                        <!--En este contexto la lista que manejamos, es la lista de imagenes que viene cargado en c/producto-->
                                        <asp:Repeater runat="server" ID="repImagenes" DataSource='<%# Eval("Imagenes") %>'>
                                            <ItemTemplate>
                                                <div class="carousel-item <%# Container.ItemIndex == 0 ? "active" : "" %>">
                                                    <img src='<%# Eval("Url") %>' class="d-block w-100" alt="">
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <!--El Repeater dibuja tantos items como imagenes tenga nuestra lista-->
                                        <!-- Usamos el Operador ternario para poner solo el primer elemento como active -->
                                    </div>
                                    <!--Los botones deben direccionar al mismo id del carousel tomando el id del articulo-->
                                    <button class="carousel-control-prev" type="button" data-bs-target="#carousel<%# Eval("Id") %>" data-bs-slide="prev">
                                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                        <span class="visually-hidden">Previous</span>
                                    </button>
                                    <button class="carousel-control-next" type="button" data-bs-target="#carousel<%# Eval("Id") %>" data-bs-slide="next">
                                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                        <span class="visually-hidden">Next</span>
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
        <div class="col-2"></div>
    </div>
</asp:Content>
