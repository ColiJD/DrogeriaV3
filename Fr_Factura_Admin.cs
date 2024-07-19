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
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Windows.Markup;
using System.Data.SqlClient;

namespace Drogueria_proyecto
{
    public partial class Fr_Factura_Admin : Form
    {
        SqlConnection datagrid = new SqlConnection(@"Data Source = localhost; Initial Catalog = DROGUERIA; Integrated Security = True;");
        SqlCommand datagridcmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public Fr_Factura_Admin()
        {
            InitializeComponent();
            showdata();
        }
        private void Fr_Factura_Admin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = DROGUERIA; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Select codigo_empleado, nombre_empleado from Empleado", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);


            cboxEmp.DataSource = table1;
            cboxEmp.DisplayMember = "nombre_empleado";
            cboxEmp.ValueMember = "codigo_empleado";
            //////////////////////
            SqlCommand cmds = new SqlCommand("Select codigo_cliente, nombre_cliente from Cliente", conn);
            SqlDataAdapter das = new SqlDataAdapter();
            das.SelectCommand = cmds;
            DataTable table2 = new DataTable();
            das.Fill(table2);


            cboxCliente.DataSource = table2;
            cboxCliente.DisplayMember = "nombre_cliente";
            cboxCliente.ValueMember = "codigo_cliente";


