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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public String usuarioEstado;



        private void frmMenu_Load(object sender, EventArgs e)
        {
            label1.Text = usuarioEstado;

        }

        private void clickParaMasInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsercaDe frm = new frmAsercaDe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void arreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaVisualDeUsuarios frm = new frmListaVisualDeUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperaciones frmop = new frmOperaciones();
            frmop.MdiParent = this;
            frmop.btnResta.Enabled = false;
            frmop.Show();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperaciones frmop = new frmOperaciones();
            frmop.MdiParent = this;
            frmop.btnSuma.Enabled = false;
            frmop.Show();
        }
    }
}
