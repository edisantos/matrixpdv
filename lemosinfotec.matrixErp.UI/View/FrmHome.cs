using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lemosinfotec.matrixErp.UI.View
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            lblHora.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();
            lblHora.Visible = true;
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
