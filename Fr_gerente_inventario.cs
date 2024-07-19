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
    public partial class Fr_gerente_inventario : Form
    {
        public Fr_gerente_inventario()
        {
            InitializeComponent();
        }

       
        public void cargartxtproveedor(string id)
        {
            txt_gr_provinv.Text = id;
        }
        public string ProveedorID
        {
            get { return txt_gr_provinv.Text; }
            set { txt_gr_provinv.Text = value; }
        }




        private void Fr_gerente_inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet18.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter2.Fill(this.dROGUERIADataSet18.Producto);
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter1.Fill(this.dROGUERIADataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet6.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dROGUERIADataSet6.Producto);
            //cls_Conexion BD = new cls_Conexion();
            //BD.abrir();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", BD.sconexion);


            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //BD.cerrar();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codinv_gr.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_gr_nominv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_gr_desinv.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_gr_catinv.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_gr_provinv.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_exisinv.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_precioPro_g.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_gr_agreinv_Click(object sender, EventArgs e)
        {
            try
             {
                if (txt_exisinv.Text == string.Empty || txt_gr_catinv.Text == string.Empty || txt_gr_desinv.Text == string.Empty ||txt_gr_nominv.Text == string.Empty || txt_gr_provinv.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand agregar = new SqlCommand("insert into Producto values (@nombre_producto, @descripcion_producto ,@categoria_producto, @proveedor_producto, " +
                        "@existencia_producto,@precio_producto)", BD.sconexion);
                    agregar.Parameters.AddWithValue("@nombre_producto", txt_gr_nominv.Text);
                    agregar.Parameters.AddWithValue("@descripcion_producto", txt_gr_desinv.Text);
                    agregar.Parameters.AddWithValue("@categoria_producto", txt_gr_catinv.Text);
                    agregar.Parameters.AddWithValue("@proveedor_producto", txt_gr_provinv.Text);
                    agregar.Parameters.AddWithValue("@existencia_producto", txt_exisinv.Text);
                    agregar.Parameters.AddWithValue("@precio_producto", txt_precioPro_g.Text);


                    agregar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_codinv_gr.Clear();
                    txt_exisinv.Clear();
                    txt_gr_catinv.Clear();
                    txt_gr_desinv.Clear();
                    txt_gr_nominv.Clear();
                    txt_gr_provinv.Clear();
                    txt_precioPro_g.Clear();

                    this.txt_gr_nominv.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dataGridView1, "Producto");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
           
            errorP_catpro_g.Clear();
            errorP_despro_g.Clear();
            errorP_existpro_g.Clear();
            errorP_nombpro_g.Clear();
            errorP_preciopro_ge.Clear();

        }

        private void btn_gr_elinv_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_exisinv.Text == string.Empty || txt_gr_catinv.Text == string.Empty || txt_gr_desinv.Text == string.Empty || txt_gr_nominv.Text == string.Empty || txt_gr_provinv.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede borrar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand eliminar = new SqlCommand("delete from Producto where codigo_producto=@codigo_producto", BD.sconexion);
                    eliminar.Parameters.AddWithValue("@codigo_producto", txt_codinv_gr.Text);
               

                    eliminar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_codinv_gr.Clear();
                    txt_exisinv.Clear();
                    txt_gr_catinv.Clear();
                    txt_gr_desinv.Clear();
                    txt_gr_nominv.Clear();
                    txt_gr_provinv.Clear();
                    txt_precioPro_g.Clear();

                    this.txt_gr_nominv.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dataGridView1, "Producto");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }


        }

        private void btn_gr_modinv_Click(object sender, EventArgs e)
        {
            try
              {
                if (txt_exisinv.Text == string.Empty || txt_gr_catinv.Text == string.Empty || txt_gr_desinv.Text == string.Empty || txt_gr_nominv.Text == string.Empty || txt_gr_provinv.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede modificar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand modificar = new SqlCommand("update Producto set nombre_producto=@nombre_producto, descripcion_producto=@descripcion_producto ,categoria_producto=@categoria_producto, proveedor_producto=@proveedor_producto, " +
                        "existencia_producto=@existencia_producto, precio_producto=@precio_producto where codigo_producto = @codigo_producto", BD.sconexion);
                    modificar.Parameters.AddWithValue("@codigo_producto", txt_codinv_gr.Text);
                    modificar.Parameters.AddWithValue("@nombre_producto", txt_gr_nominv.Text);
                    modificar.Parameters.AddWithValue("@descripcion_producto", txt_gr_desinv.Text);
                    modificar.Parameters.AddWithValue("@categoria_producto", txt_gr_catinv.Text);
                    modificar.Parameters.AddWithValue("@proveedor_producto", txt_gr_provinv.Text);
                    modificar.Parameters.AddWithValue("@existencia_producto", txt_exisinv.Text);
                    modificar.Parameters.AddWithValue("@precio_producto", txt_precioPro_g.Text);


                    modificar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_codinv_gr.Clear();
                    txt_exisinv.Clear();
                    txt_gr_catinv.Clear();
                    txt_gr_desinv.Clear();
                    txt_gr_nominv.Clear();
                    txt_gr_provinv.Clear();
                    txt_precioPro_g.Clear();

                    this.txt_gr_nominv.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dataGridView1, "Producto");
                }
             }
           catch
             {
               MessageBox.Show("Error...El codigo ya existe en la base de datos");
              }
            errorP_catpro_g.Clear();
            errorP_despro_g.Clear();
            errorP_existpro_g.Clear();
            errorP_nombpro_g.Clear();
            errorP_preciopro_ge.Clear();
        }

        private void btn_grinv_regresar_Click(object sender, EventArgs e)
        {
           
            this.Close();
            fr_menu_gerente fr_Menu_Gerente = new fr_menu_gerente();
            fr_Menu_Gerente.Show();
        }

        private void txt_codinv_gr_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            buscarproveedor buscarprov = new buscarproveedor();
            buscarprov.Owner = this; // Establece el formulario actual como el propietario
            buscarprov.ShowDialog();
        }


        Class1 validaciones = new Class1();

        private void txt_gr_nominv_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetras(txt_gr_nominv.Text, "El nombre no permite caracteres especiales"))
            {
                errorP_nombpro_g.SetError(txt_gr_nominv, "El nombre no permite caracteres especiales");
                txt_gr_nominv.Text = "";

            }
        }

        private void txt_gr_catinv_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarcatgopro(txt_gr_catinv.Text, "La categoría solo permite números del 1-5"))
            {
                errorP_nombpro_g.SetError(txt_gr_catinv, "La categoria solo permite numeros del 1-5");
                txt_gr_catinv.Text = "";

            }

        }

        private void txt_exisinv_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarNumeros(txt_exisinv.Text, "La existencia solo debe contener números"))
            {
                errorP_existpro_g.SetError(txt_exisinv, "La existencia solo debe contener numeros");
                txt_exisinv.Text = "";
                
            }
        }

        private void txt_gr_desinv_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetras(txt_gr_desinv.Text, "La descripcion no permite caracteres especiales ni números"))
            {
                errorP_despro_g.SetError(txt_gr_desinv, "La descripcion no permite caracteres especiales ni números");
                txt_gr_desinv.Text = "";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_precioPro_g_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarprecio(txt_precioPro_g.Text, "El precio no permite caracteres especiales ni letras"))
            {
                errorP_preciopro_ge.SetError(txt_precioPro_g, "El precio no permite caracteres especiales ni letras");
                txt_precioPro_g.Text = "";
            }
        }
    }
}
