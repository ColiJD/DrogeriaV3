using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Drogueria_proyecto
{
    public partial class fr_Productos_vendedor : Form
    {
        public fr_Productos_vendedor()
        {
            InitializeComponent();
        }

        private void fr_Productos_vendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet21.view_producto' Puede moverla o quitarla según sea necesario.
            this.view_productoTableAdapter1.Fill(this.dROGUERIADataSet21.view_producto);
            

            //cls_Conexion BD = new cls_Conexion();
            //BD.abrir();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", BD.sconexion);


            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dgv_producto_v.DataSource = dt;
            //BD.cerrar();
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            fr_Vendedor_menu fr_Vendedor_Menu = new fr_Vendedor_menu();
            fr_Vendedor_Menu.Show();
        }

        private void dgv_producto_v_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