            conn.Close();

           
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Fr_Administrador fr_Administrador = new Fr_Administrador();
            fr_Administrador.Show();
        }








        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        

        }
        private void cboxProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            //SqlConnection testp = new SqlConnection("Data Source = localhost; Initial Catalog = DROGUERIA; Integrated Security = True");
            //  testp.Open();

            //  SqlCommand testpp = new SqlCommand("Select precio_producto from Producto where nombre_producto = @nombre_producto", testp);
            //  testpp.Parameters.AddWithValue("@nombre_producto", cboxProducto);
            //  SqlDataReader testppp = testpp.ExecuteReader();
            //  while (testppp.Read())
            //  {
            //      txtPrecio.Text = testppp.GetValue(0).ToString();
            //  }

        }

        private void cboxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIDP_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conexionp = new SqlConnection("Data Source = localhost; Initial Catalog = DROGUERIA; Integrated Security = True");
            conexionp.Open();
            if (txtIDP.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select nombre_producto, precio_producto from Producto where codigo_producto = @codigo_producto", conexionp);
                cmd.Parameters.AddWithValue("@codigo_producto", int.Parse(txtIDP.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtProducto.Text = da.GetValue(0).ToString();
                    txtPrecio.Text = da.GetValue(1).ToString();
                }
                conexionp.Close();

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                decimal cantidad, subtotal, precio = 1;
                cantidad = Decimal.Parse(txtCantidad.Text);
                precio = Decimal.Parse(txtPrecio.Text);
                subtotal = cantidad * precio;
                txtSubtotal.Text = Convert.ToString(subtotal = cantidad * precio);
                decimal total =0, impuesto = 0.15m;
                total = subtotal+(subtotal * impuesto);
                txtTotal.Text = Convert.ToString(total);
                txtImp.Text = Convert.ToString(subtotal * impuesto);
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDP.Text == string.Empty || txtPrecio.Text == string.Empty || txtSubtotal.Text == string.Empty || txtImp.Text == string.Empty || txtTotal.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand agregar = new SqlCommand("insert into Facturass values (@empleado_factura, @cliente_factura ,@Id_producto, @nombre_producto, " +
                        "@precio, @cantidad, @subtotal, @impuesto, @total)", BD.sconexion);
                    agregar.Parameters.AddWithValue("@empleado_factura", cboxEmp.Text);
                    agregar.Parameters.AddWithValue("@cliente_factura", cboxCliente.Text);
                    agregar.Parameters.AddWithValue("@Id_producto", txtIDP.Text);
                    agregar.Parameters.AddWithValue("@nombre_producto", txtProducto.Text);
                    agregar.Parameters.AddWithValue("@precio", txtPrecio.Text);
                    agregar.Parameters.AddWithValue("@cantidad", txtCantidad.Text);
                    agregar.Parameters.AddWithValue("@subtotal", txtSubtotal.Text);
                    agregar.Parameters.AddWithValue("@impuesto", txtImp.Text);
                    agregar.Parameters.AddWithValue("@total", txtTotal.Text);

                    agregar.ExecuteNonQuery();
                    BD.cerrar();
                    showdata();
                    txtIDP.Clear();
                    txtProducto.Clear();
                    txtPrecio.Clear();
                    txtCantidad.Clear();
                    txtImp.Clear();
                    txtTotal.Clear();

                    this.txtProducto.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }

            //errorP_catpro_ad.Clear();
            //errorP_despro_ad.Clear();
            //errorP_existpro_ad.Clear();
            //errorP_nombpro_ad.Clear();
        }


        public void showdata()
        {
            adpt = new SqlDataAdapter("select * from Facturass", datagrid);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvFactura.DataSource = dt;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDP.Text == string.Empty || txtPrecio.Text == string.Empty || txtSubtotal.Text == string.Empty || txtImp.Text == string.Empty || txtTotal.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede modificar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand modificar = new SqlCommand("update Facturass set empleado_factura=@empleado_factura,cliente_factura=@cliente_factura,Id_producto=@Id_producto," +
                        "nombre_producto=@nombre_producto, precio=@precio , cantidad=@cantidad, subtotal=@subtotal, total=@total, " +
                        "impuesto=@impuesto where Id_factura=@Id_factura", BD.sconexion);

                    modificar.Parameters.AddWithValue("@Id_factura", txtFactura.Text);
                    modificar.Parameters.AddWithValue("@empleado_factura", cboxEmp.Text);
                    modificar.Parameters.AddWithValue("@cliente_factura", cboxCliente.Text);
                    modificar.Parameters.AddWithValue("@Id_producto", txtIDP.Text);
                    modificar.Parameters.AddWithValue("@nombre_producto", txtProducto.Text);
                    modificar.Parameters.AddWithValue("@precio", txtPrecio.Text);
                    modificar.Parameters.AddWithValue("@cantidad", txtCantidad.Text);
                    modificar.Parameters.AddWithValue("@subtotal", txtSubtotal.Text);
                    modificar.Parameters.AddWithValue("@impuesto", txtImp.Text);
                    modificar.Parameters.AddWithValue("@total", txtTotal.Text);


                    modificar.ExecuteNonQuery();
                    BD.cerrar();
                    showdata();
                    txtIDP.Clear();
                    txtProducto.Clear();
                    txtPrecio.Clear();
                    txtCantidad.Clear();
                    txtImp.Clear();
                    txtTotal.Clear();

                    this.txtProducto.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void dgvFactura_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtIDP.Text = dgvFactura.CurrentRow.Cells[4].Value.ToString();
            //txtProducto.Text = dgvFactura.CurrentRow.Cells[5].Value.ToString();
            //txtPrecio.Text = dgvFactura.CurrentRow.Cells[6].Value.ToString();
            //txtCantidad.Text = dgvFactura.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {


                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand eliminar = new SqlCommand("delete from Facturass where Id_factura=@Id_factura", BD.sconexion);
                    eliminar.Parameters.AddWithValue("@Id_factura", Convert.ToInt32(txtFactura.Text));



                    eliminar.ExecuteNonQuery();
                    BD.cerrar();
                    showdata();
                    txtIDP.Clear();
                    txtProducto.Clear();
                    txtPrecio.Clear();
                    txtCantidad.Clear();
                    txtImp.Clear();
                    txtTotal.Clear();

                    this.txtProducto.Focus();
                }
            
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgvFactura.Width, dgvFactura.Height);
            dgvFactura.DrawToBitmap(imagebmp, new Rectangle(0, 0, dgvFactura.Width, dgvFactura.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
