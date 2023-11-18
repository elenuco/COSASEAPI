<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="COSASE.CSU.Ingreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
             <asp:Label class="h2" ID="lblBienvenida" runat="server" Text="Bienvenido/a al Sistema"></asp:Label> 
             <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
             <asp:TextBox ID="tbUsuario" CssClass="form-control" runat="server" placeholder="Nombre de Usuario" OnTextChanged="tbUsuario_TextChanged"></asp:TextBox>
            </div>
            <div></div>
            <div>
             <asp:label ID="lblPassword" runat="server" Text="Password:"></asp:label>
             <asp:TextBox ID="tbPassword" CssClass="form-control" runat="server" placeholder="Password"></asp:TextBox>
            </div>
            <div class="row">
                <asp:Button ID="BtnIngresar" CssClass="btn btn-primary btn-dark" runat="server" Text="Iniciar Sesión" OnClick="BtnIngresar_Click" />
             </div>
            <div>
                <asp:label ID="Label1" runat="server" Text="ID User"></asp:label>
                <asp:TextBox ID="tbIdUsuario" CssClass="form-control" runat="server" placeholder=""></asp:TextBox>
            </div>
            <div></div>
            <div>
                <asp:label ID="Label2" runat="server" Text="Nombre Usuario"></asp:label>
                 <asp:TextBox ID="nombre_usuario" CssClass="form-control" runat="server" placeholder=""></asp:TextBox>
            </div>
            <div></div>
            <div>
                <asp:label ID="Label3" runat="server" Text="ID Tipo Usuario"></asp:label>
                <asp:TextBox ID="id_TipoUsuario" CssClass="form-control" runat="server" placeholder=""></asp:TextBox>
            </div>
            <div></div>
            <div>
                <asp:label ID="Label4" runat="server" Text="ID cliente"></asp:label>
                <asp:TextBox ID="id_cliente" CssClass="form-control" runat="server" placeholder=""></asp:TextBox>
            </div>
            <div></div>
            <div>
                <asp:label ID="Label5" runat="server" Text="Nombre Cuenta"></asp:label>
                <asp:TextBox ID="nombre_cuenta" CssClass="form-control" runat="server" placeholder=""></asp:TextBox>
            </div>
            <br />
            <div class="row">
            <asp:Button ID="consultarUsuario" CssClass="btn btn-primary btn-dark" runat="server" Text="Buscar Usuario" OnClick="BtnBuscarUsuario_Click" />
            </div>
        </div>
    </form>
</body>
</html>
