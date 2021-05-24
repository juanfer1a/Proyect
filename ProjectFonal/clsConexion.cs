using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias necesarias
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectFonal
{
    class clsConexion
    {
        string conecxionSting;

        //Metodo para ejecutar las consultas en la DB
        public void conectarComando(string comando)
        {
            //Conectamos con el servidos
            conecxionSting = "Data Source=sql5097.site4now.net;Initial Catalog=db_a74d2a_projectfinal;Persist Security Info=True;User ID=db_a74d2a_projectfinal_admin;Password=parcero89";
            SqlConnection conexion = new SqlConnection(conecxionSting);
            try
            {
                //Abrimos la conexión con la DB
                conexion.Open();
                MessageBox.Show("Se realizo la conexión");
                //Ejecutamos los comandos
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                //Cerramos la conexión con la DB
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se realizo la conexión" + ex.Message);

            }

        }

        //Metodo para mostrar los datos en algún componente necesario
        public DataTable MostrarTabla(string comando)
        {
            //Conectamos con el servidos
            conecxionSting = "Data Source=sql5097.site4now.net;Initial Catalog=db_a74d2a_projectfinal;Persist Security Info=True;User ID=db_a74d2a_projectfinal_admin;Password=parcero89";
            SqlConnection conexion = new SqlConnection(conecxionSting);

            SqlCommand cmd = new SqlCommand(comando, conexion);
            //Estamos tomando la conexión y la consultada de la variable "traer todo"
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            //Representación de una tabla en memoria 
            DataTable tabla = new DataTable();
            //llenamos tabla con los datos consigandos en la data 
            data.Fill(tabla);

            return tabla;
        }


        
    }
}
