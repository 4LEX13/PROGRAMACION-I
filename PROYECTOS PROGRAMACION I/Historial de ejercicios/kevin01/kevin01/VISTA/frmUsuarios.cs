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
                }catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (ProgramacionEntities db = new ProgramacionEntities())
                {

                    UserLis userLisddd = new UserLis();
                    int Eliminar = Convert.ToInt32(txtId.Text);
                    userLisddd = db.UserLis.Find(Eliminar);
                    db.UserLis.Remove(userLisddd);
                    db.SaveChanges();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
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
    }
    }
