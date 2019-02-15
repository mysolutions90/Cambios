using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Controlador;

namespace Examen
{
    public partial class WfmDepartamento : System.Web.UI.Page
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
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    messageError += "La descripcion campo obligatorio \n";
                }
                if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    messageError += "La direccion campo obligatorio \n";
                }
                if (!string.IsNullOrEmpty(messageError))
                {
                    LblMensaje.Text = messageError;
                    return;
                }

                TBL_DEPARTAMENTO depart = new TBL_DEPARTAMENTO();
                
                depart.DEP_DESCRIPCION = txtDescripcion.Text.ToUpper();
                depart.DEP_DIRECCION = txtDireccion.Text.ToUpper();
                LogicaDepartamento.saveDepartamentos(depart);
                LblMensaje.Text = "Registro Guardado Correctamente";
            }
            catch (Exception ex)
            {
                LblMensaje.Text = ex.Message;


            }
        }
    }
}