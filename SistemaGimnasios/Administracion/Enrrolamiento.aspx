<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Enrrolamiento.aspx.cs" Inherits="SistemaGimnasios.Administracion.Enrrolamiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
              <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Enrrolamiento Persona <small>Debes realizar todos los pasos para el enrrolamiento de la persona</small></h2>
                    <ul class="nav navbar-right panel_toolbox">
                      <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                      </li>
                      <li><a class="close-link"><i class="fa fa-close"></i></a>
                      </li>
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                     <div id="demo-form2" class="form-horizontal form-label-left">

                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Nombre <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox runat="server" ID="txtNombre" required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name">Apellido <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox runat="server" ID="txtApellido" required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name">RUT <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox runat="server" ID="txtRut" required="required" CssClass="form-control col-md-7 col-xs-12" placeHolder="RUT: XXXXXXXX-X"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Plan Entrenamiento<span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:DropDownList runat="server" ID="ddlPlanes" CssClass="form-control col-md-7 col-xs-12" required="required" OnDataBound="ddlPlanes_DataBound"></asp:DropDownList>
                        </div>
                      </div>
                      <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3">
                            <asp:Button ID="btnGrabarDatos" CssClass="btn btn-success" Text="Grabar" runat="server"  OnClick="btnGrabarDatos_Click"/>
                        </div>
                      </div>

                    </div>

                   <div id="divError" class="alert alert-success alert-dismissible fade in" role="alert">
                    <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">×</span>
                    </button>
                    <strong>Información Adicional:</strong><br /> <asp:Label ID="lblinformacion" runat="server"></asp:Label>
                  </div>

                    </div>
                    </div>
                  </div>
        </div>
</asp:Content>
