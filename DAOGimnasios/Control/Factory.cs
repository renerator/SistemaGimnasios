using DAOGimnasios.Conector;
using DAOGimnasios.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOGimnasios.Control
{
    internal class Factory
    {
        public List<ObjetoUsuarios> Login(string rutUsuario, string pass)
        {
            var listado = new List<ObjetoUsuarios>();
            var data = new DBCnn().EjecutarProcedimientoAlmacenado("SET_LOGIN", new System.Collections.Hashtable()
                                                                         {
                                                                            {"rut",rutUsuario},
                                                                            {"pass",pass }
                                                                         });
            if (data.Rows.Count > 0)
            {
                if (data.Rows.Count > 0)
                {
                    for (var i = 0; i < data.Rows.Count; i++)
                    {

                        var validador = new object();
                        var resultadoListado = new ObjetoUsuarios();
                        validador = data.Rows[i].Field<object>("idusuarios");
                        resultadoListado.IdUsuario = validador != null ? data.Rows[i].Field<int>("idusuarios") : -1;

                        validador = data.Rows[i].Field<object>("RutUsuario");
                        resultadoListado.Rut = validador != null ? data.Rows[i].Field<string>("RutUsuario") : string.Empty;

                        validador = data.Rows[i].Field<object>("password");
                        resultadoListado.Password = validador != null ? data.Rows[i].Field<string>("password") : string.Empty;

                        validador = data.Rows[i].Field<object>("NombreUsuario");
                        resultadoListado.Nombre = validador != null ? data.Rows[i].Field<string>("NombreUsuario") : string.Empty;

                        validador = data.Rows[i].Field<object>("idPerfil");
                        resultadoListado.IdPerfil = validador != null ? data.Rows[i].Field<int>("idPerfil") : -1;

                        validador = data.Rows[i].Field<object>("NombrePerfil");
                        resultadoListado.NombrePerfil = validador != null ? data.Rows[i].Field<string>("NombrePerfil") : string.Empty;
                        listado.Add(resultadoListado);
                    }
                }

            }

            return listado;
        }
        /// <summary>
        /// Listado Menu Usuario segun su perfil
        /// </summary>
        /// <param name="idPerfil">Id Perfil del usuario que se conecta</param>
        /// <returns>Listado con Menu y paginas de acceso al que tenga permiso el usuario segun su perfil</returns>
        public List<ObjetoMenu> Menu(int idPerfil)
        {
            var listado = new List<ObjetoMenu>();
            var data = new DBCnn().EjecutarProcedimientoAlmacenado("SET_MENU", new System.Collections.Hashtable()
                                                                         {
                                                                            {"idPerfil",idPerfil}
                                                                         });
            if (data.Rows.Count > 0)
            {
                if (data.Rows.Count > 0)
                {
                    for (var i = 0; i < data.Rows.Count; i++)
                    {

                        var validador = new object();
                        var resultadoListado = new ObjetoMenu();
                        validador = data.Rows[i].Field<object>("NombreMenu");
                        resultadoListado.NombreMenu = validador != null ? data.Rows[i].Field<string>("NombreMenu") : string.Empty;

                        validador = data.Rows[i].Field<object>("clase");
                        resultadoListado.Clase = validador != null ? data.Rows[i].Field<string>("clase") : string.Empty;

                        validador = data.Rows[i].Field<object>("Pagina");
                        resultadoListado.Pagina = validador != null ? data.Rows[i].Field<string>("Pagina") : string.Empty;

                        validador = data.Rows[i].Field<object>("NombreModulo");
                        resultadoListado.NombreModulo = validador != null ? data.Rows[i].Field<string>("NombreModulo") : string.Empty;

                        listado.Add(resultadoListado);
                    }
                }

            }

            return listado;
        }
        /// <summary>
        /// Metodo que envia los Planes en listado
        /// </summary>
        /// <returns>Objeto Tipo Planes con la informacion </returns>
        public List<ObjetoPlanes> ListadoPlanes()
        {
            var listado = new List<ObjetoPlanes>();
            var data = new DBCnn().EjecutarProcedimientoAlmacenado("GET_PLANES", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                if (data.Rows.Count > 0)
                {
                    for (var i = 0; i < data.Rows.Count; i++)
                    {

                        var validador = new object();
                        var resultadoListado = new ObjetoPlanes();
                        validador = data.Rows[i].Field<object>("idPLan");
                        resultadoListado.IdPlan = validador != null ? data.Rows[i].Field<int>("idPlan") : -1;

                        validador = data.Rows[i].Field<object>("NombrePlan");
                        resultadoListado.NombrePlan = validador != null ? data.Rows[i].Field<string>("NombrePlan") : string.Empty;

                        validador = data.Rows[i].Field<object>("VigenciaPlan");
                        resultadoListado.VigenciaPlan = validador != null ? data.Rows[i].Field<string>("VigenciaPlan") : string.Empty;

                        validador = data.Rows[i].Field<object>("ValorPlan");
                        resultadoListado.ValorPlan = validador != null ? data.Rows[i].Field<decimal>("ValorPlan") : -1;

                        validador = data.Rows[i].Field<object>("Activo");
                        resultadoListado.Activo = validador != null ? data.Rows[i].Field<bool>("Activo") : false;

                        listado.Add(resultadoListado);
                    }
                }

            }

            return listado;

        }
    }
    }
