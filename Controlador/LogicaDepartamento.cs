using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class LogicaDepartamento
    {
        private static DCExamenDataContext dc { get; set; }

        public static void saveDepartamentos(TBL_DEPARTAMENTO _infoDepartamento)
        {
            try
            {
                dc = new DCExamenDataContext();
                _infoDepartamento.DEP_STATUS = 'A';
                _infoDepartamento.DEP_ADD = DateTime.Now;
                dc.TBL_DEPARTAMENTO.InsertOnSubmit(_infoDepartamento);
                dc.SubmitChanges();


            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
