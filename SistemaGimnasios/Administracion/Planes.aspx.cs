using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Configuration;

namespace SistemaGimnasios.Administracion
{
    public partial class Planes : System.Web.UI.Page
    {
        private readonly DAOGimnasios.Control.Control _control = new DAOGimnasios.Control.Control();
        private DataSet _ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarPlanes();
        }

        protected void CargarPlanes()
        {
            var ds = _control.CargaListadoPlanes();
            grvResultado.DataSource = ds;
            grvResultado.DataBind();

        }

        protected void imgEditar_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton img = (ImageButton)sender;
            GridViewRow row = (GridViewRow)img.NamingContainer;
            var _lblidPlan = ((Label)(grvResultado.Rows[row.RowIndex].FindControl("lblidPlan")));
            
        }
    }
}