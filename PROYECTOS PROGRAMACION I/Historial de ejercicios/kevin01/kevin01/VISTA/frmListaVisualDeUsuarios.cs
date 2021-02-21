using kevin01.DAO;
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
    public partial class frmListaVisualDeUsuarios : Form
    {
        public frmListaVisualDeUsuarios()
        {
            InitializeComponent();
        }

        private void frmListaVisualDeUsuarios_Load(object sender, EventArgs e)
        {
            clsListaUsuarios cls = new clsListaUsuarios();

            foreach (var iteracion in cls.user)
            {

                dataGridView1.Rows.Add(iteracion.ToString());
            }

        }
    }
}
