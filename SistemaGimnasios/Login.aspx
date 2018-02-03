<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaGimnasios.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" href="~/Favicon.png" type="image/x-icon">
    <title>Inicio de Sesión | Produce Software Ltda.</title>
    <link href="~/Scripts/vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="~/Scripts/vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <link href="~/Scripts/vendors/nprogress/nprogress.css" rel="stylesheet">
    <link href="~/Scripts/vendors/animate.css/animate.min.css" rel="stylesheet">
    <link href="~/Content/css/custom.min.css" rel="stylesheet">
    <style>
        body {
            background-image: url(../../images/DJI_0033.JPG) !important;
            background-position: center center;
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
        }
    </style>
</head>
<body class="login">
    <div class="login_wrapper">
        <div class="animate form login_form">
          <section class="login_content">
            <form runat="server">
              <h1>Inicio de Sesión</h1>
              <div>
                  <asp:TextBox ID="txtRut" CssClass="form-control" runat="server" placeholder="Rut: XXXXXXXX-X" required="required"></asp:TextBox>
              </div>
              <div>
                <asp:TextBox ID="txtContraseña" CssClass="form-control" runat="server" placeholder="Password" TextMode="Password" required="required"></asp:TextBox>
              </div>
              <div>
                  <asp:Button ID="btnIniciar" runat="server" CssClass="btn btn-default submit" Text="Iniciar" OnClick="btnIniciar_Click" />
              </div>
                <asp:Label ID="lblError" runat="server" Visible="false"></asp:Label>
              <div class="clearfix"></div>

              <div class="separator">
                <div>
                  <h1><i class="fa fa-cogs"></i> Gimnasio 3:16 Sports</h1>
                  <p>&copy; <%: DateTime.Now.Year %> Todos los derechos reservados. Produce Software Ltda.</p>
                </div>
              </div>
            </form>
          </section>
        </div>
    </div>
</body>
</html>
