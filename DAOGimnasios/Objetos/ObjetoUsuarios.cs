using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOGimnasios.Objetos
{
    public class ObjetoUsuarios
    {
        private int _idUsuario;
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private string _nombre;
        /// <summary>
        /// Nombre de la persona
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _rut;
        /// <summary>
        /// Nombre de la persona
        /// </summary>
        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }
        private string _password;
        /// <summary>
        /// Password de la persona
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _nombrePerfil;
        /// <summary>
        /// Nombre del perfil del usuario
        /// </summary>
        public string NombrePerfil
        {
            get { return _nombrePerfil; }
            set { _nombrePerfil = value; }
        }
        private int _idPerfil;
        public int IdPerfil
        {
            get { return _idPerfil; }
            set { _idPerfil = value; }
        }
    }
}
