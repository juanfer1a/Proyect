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

            //Metodos para tener los datos actualizados
            refrescarcombobox();
            //Metodo para tener los datos actualizados
            refrescardatagrid();

          
        }

        //BLOQUE BUSCAR PROVEEDOR
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            string Abuscar=cboBuscarProveedor.Text; 

            try
            {
                //Seleccionamos un proveedor en especifico  guardado en la BD para mostrarlos en un datagridview
                string traer_todo = "SELECT * FROM tblProveedor WHERE strNombre = '" + Abuscar + "'";
                dtgvProveedor.DataSource= cn.mostrarTabla(traer_todo);

                //Metodos para tener los datos actualizados
                refrescarcombobox();
              

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
                    string guardarUsuario = "INSERT INTO tblProveedor([idNit],[strNombre],[intBancaria],[intTelefono])" + "values('" + txtNitProveedor.Text + "','" + txtNombreProveedor.Text + "','" + txtCtaBancariaProveedor.Text + "','" + txtTelefonoProveedor.Text + "')";
                    cn.conectarComando(guardarUsuario);

                    MessageBox.Show("Se guardo la informacion");

                    //Metodos para tener los datos actualizados
                    refrescarcombobox();
                    //Metodo para tener los datos actualizados
                    refrescardatagrid();

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
            try
            {
                //Para mosdificar el proveedor
                string modificar = cboModificarProveedor.Text;
                string modificarproveedor= "UPDATE tblProveedor set idNit ='"+txtModificarNitProveedor.Text+"' ,strNombre = '" + txtModificarNombreProveedor.Text+"',intTelefono = '"+txtModificarTelefonoProveedor.Text+"',intBancaria = '"+txtModificarCtaBancariaProveedor.Text+"' where strNombre = '"+modificar+"'";
                cn.conectarComando(modificarproveedor);

                //Metodos para tener los datos actualizados
                refrescarcombobox();
                //Metodo para tener los datos actualizados
                refrescardatagrid();
                //Limpiamos los textbox

                //Cerramos el panel
                pnlModificarProveedor.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo modificar los datos"+ ex.Message);
            }

        }

        private void btnCancelarModificarProveedor_Click(object sender, EventArgs e)
        {
            //Cerramos el panel
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
            try
            {
                //Para borrar el proveedor
                string Abuscar = cboEliminarProveedor.Text;
                string borrarproveedor = "DELETE FROM tblProveedor Where strNombre='" + Abuscar + "'";
                cn.conectarComando(borrarproveedor);

                //Metodos para tener los datos actualizados
                refrescarcombobox();
                //Metodos para tener los datos actualizados
                refrescardatagrid();

                //Cerramos el panel
                pnlEliminarProveedor.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo eliminar el proveedor"+ex.Message);
                
            }
           
        }

        private void btnCancelarEliminarProveedor_Click(object sender, EventArgs e)
        {
            //Cerramos el panel
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
            txtModificarNombreProveedor.Clear();
            txtModificarNitProveedor.Clear();
            txtModificarTelefonoProveedor.Clear();
            txtModificarCtaBancariaProveedor.Clear();
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

        private void refrescarcombobox() 
        {
            //Llenamos los comboboxes
            try
            {
                string BuscarProveedor = "SELECT idNit,strNombre FROM tblProveedor ";
                cboBuscarProveedor.DataSource = cn.mostrarTabla(BuscarProveedor);
                //Para mostrar en el Combo los nombres
                cboBuscarProveedor.DisplayMember = "strNombre";
                //Para utilizar el nit al momento de hacer la consulta
                cboBuscarProveedor.ValueMember = "idNit";

                string EliminarProveedor = "SELECT idNit,strNombre FROM tblProveedor ";
                cboEliminarProveedor.DataSource = cn.mostrarTabla(EliminarProveedor);
                //Para mostrar en el Combo los nombres
                cboEliminarProveedor.DisplayMember = "strNombre";
                //Para utilizar el nit al momento de hacer la consulta
                cboEliminarProveedor.ValueMember = "idNit";

                string ModificarProveedor = "SELECT idNit,strNombre FROM tblProveedor ";
                cboModificarProveedor.DataSource = cn.mostrarTabla(ModificarProveedor);
                //Para mostrar en el Combo los nombres
                cboModificarProveedor.DisplayMember = "strNombre";
                //Para utilizar el nit al momento de hacer la consulta
                cboModificarProveedor.ValueMember = "idNit";

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo elimar al proveedor" + ex.Message);

            }

        }

        private void refrescardatagrid() {

            //Mantenemos el datagrid refrescado
            try
            {
                //Mantenemos la tabla refrescada               
                string mostrarTabla = "SELECT * from tblProveedor";
                //Llenamos el datagrid con la información
                dtgvProveedor.DataSource = cn.mostrarTabla(mostrarTabla);
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo mostrar la información en el " + dtgvProveedor + "" + ex.Message);
            }


        }
    }
}
