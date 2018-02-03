using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOGimnasios.Objetos
{
    public class ObjetoMenu
    {
        private string _nombreModulo;
        private string _clase;
        private string _nombreMenu;
        private string _action;
        private string _pagina;
        private int _idMenu;

        public string Clase
        {
            get { return _clase; }
            set { _clase = value; }
        }
        public string NombreMenu
        {
            get { return _nombreMenu; }
            set { _nombreMenu = value; }
        }
        public string NombreModulo
        {
            get { return _nombreModulo; }
            set { _nombreModulo = value; }
        }
        public string Accion
        {
            get { return _action; }
            set { _action = value; }
        }
        public string Pagina
        {
            get { return _pagina; }
            set { _pagina = value; }
        }
        public int IdMenu
        {
            get { return _idMenu; }
            set { _idMenu = value; }
        }
    }
}
