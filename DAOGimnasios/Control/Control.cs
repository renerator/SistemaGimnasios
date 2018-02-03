using DAOGimnasios.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOGimnasios.Control
{
    public class Control
    {
        private Factory _dtFac = new Factory();
        public List<ObjetoUsuarios> Login(string rut, string pass)
        {
            return _dtFac.Login(rut, pass);
        }

        public List<ObjetoMenu> MenuUsuario(int idPerfil)
        {
            return _dtFac.Menu(idPerfil);
        }

        public List<ObjetoPlanes> CargaListadoPlanes()
        {
            return _dtFac.ListadoPlanes();
        }
        
    }
}
