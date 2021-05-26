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
    public partial class ctrUsEmpleado : UserControl
    {
        //Llamamos la clase conexion
        clsConexion CN = new clsConexion();

        public ctrUsEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            string hola;
        }
    }
}
