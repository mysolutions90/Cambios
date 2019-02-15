using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Controlador;

namespace Controlador
{
    public class logicaEmpleado
    {
        private static DCExamenDataContext dc { get; set; }

        public static void saveEmpleado(Empleado_Cacuango _infoEmpleado)
        {
            try
            {
                dc = new DCExamenDataContext();
                _infoEmpleado.estado = 'A';


                dc.empleado(_infoEmpleado.nombre,_infoEmpleado.apellidos,_infoEmpleado.cedula, _infoEmpleado.estado);
                dc.SubmitChanges();


            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}