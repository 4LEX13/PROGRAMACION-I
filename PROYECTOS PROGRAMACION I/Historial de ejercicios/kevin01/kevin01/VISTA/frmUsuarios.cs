using kevin01.DAO;
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
            clear();
        }

        void clear()
        {
            txtId.Clear();
            txtNombreUsuario.Clear(); ;
            txtApellido.Clear();
            txtEdad.Clear();
            txtPass.Clear();


        }

        void carga()
            
        {
            dtgLiataUsuarios.Rows.Clear();
            clsDUserLis clsDUserLis = new clsDUserLis();
            List<UserLis> Lista = clsDUserLis.cargarDatoUserLis();

            foreach (var iteracion in Lista)
            {
                dtgLiataUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);


            }




        }




        private void button1_Click(object sender, EventArgs e)
        {
            clsDUserLis clsDUserLis = new clsDUserLis();
            //clsDUserLis.saveDatoUser(txtNombreUsuario.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), txtPass.Text);
            UserLis userLis = new UserLis();
            userLis.NombreUsuario = txtNombreUsuario.Text;
            userLis.Apellido = txtApellido.Text;
            userLis.Edad = Convert.ToInt32(txtEdad.Text);
            userLis.Pass = txtPass.Text;
            clsDUserLis.saveDatosUser(userLis);
            
            carga();
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsDUserLis user = new clsDUserLis();
            user.deleteUer();
            carga();
            clear();
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
            clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void dtgLiataUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgLiataUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgLiataUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtgLiataUsuarios.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtgLiataUsuarios.CurrentRow.Cells[3].Value.ToString();
            String Pass = dtgLiataUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtId.Text = Id;
            txtNombreUsuario.Text = Nombre;
            txtApellido.Text = Apellido;
            txtEdad.Text = Edad;
            txtPass.Text = Pass;
        }
    }
    }
