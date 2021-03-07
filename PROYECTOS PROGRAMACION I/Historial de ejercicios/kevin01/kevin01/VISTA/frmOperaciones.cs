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
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {

                int suma;

                suma = Convert.ToInt32(txtDato1.Text) + Convert.ToInt32(txtDato2.Text);

                txtResultado.Text = suma.ToString();

            }
            catch (Exception Ex)
            {

                MessageBox.Show("ahh tus datos no son correctos revisa" + Ex.ToString());

            }



            //txtResultado.Text = txtDato1.Text + txtDato2.Text;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {

                int resta;

                resta = Convert.ToInt32(txtDato1.Text) - Convert.ToInt32(txtDato2.Text);

                txtResultado.Text = resta.ToString();

            }
            catch (Exception Ex)
            {

                MessageBox.Show("ahh tus datos no son correctos revisa" + Ex.ToString());
            }
        }

        private void txtDato1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmOperaciones_Load(object sender, EventArgs e)
        {

        }
    }
}