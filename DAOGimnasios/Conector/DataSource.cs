using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOGimnasios.Conector
{
    public class DataSource
    {
        public static string coneccionPrimaria;
        public static void setParametros(string conn1)
        {
            coneccionPrimaria = conn1;
        }
        public string ConeccionPrimaria { get { return coneccionPrimaria; } }
    }
}
