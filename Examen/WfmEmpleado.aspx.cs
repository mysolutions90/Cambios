using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Controlador;

namespace Examen
{
    public partial class WfmEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            try
            {
                var messageError = "";
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    messageError += "La descripcion campo obligatorio \n";
                }
                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    messageError += "La direccion campo obligatorio \n";
                }
                if (!string.IsNullOrEmpty(messageError))
                {
                    LblMensaje.Text = messageError;
                    return;
                }

                Empleado_Cacuango depart = new Empleado_Cacuango();
                //depart.id = int.Parse(txtid.Text);
                depart.nombre = txtNombre.Text.ToUpper();
                depart.apellidos = txtApellido.Text.ToUpper();
                depart.cedula = txtCedula.Text;
                
                logicaEmpleado.saveEmpleado(depart);
                LblMensaje.Text = "Registro Guardado Correctamente";
            }
            catch (Exception ex)
            {
                LblMensaje.Text = ex.Message;


            }
        }
    }
}