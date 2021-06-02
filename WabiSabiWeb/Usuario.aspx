<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="WabiSabiWeb.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h1>LOGIN</h1>
    </div>
    <div>
        NIF
        <asp:TextBox ID="Nif" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Nif" ErrorMessage="Field Missing" ForeColor="Red">*</asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Si no está registrado, únase a la familia WabiSabi:
          <asp:Button ID="LoginRegister" runat="server" Height="38px" Text="REGISTRARSE" OnClick="Login_Click" CausesValidation="False" />
        <br />
        <br />
        Contraseña
        <asp:TextBox ID="Contrasenya" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Contrasenya" ErrorMessage="Field Missing" ForeColor="Red">*</asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<br />
        <asp:Button ID="Leer" runat="server" Text="Login" OnClick="Read_Click" />
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Label ID="LabelRespuesta" runat="server" Visible="False"></asp:Label>
        <br />
        
    </div>
</asp:Content>
