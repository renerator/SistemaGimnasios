using DAOGimnasios.Conector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SistemaGimnasios
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            string cadenaConexion1 = System.Configuration.ConfigurationManager.AppSettings["CONEXION"];
            DataSource.setParametros(cadenaConexion1);
        }
    }
}