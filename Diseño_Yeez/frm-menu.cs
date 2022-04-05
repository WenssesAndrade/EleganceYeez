using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_Yeez
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          cventas cv = new cventas();
            cv.Show();

        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            cinventario ci = new cinventario();
            ci.Show();
        }

        private void btncitas_Click(object sender, EventArgs e)
        {
            ccitas cc = new ccitas();
            cc.Show();
        }

        private void pbventas_Click(object sender, EventArgs e)
        {
            cventas cv = new cventas();
            cv.Show();

        }

        private void pbinventario_Click(object sender, EventArgs e)
        {
            cinventario ci = new cinventario();
            ci.Show();
        }

        private void pbcitas_Click(object sender, EventArgs e)
        {
            ccitas cc = new ccitas();
            cc.Show();
        }
    }
}
