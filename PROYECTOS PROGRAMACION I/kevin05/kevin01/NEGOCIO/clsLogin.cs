using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kevin01.NEGOCIO
{
    class clsLogin
    {
        Login log = new Login();

        public int accceso(Login log) {

            int estado = 0;
            if (log.Usuario.Equals("kevin") && log.Password.Equals("123"))
            {
                estado = 1;

            }

            return estado;

        }
        

    }
}
