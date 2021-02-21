using kevin01.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kevin01.NEGOCIO
{
    class clsLogin
    {

        clsListaUsuarios cls = new clsListaUsuarios();
       



        Login log = new Login();

        public int accceso(Login log) {

            int estado = 0;
            for (int i=0;i< cls.user.Length;i++) {
                if (log.Usuario.Equals(cls.user[i]) && log.Password.Equals(cls.pass[i]))
                {
                }
                estado = 1;

            }

            return estado;

        }
        

    }
}
