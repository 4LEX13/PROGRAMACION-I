using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kevin01.NEGOCIO;
using kevin01.VISTA;

namespace kevin01

{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Login log = new Login();

            log.Usuario = txtUser.Text;
            log.Password = txtPassword.Text;



            clsLogin clsL = new clsLogin();

            int variabledeevaluacion=  clsL.accceso(log);

            if (variabledeevaluacion== 1) {

                MessageBox.Show("welcome");
                frmMenu frm = new frmMenu();
                frm.usuarioEstado = txtUser.Text;
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("false");
            }
        }

        private void btnCanselar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
