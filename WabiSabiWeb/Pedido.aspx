<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="WabiSabiWeb.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            color: #000000;
        }
        .auto-style2 {
            font-size: large;
            color: #000000;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<p class="auto-style2">
        <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
    </p>
    <p class="auto-style1">
        Resumen de tu pedido:
 </p>
    <p class="auto-style1">

        Domicilio:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p class="auto-style1">
        Seleccione un método de pago:</p>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
        <asp:ListItem>Tarjeta</asp:ListItem>
        <asp:ListItem>PayPal</asp:ListItem>
        <asp:ListItem>Efectivo</asp:ListItem>
    </asp:CheckBoxList>
    <p class="auto-style1">
         Código promocional:</p>
    <p class="auto-style1">
        <asp:TextBox ID="Codigo" runat="server"></asp:TextBox>
    </p>
    <p class="auto-style1">
        Observaciones:</p>
    <p class="auto-style1">
        <asp:TextBox ID="Observaciones" runat="server" Height="65px" Width="227px"></asp:TextBox>
    </p>
    <p class="auto-style1">
        &nbsp;</p>
    <p class="auto-style1">
        <asp:Button ID="ConfirmarPedido" runat="server" Text="Confirmar Pedido" OnClick="ConfirmarPedido_Click" />
    </p>
</asp:Content>
