using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Drawing;

namespace Drogueria_proyecto
{
    //Clase para realizar la conexion a sql server
    public class cls_Conexion
    {
        public static string conexion = "Data Source=localhost;Initial Catalog=DROGUERIA;Integrated Security=True"; 
        public SqlConnection sconexion = new SqlConnection();

        //Constructor de la clase conexión
        public cls_Conexion()
        {
            sconexion.ConnectionString = conexion;

        }

        //Metodo para abrir la conexion a Sql Server
        public void abrir()
        {
            try
            {
                sconexion.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        //Metodo para cerrar la conexion a Sql Server
        public void cerrar()
        {
            try
            {
                sconexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cerrar");
            }
        }

        // Funcion para cargarDatos de cualquier tabla y asignarlos a un datagridview
        /// <param name="dgv"></Recibe el DataGridView en el cual queremos cargar los datos>
        /// <param name="NameTable"></Recibe la tablade Sql en la cual se buscaran los datos a cargar>

        public void cargarDatos(DataGridView dgv, string NameTable)
        {
            try
            {
                sconexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from " + NameTable, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                sconexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex.ToString());
            }
        }

        
        
        public void cargarDatos(DataGridView dgv)
        {
            try
            {
                sconexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT codigo_cliente, nombre_cliente, direccion_cliente, correo_cliente, telefono_cliente FROM Cliente WHERE Cliente.codigo_cliente", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                sconexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex.ToString());
            }
        }

    }
}



        



