using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using Modelo;

namespace Examen
{
    public partial class WfmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            verificarUsuario(txtUser.Text, txtPassword.Text);
        }
        private void verificarUsuario(string username, string password)
        {
            TBL_USUARIO user = new TBL_USUARIO();
            user = logicaUsuarios.obtenerUsuarioXLogin(username, password);
            if (user != null)
            {
                Response.Redirect(@"~\Default.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuario Incorrecto');</script>");
            }
        }
    }
}