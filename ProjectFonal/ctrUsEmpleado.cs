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
        clsConexion cn = new clsConexion();

        public ctrUsEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpleado.Text != "" && txtApellidoEmpleado.Text != "" && txtIdentificacionEmpleado.Text != "" & txtDireccionEmpleado.Text != "" && txtTelefonoEmpleado.Text != "")
            {

                try
                {
                    string guardarUsuario = "INSERT INTO tblEmpleado([idCedula],[strNombre],[strApellido],[strDireccion],[intTelefono])" + "values('" + txtIdentificacionEmpleado.Text + "','" + txtNombreEmpleado.Text + "','" + txtApellidoEmpleado.Text + "','" + txtDireccionEmpleado.Text + "','" + txtTelefonoEmpleado.Text + "')";
                    cn.conectarComando(guardarUsuario);

                    MessageBox.Show("Se guardo la informacion");

                    //Mantenemos la tabla refrescada.               
                    string mostrarTabla = "SELECT * from tblEmpleado";
                    cn.MostrarTabla(mostrarTabla, dtgvEmpleado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se guardo la informacion" + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Por favor llene la totalidad de los campos");
            }
        }
    }
}
