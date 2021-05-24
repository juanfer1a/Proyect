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
    public partial class ctrlUsProveedor : UserControl
    {
        //Llamamos la clase conexion
        clsConexion cn = new clsConexion();
        public ctrlUsProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text != "" && txtNitProveedor.Text != "" && txtTelefonoProveedor.Text != "" & txtCtaBancariaProveedor.Text != "" )
            {

                try
                {
                    string guardarUsuario = "INSERT INTO tblProveedor([idNit],[strNombre],[intCuentaBancaria],[intTelefono])" + "values('" + txtNitProveedor.Text + "','" + txtNombreProveedor.Text + "','" + txtCtaBancariaProveedor.Text + "','" + txtTelefonoProveedor.Text + "')";
                    cn.conectarComando(guardarUsuario);

                    MessageBox.Show("Se guardo la informacion");

                    //Mantenemos la tabla refrescada               
                    string mostrarTabla = "SELECT * from tblProveedor";
                    cn.MostrarTabla(mostrarTabla, dtgvProveedor);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se guardo la informacion" + ex.Message);

                }
            }
        }
    }
}
