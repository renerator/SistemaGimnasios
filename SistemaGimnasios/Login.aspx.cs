using DAOGimnasios.Objetos;
using DAOGimnasios.Control;
using SistemaGimnasios.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace SistemaGimnasios
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["NoActivo"] != null)
                {
                    lblError.Text = "Por razones de seguridad se ha cerrado tu sesión, inicia sesión nuevamente";
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Text = string.Empty;
                }

            }
        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                var control = new DAOGimnasios.Control.Control();
                var datosUsuario = new ObjetoUsuarios();
                if (ValidaRutPersona.DigitoVerificador(txtRut.Text))
                {
                    
                        var usuario =  control.Login(txtRut.Text, txtContraseña.Text).ToList();
                        if (usuario.Count > 0)
                        {
                            foreach (var t in usuario)
                            {
                                datosUsuario.IdPerfil = t.IdPerfil;
                                datosUsuario.IdUsuario = t.IdUsuario;
                                datosUsuario.Nombre = t.Nombre;
                                Session.Add("IDDatosPersonales", t.IdUsuario);

                            }

                            Session["DatosUsuario"] = datosUsuario;
                            Session["nombre"] = datosUsuario.Nombre;
                            lblError.Visible = false;
                            Response.Redirect(FormsAuthentication.GetRedirectUrl(txtRut.Text, false), false);
                        }
                        else
                        {
                            lblError.Text = string.Format("Error: {0}", "Error de inicio de usuario, intentelo nuevamente");
                            lblError.Visible = true;
                        }
                    
                }
                else
                {
                    lblError.Text = string.Format("Error: {0}", "El Rut ha sido mal ingresado, verifiquelo nuevamente.");
                    lblError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = string.Format("Error: {0}", ex.Message);
                //throw;
            }
        }
    }
}