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
            //Inicializamos el boton
            btnBuscarProveedor.Enabled = false;

            //Mantenemos el datagrid refrescado
            try
            {
                //Mantenemos la tabla refrescada               
                string mostrarTabla = "SELECT * from tblProveedor";
                //Llenamos el datagrid con la información
                dtgvProveedor.DataSource = (cn.MostrarTabla(mostrarTabla));
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo mostrar la información en el " + dtgvProveedor + "" + ex.Message);
            }

            //Llenamos los comboboxes
            try
            {
                string BuscarProveedor = "SELECT idNit,strNombtr FROM tblProveedor ";
                cboBuscarProveedor.DataSource = (cn.MostrarTabla(BuscarProveedor));
                //Para mostrar en el Combo los nombres
                cboBuscarProveedor.DisplayMember = "strNombtr";
                //Para utilizar el nit al momento de hacer la consulta
                cboBuscarProveedor.ValueMember = "idNit";

                string EliminarProveedor = "SELECT idNit,strNombtr FROM tblProveedor ";
                cboEliminarProveedor.DataSource = (cn.MostrarTabla(EliminarProveedor));
                //Para mostrar en el Combo los nombres
                cboEliminarProveedor.DisplayMember = "strNombtr";
                //Para utilizar el nit al momento de hacer la consulta
                cboEliminarProveedor.ValueMember = "idNit";

                string ModificarProveedor = "SELECT idNit,strNombtr FROM tblProveedor ";
                cboModificarProveedor.DataSource = (cn.MostrarTabla(ModificarProveedor));
                //Para mostrar en el Combo los nombres
                cboModificarProveedor.DisplayMember = "strNombtr";
                //Para utilizar el nit al momento de hacer la consulta
                cboModificarProveedor.ValueMember = "idNit";

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo elimar al proveedor" + ex.Message);

            }
        }

        //BLOQUE BUSCAR PROVEEDOR

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            string Abuscar=cboBuscarProveedor.Text; 
            try
            {
                //Seleccionamos un proveedor en especifico  guardado en la BD para mostrarlos en un datagridview
                string traer_todo = "SELECT * FROM tblProveedor WHERE strNombtr = '" + Abuscar + "'";
                dtgvProveedor.DataSource= cn.MostrarTabla(traer_todo);

                //Método para limpiar
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro tal proveedor " + ex.Message);
                
            }
        }

        //BLOQUE REGISTRAR PROVEEDOR

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen números
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtNitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCtaBancariaProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text != "" && txtNitProveedor.Text != "" && txtTelefonoProveedor.Text != "" & txtCtaBancariaProveedor.Text != "")
            {

                try
                {
                    string guardarUsuario = "INSERT INTO tblProveedor([idNit],[strNombtr],[intC_Bancaria],[intTelefono])" + "values('" + txtNitProveedor.Text + "','" + txtNombreProveedor.Text + "','" + txtCtaBancariaProveedor.Text + "','" + txtTelefonoProveedor.Text + "')";
                    cn.conectarComando(guardarUsuario);

                    MessageBox.Show("Se guardo la informacion");

                    //Mantenemos la tabla refrescada               
                    string mostrarTabla = "SELECT * from tblProveedor";
                    //Llenamos el datagrid con la información
                    dtgvProveedor.DataSource = (cn.MostrarTabla(mostrarTabla));

                    //Método para limpiar
                    limpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se guardo la informacion " + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Favor llenar todos los campos");
            }
        }

        //BLOQUE MODIFICAR

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Mostramos y ocultar panel necesarios          
            if (pnlModificarProveedor.Visible == false)
            {
                pnlModificarProveedor.Visible = true;
            }
            else
            {
                pnlModificarProveedor.Visible = false;
            }
            pnlEliminarProveedor.Visible = false;
        }

        private void txtModificarNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen números
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtModificarNitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarCtaBancariaProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            //BD
        }

        private void btnCancelarModificarProveedor_Click(object sender, EventArgs e)
        {
            pnlModificarProveedor.Visible = false;
        }

        //BLOQUE ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Mostramos y ocultar panel necesarios
            if (pnlEliminarProveedor.Visible == false)
            {
                pnlEliminarProveedor.Visible = true;
            }
            else
            {
                pnlEliminarProveedor.Visible = false;
            }
            pnlModificarProveedor.Visible = false;
        }

        private void btnEliminarProveedor_Click_1(object sender, EventArgs e)
        {
            //string borar_usu = "DELETE FROM Libro Where Codigo='" + pedir + "'";
        }

        private void btnCancelarEliminarProveedor_Click(object sender, EventArgs e)
        {
            pnlEliminarProveedor.Visible = false;
        }

       
        //Para limpiar los campos
        public void limpiarCampos()
        {

            //Registro
            txtNombreProveedor.Clear();
            txtNitProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtCtaBancariaProveedor.Clear();
            //Modificar
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Habilitamos el btnBuscarProveedor cuando escojan alguna opcion
            if (true)
            {
                btnBuscarProveedor.Enabled = true;
            }
            else
            {
                btnBuscarProveedor.Enabled = false;
            }

        }
    }
}
