<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RootOFERTA.aspx.cs" Inherits="WabiSabiWeb.RootOFERTA" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h1>Ofertas</h1>
    </div>
    <div>
        Codigo:
        <asp:TextBox ID="Codigo" runat="server"  Width="173px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="CodigoReq" runat="server" ControlToValidate="Codigo" Display="Dynamic" ErrorMessage="Introduce un codigo valido" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
        &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="Codigo" ErrorMessage="CompareValidator" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">Escribe un número</asp:CompareValidator>
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br/>
        <br />
        <asp:Button ID="Leer" runat="server" Text="Leer" OnClick="Read_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Borrar" runat="server" Text="Borrar" OnClick="Delete_Click"/>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;Nombre:
        <asp:TextBox ID="Tipo" runat="server"  Width="173px"></asp:TextBox>
        <br />
        <br />
        Descripcion:
        <asp:TextBox ID="Descripcion" runat="server"  Width="173px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        Oferta Visible para:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Todos los clientes</asp:ListItem>
            <asp:ListItem>Solo usuarios</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="Crear" runat="server" Text="Crear" OnClick="Create_Click"/>
        &nbsp;
        &nbsp;
        <asp:Button ID="Actualizar" runat="server" Text="Actualizar" OnClick="Update_Click"/>
        <br />
        <asp:label ID="LabelRespuesta" runat="server" Text=" " />
    </div>  
</asp:Content>