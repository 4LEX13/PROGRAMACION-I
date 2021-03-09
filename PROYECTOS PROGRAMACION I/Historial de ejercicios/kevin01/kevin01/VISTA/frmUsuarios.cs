using kevin01.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kevin01.VISTA
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            carga();
        }

        void carga()
            
        {
            dataGridView1.Rows.Clear();
            using (ProgramacionEntities db = new ProgramacionEntities())
            {

                var lista = db.UserLis.ToList();

                foreach (var iteracion in lista)
                {
                    dataGridView1.Rows.Add(iteracion.Id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);


                }


            }




        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (ProgramacionEntities db = new ProgramacionEntities())
                {

                    UserLis userLis = new UserLis();

                    userLis.NombreUsuario = txtNombreUsuario.Text;
                    userLis.Apellido = txtApellido.Text;
                    userLis.Edad = Convert.ToInt32(txtEdad.Text);
                    userLis.Pass = txtPass.Text;

                    db.UserLis.Add(userLis);
                    db.SaveChanges();

                    MessageBox.Show("save");

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            carga();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (ProgramacionEntities db = new ProgramacionEntities())
                {
                    int Eliminar = Convert.ToInt32(txtId.Text);
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
            carga();
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (ProgramacionEntities db = new ProgramacionEntities())
                {
                    int update = Convert.ToInt32(txtId.Text);
                    UserLis user = db.UserLis.Where(x => x.Id == 2).Select(x => x).FirstOrDefault();
                    //UserLis userLisddd = new UserLis();
                    //userLisddd = db.UserLis.Find(2);
                    user.NombreUsuario = txtNombreUsuario.Text;
                    user.Apellido = txtApellido.Text;
                    user.Edad = Convert.ToInt32(txtEdad.Text);
                    user.Pass = txtPass.Text;
                    db.SaveChanges();



                }
            } 
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }
            carga();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
    }
