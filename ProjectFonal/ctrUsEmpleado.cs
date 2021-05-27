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
            //Inicializamos el boton
            btnBuscarEmpleado.Enabled = false;

            //Metodos para tener los datos actualizados
            refrescarcombobox();
            //Metodo para tener los datos actualizados
            refrescardatagrid();

        }

        //BLOQUE BUSCAR EMPLEADO


        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            string Abuscar = cboBuscarEmpleado.Text;

            try
            {
                //Seleccionamos un empleado en especifico  guardado en la BD para mostrarlos en un datagridview
                string traer_todo = "SELECT * FROM tblEmpleado WHERE strNombre = '" + Abuscar + "'";
                dtgvProveedor.DataSource = cn.mostrarTabla(traer_todo);
                
                //Metodos para tener los datos actualizados
                refrescarcombobox();
                //Método para limpiar
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro tal empleado " + ex);
            }
        }

        //BLOQUE REGISTRAR EMPLEADO
        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {

        }

        //Para limpiar los campos
        public void limpiarCampos()
        {

            //Registro
            txtIdentificacionEmpleado.Clear();
            txtNombreEmpleado.Clear();
            txtApellidoEmpleado.Clear();
            txtDireccionEmpleado.Clear();
            txtTelefonoEmpleado.Clear();
            //Modificar
            txtModificarIdentificacionEmpleado.Clear();
            txtModificarNombreEmpleado.Clear();
            txtModificarApellidoEmpleado.Clear();
            txtModificarDireccionEmpleado.Clear();
            txtModificarTelefonoEmpleado.Clear();
        }

        private void refrescarcombobox()
        {
            //Llenamos los comboboxes
            try
            {
                string BuscarProveedor = "SELECT idCedula,strNombre FROM tblEmpleado ";
                cboBuscarEmpleado.DataSource = cn.mostrarTabla(BuscarProveedor);
                //Para mostrar en el Combo los nombres
                cboBuscarEmpleado.DisplayMember = "strNombre";
                //Para utilizar el nit al momento de hacer la consulta
                cboBuscarEmpleado.ValueMember = "idCedula";

                string EliminarProveedor = "SELECT idCedula,strNombre FROM tblEmpleado ";
                cboEliminarEmpleado.DataSource = cn.mostrarTabla(EliminarProveedor);
                //Para mostrar en el Combo los nombres
                cboEliminarEmpleado.DisplayMember = "strNombre";
                //Para utilizar el nit al momento de hacer la consulta
                cboEliminarEmpleado.ValueMember = "idCedula";

                string ModificarProveedor = "SELECT idCedula,strNombre FROM tblEmpleado ";
                cboModificarEmpleado.DataSource = cn.mostrarTabla(ModificarProveedor);
                //Para mostrar en el Combo los nombres
                cboModificarEmpleado.DisplayMember = "strNombre";
                //Para utilizar el nit al momento de hacer la consulta
                cboModificarEmpleado.ValueMember = "idCedula";

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo elimar al proveedor" + ex.Message);

            }
        }

        private void refrescardatagrid()
        {

            //Mantenemos el datagrid refrescado
            try
            {
                //Mantenemos la tabla refrescada               
                string mostrarTabla = "SELECT * from tblEmpleado";
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
