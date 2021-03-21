using kevin01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kevin01.DAO
{
    class clsDUserLis
    {
        public List<UserLis> cargarDatoUserLis()
        {
            List<UserLis> lista;


            using (ProgramacionEntities db = new ProgramacionEntities())
            {

                lista = db.UserLis.ToList();

              

            }


            return lista;
        }

        internal void saveDatosUser(UserLis userLis)
        {
            throw new NotImplementedException();
        }

        //public void saveDatoUser(String Nombre, String Apellido, int Edad, String Pass)
        //{
        //    try
        //    {
        //        using (ProgramacionEntities db = new ProgramacionEntities())
        //        {

        //            UserLis userLis = new UserLis();

        //            userLis.NombreUsuario = Nombre;
        //            userLis.Apellido = Apellido;
        //            userLis.Edad = Edad;
        //            userLis.Pass = Pass;

        //            db.UserLis.Add(userLis);
        //            db.SaveChanges();

        //            MessageBox.Show("save");

        //        }
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.ToString());
        //    }

        //}
    }

    public void SaveDatosUser(UserLis user)
    {
        try
        {
            using (ProgramacionEntities db = new ProgramacionEntities())
            {

                UserLis userLis = new UserLis();

                userLis.NombreUsuario = user.NombreUsuario;
                userLis.Apellido = user.Apellido;
                userLis.Edad = user.Edad;
                userLis.Pass = user.Pass;

                db.UserLis.Add(userLis);
                db.SaveChanges();

                MessageBox.Show("save");

            }
        }
        catch (Exception Ex)
        {
            MessageBox.Show(Ex.ToString());
        }

    }
    public void deleteUser(int iD) { 

     try
            {
                using (ProgramacionEntities db = new ProgramacionEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
    UserLis userLisddd = db.UserLis.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();

    //userLisddd = db.UserLis.Find(Eliminar);
    db.UserLis.Remove(userLisddd);
                    db.SaveChanges();
                }
            }
            catch (Exception Ex)
{
    MessageBox.Show(Ex.ToString());
}

}

}