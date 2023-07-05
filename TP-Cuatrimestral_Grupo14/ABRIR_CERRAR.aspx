<%@ Page Title="ABRIR_CERRAR" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABRIR_CERRAR.aspx.cs" Inherits="TP_Cuatrimestral_Grupo14.ABRIR_CERRAR" %>
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
    <asp:Button runat="server" Text="Asignar/Reasignar Mesas" OnClick="btnAsignarReasignarMesas_Click"  ID="btnAsignarReasignarMesas" />
    
</div>
</asp:Content>
