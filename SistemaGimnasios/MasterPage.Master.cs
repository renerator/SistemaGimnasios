using DAOGimnasios.Objetos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaGimnasios
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-ES");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                if (Session["nombre"] != null)
                {
                    lblUsuario.Text = Session["nombre"].ToString();
                    CargarMenu();
                }
                else
                {
                    Session["NoActivo"] = 1;
                    FormsAuthentication.SignOut();
                    Session.Clear();
                    Session.Abandon();
                    Session.RemoveAll();
                    Response.Redirect(ResolveUrl("~/") + "Login.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Response.Redirect(string.Format("~/AccesoDenegado.aspx?error= {0} desde la URL={1}", ex.Message, HttpContext.Current.Request.Url.AbsoluteUri), false);
            }

        }

        private void CargarMenu()
        {
            try
            {
                var menulit = string.Empty;
                var datosMenu = new DAOGimnasios.Control.Control();
                var datosUsuario = (ObjetoUsuarios)HttpContext.Current.Session["DatosUsuario"];
                var menu = datosMenu.MenuUsuario(datosUsuario.IdPerfil);
                if (menu.Count > 0)
                {
                    var urlMenu = datosMenu.MenuUsuario(datosUsuario.IdPerfil).ToList();
                    menulit = menulit + "<div id='sidebar-menu' class='main_menu_side hidden-print main_menu'><div class='menu_section'><h3>Menú Principal</h3><ul class='nav side-menu'>";
                    for (var i = 0; i <= urlMenu.Count; i++)
                    {
                        if (i > urlMenu.Count)
                        {
                            break;
                        }
                        menulit = menulit + string.Format("<li><a><i class='{0}'></i>{1}<span class='fa fa-chevron-down'></span></a>", urlMenu[i].Clase, urlMenu[i].NombreModulo);
                        var nombreModulo = urlMenu[i].NombreModulo;
                        menulit = menulit + "<ul class='nav child_menu'>";
                        for (var x = 0; x <= i; x++)
                        {
                            if (i >= urlMenu.Count)
                            {
                                break;
                            }
                            if (nombreModulo == urlMenu[i].NombreModulo)
                            {
                                menulit = menulit + string.Format("<li><a href='../{1}'>{0}</a></li>", urlMenu[i].NombreMenu, urlMenu[i].Pagina);
                                i++;
                            }
                            else
                            {
                                i--;
                                break;
                            }
                        }
                        menulit = menulit + "</ul>";
                        menulit = menulit + "</li>";
                    }
                    menulit = menulit + "</ul></div></div>";
                    liMenu.Text = menulit;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
     }
}