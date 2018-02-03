<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="SistemaGimnasios.Administracion.Planes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../JsWeb/Administracion/Planes.js"></script>
        <div class="row">
              <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Planes de Entrenamiento <small>en esta sección, veras un listado de los planes que tienes. Ingresa un nuevo plan o Edita los planes que ya tienes</small></h2>
                    <ul class="nav navbar-right panel_toolbox">
                      <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                      </li>
                      <li><a class="close-link"><i class="fa fa-close"></i></a>
                      </li>
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">

                      <asp:GridView ID="grvResultado" runat="server" CssClass="table" AutoGenerateColumns="false">
                           <Columns>
                                <asp:TemplateField HeaderText="ID" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblidPlan" runat="server" Text='<%# Eval("idPlan") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nombre Plan">
                                    <ItemTemplate>
                                        <asp:Label ID="lblNombrePlan" runat="server" Text='<%# Eval("NombrePlan") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Valor Plan">
                                    <ItemTemplate>
                                        <asp:Label ID="lblValorPlan" runat="server" Text='<%# Eval("ValorPlan") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Vigencia Plan">
                                    <ItemTemplate>
                                        <asp:Label ID="lblVigencia" runat="server" Text='<%# Eval("VigenciaPlan") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Opciones">
                                    <ItemTemplate>
                                         <asp:ImageButton ID="imgEditar" runat="server" ImageUrl="~/Utilitarios/Recursos/onebit_20.png" Width="16px" Height="16px"
                                            ToolTip="Editar Plan" onclick="imgEditar_Click"/>
                                    </ItemTemplate>
                                    <ItemStyle Width="100px" />
                                </asp:TemplateField>
                            </Columns>
                    </asp:GridView>
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
