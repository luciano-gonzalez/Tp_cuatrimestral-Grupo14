<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_Cuatrimestral_Grupo14._Default" %>

<<<<<<< HEAD
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3>Asignación de Mesas</h3>
        <ul>
            <% for (int i = 1; i <= 10; i++) { %>
                <li>
                    Mesa <%= i %>: 
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="SingleLine" onkeydown="return (event.keyCode !== 187);" MaxLength="50"></asp:TextBox>
                </li>
            <% } %>
        </ul>
        <asp:Button Text="text" runat="server" ID="btnAsignarReasignarMesass" OnClick="btnAsignarReasignarMesass_Click" />
    </div>
</asp:Content>

=======
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/estilos.css" rel="stylesheet" />
    <link href="Content/estilos%20inicio.css" rel="stylesheet" />
    <div class="mesas-container" id="mesasContainer">
        <% for (int i = 1; i <= 10; i++) { %>
            <div class="mesa <%= i <= 8 ? "cuadrada" : "rectangular" %>">
                <%= i %>
                <div class="botones-container">
                    <button id="Button1" class="boton verde" onclick="CambiarColor(this);" data-color="verde" runat="server"></button>
                </div>
            </div>
        <% } %>
    </div>
    
<<<<<<< HEAD






</asp:Content>
=======
</asp:Content>
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
>>>>>>> 1dcb20e58c582e01634db16a720b178c88376a48
