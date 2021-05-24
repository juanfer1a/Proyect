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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Para abrir la ventana Menú
        frmMenu menu = new frmMenu();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            menu.Show();
            this.Hide();
        }
    }
}
