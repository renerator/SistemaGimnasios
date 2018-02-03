<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccesoDenegado.aspx.cs" Inherits="SistemaGimnasios.AccesoDenegado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" href="~/Favicon.png" type="image/x-icon">
    <title>Acceso denegado | Gestion de Gimnasios | Produce Software Ltda.</title>
    <link href="~/Scripts/vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="~/Scripts/vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <script src="~/Scripts/vendors/fastclick/lib/fastclick.js"></script>
    <link href="~/Scripts/vendors/nprogress/nprogress.css" rel="stylesheet">
    <link href="~/Content/css/custom.min.css" rel="stylesheet">
</head>
<body class="nav-md">
<div class="container body">
        <div class="main_container">
            <!-- page content -->
            <div class="col-md-12">
                <div class="col-middle">
                    <div class="text-center text-center">
                        <h1 class="error-number"><asp:Label ID="lblNumeroError" runat="server"></asp:Label></h1>
                        <h2><asp:Label ID="lblTituloError" runat="server"></asp:Label></h2>
                        <p>
                            <asp:Label ID="lblDescripcion" runat="server"></asp:Label><a href="mailto:contacto@producesoftware.cl">aquí</a>
                        </p>
                        <div class="mid_center">
                            <form runat="server">
                                <div class="col-xs-12 form-group pull-right top_search">
                                    <div class="input-group">
                                        <a href="javascript:history.back()">Volver atrás...!!!</a>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /page content -->
        </div>
    </div>
</body>
</html>
