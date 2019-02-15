using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class logicaUsuarios
    {
        private static DCExamenDataContext dc { get; set; }

        public static List<TBL_USUARIO> obtenerUsuarios()
        {
            try
            {
                dc = new DCExamenDataContext();
                var lista = dc.TBL_USUARIO.Where(usu => usu.USU_STATUS == 'A').OrderBy(usu => usu.USU_EMAIL).ToList();
                return lista;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public static TBL_USUARIO obtenerUsuarioXLogin(string user, string password)
        {
            try
            {
                dc = new DCExamenDataContext();
                var usuario = dc.TBL_USUARIO.FirstOrDefault(usu => usu.USU_STATUS == 'A'
                                                    && usu.USU_LOGIN.Equals(user)
                                                    && usu.USU_PASSWORD.Equals(password));
                return usuario;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }


        public static TBL_USUARIO obtenerUsuarioXId(int idUsuario)
        {
            try
            {
                dc = new DCExamenDataContext();
                var user = dc.TBL_USUARIO.FirstOrDefault(usu => usu.USU_STATUS == 'A');
                return user;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public static bool saveUser(TBL_USUARIO _usuario)
        {
            try
            {
                bool res = false;

                dc = new DCExamenDataContext();
                dc.TBL_USUARIO.InsertOnSubmit(_usuario);
                dc.SubmitChanges();
                return res;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

    }
}