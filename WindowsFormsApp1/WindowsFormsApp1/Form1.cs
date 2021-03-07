using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private object i;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //double dato = Convert.ToDouble(textBox1.Text);
            //if (dato < 6)
            //{

            //    label1.Text = "malo";

            //}
            //else if (dato >= 6 && dato < 7)
            //{

            //    label1.Text = "regular";

            //}else if (dato >=7 && dato < 8)
            //{

            //    label1.Text = "bueno";

            //}
            //else
            //{

            //    label1.Text = "excelente";


            for (int i = 0; i < 10; i++)
            {
                if (i == 6)

                    break;
            }
            {

                MessageBox.Show(i.ToString());

            }

            
        }
    }
}

