<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="COSASE.CSU.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Log-In</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
<script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
<link href="Recursos/CSS/Estilos.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <div class="wrapper">
        <div id="formcontent">
        <form id="formulario_login" runat="server">
        <div>
            <div class="row">
                <asp:Label ID="lblBienvenida" runat="server" Text="Bienvenid@ al sistema"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                <asp:TextBox ID="tbUser" CssClass="form-control" runat="server" placeHolder="Nombre de Usuario"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                <asp:TextBox ID="tbPassword" CssClass="form-control" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
            </div>
            <hr />
            <div class="row">
                <asp:Button ID="BtnIngresar" CssClass="btn btn-primary btn-dark" runat="server" Text="Iniciar Sesión" OnClick="BtnIngresar_Click" />
            </div>
        </div>
            <div>
                <br />
                <asp:TextBox ID="txtIdUsuario" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txtIdTipoUsuario" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txtTipoUsuario" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txtIdCliete" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txtNombreCuenta" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txtNit" runat="server"></asp:TextBox>
                <br />
                <br />
                <br />
            </div>
        </form>
        </div>   
    </div>
</body>
</html>
