<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_Cuatrimestral_Grupo14._Default" %>

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

