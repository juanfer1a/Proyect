using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFonal
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
            frmUsuarios usuarios = new frmUsuarios();

        private void txtUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            usuarios.Show();
        }
    }
}
