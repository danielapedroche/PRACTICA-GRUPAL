<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WabiSabiWeb.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1">
        Carrito</p>
    <p class="auto-style1">
        Producto :<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></p>
    <p class="auto-style1">
        Menu :<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></p>
    <p class="auto-style1">
        Total:<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </p>
    <p class="auto-style1">
        <asp:Button ID="Button1" runat="server" Text="Tramitar Pedido" OnClick="Update_Click" />
    </p>
    <asp:Label ID="Label1" runat="server"></asp:Label>
</asp:Content>
