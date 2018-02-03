using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOGimnasios.Objetos
{
    public class ObjetoPlanes
    {

        private string _nombrePlan;
        private string _VigenciaPlan;
        private decimal _valorPlan;
        private bool _activo;
        private int _idPlan;

        public string NombrePlan
        {
            get { return _nombrePlan; }
            set { _nombrePlan = value; }
        }

        public string VigenciaPlan
        {
            get { return _VigenciaPlan; }
            set { _VigenciaPlan = value; }
        }

        public decimal ValorPlan
        {
            get { return _valorPlan; }
            set { _valorPlan = value; }
        }
        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
        public int IdPlan
        {
            get { return _idPlan; }
            set { _idPlan = value; }
        }


    }
}
