<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WabiSabiWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h1>Registro</h1>
    </div>
    <div>
        NIF
        <asp:TextBox ID="NIF" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NIF" Display="Dynamic" ErrorMessage="Campo Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Nombre
        <asp:TextBox ID="Nombre" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Nombre" Display="Dynamic" ErrorMessage="Campo Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Apellidos
        <asp:TextBox ID="Apellidos" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Apellidos" Display="Dynamic" ErrorMessage="Campo Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         Email
        <asp:TextBox ID="Email" runat="server"  Width="173px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Email" Display="Dynamic" ErrorMessage="Campo Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Contraseña
        <asp:TextBox ID="Contrasenya" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Contrasenya" Display="Dynamic" ErrorMessage="Campo Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        &nbsp;&nbsp;
        Telefono
        <asp:TextBox ID="Telefono" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Telefono" Display="Dynamic" ErrorMessage="Campo Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         Direccion
        <asp:TextBox ID="Direccion" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Direccion" Display="Dynamic" ErrorMessage="Campo Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;
        <br />
        FechaNac&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
&nbsp;<asp:Calendar ID="FechaNac" runat="server"></asp:Calendar>
        <br />
        &nbsp;
        <asp:Button ID="Crear" runat="server" Text="Registro" OnClick="Create_Click"/>
        &nbsp;
        &nbsp;
        <br />
        
    </div>
</asp:Content>
