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
            txtFactura.Enabled = false;
            txtProducto.Enabled = false;
            txtImp.Enabled = false;
            txtSubtotal.Enabled = false;
            txtTotal.Enabled = false;
            txtPrecio.Enabled = false;
            cboxEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCliente.DropDownStyle = ComboBoxStyle.DropDownList;


            DataRow emptyRo = table1.NewRow();
            table1.Rows.InsertAt(emptyRo, 0);
            cboxEmp.DataSource = table1;
            cboxEmp.DisplayMember = "nombre_empleado";
            cboxEmp.ValueMember = "codigo_empleado";

            //////////////////////
            SqlCommand cmds = new SqlCommand("Select codigo_cliente, nombre_cliente from Cliente", conn);
            SqlDataAdapter das = new SqlDataAdapter();
            das.SelectCommand = cmds;
            DataTable table2 = new DataTable();
            das.Fill(table2);

            // Agregar un elemento vacío al DataTable para el ComboBox cboxCliente
            DataRow emptyRow = table2.NewRow();
            table2.Rows.InsertAt(emptyRow, 0); // Insertar en la primera posición

            cboxCliente.DataSource = table2;
            cboxCliente.DisplayMember = "nombre_cliente";
            cboxCliente.ValueMember = "codigo_cliente";

            txtIDP.Clear();
            txtCantidad.Clear();
            txtFactura.Clear();
            txtImp.Clear();
            txtPrecio.Clear();
            txtProducto.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            cboxCliente.ResetText();
            cboxEmp.ResetText();

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

                // Verifica si hay filas devueltas
                if (da.HasRows)
                {
                    while (da.Read())
                    {
                        txtProducto.Text = da.GetValue(0).ToString();
                        txtPrecio.Text = da.GetValue(1).ToString();
                    }
                }
                else
                {
                    // Si no hay resultados, limpiar los TextBox
                    txtProducto.Text = "";
                    txtPrecio.Text = "";
                }

                da.Close(); // Cierra el DataReader
                conexionp.Close();
            }
            else
            {
                // Si el txtIDP está vacío, también limpiar los TextBox
                txtProducto.Text = "";
                txtPrecio.Text = "";
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
            decimal cantidad, subtotal, precio;

            // Validar que la cantidad y el precio sean numéricos
            if (Decimal.TryParse(txtCantidad.Text, out cantidad) && Decimal.TryParse(txtPrecio.Text, out precio))
            {
                // Realizar los cálculos solo si la validación es exitosa
                subtotal = cantidad * precio;
                txtSubtotal.Text = subtotal.ToString();

                decimal impuesto = 0.15m;
                decimal total = subtotal + (subtotal * impuesto);

                txtTotal.Text = total.ToString();
                txtImp.Text = (subtotal * impuesto).ToString();
            }
            else
            {
                // Limpiar los campos si la validación no es exitosa
                txtSubtotal.Text = "0";
                txtTotal.Text = "0";
                txtImp.Text = "0";
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
                if (txtIDP.Text == string.Empty || txtCantidad.Text == string.Empty || cboxCliente.Text == string.Empty || cboxEmp.Text == string.Empty || txtTotal.Text == string.Empty)
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
                    MessageBox.Show("Aviso ... Los Datos se agregaron exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BD.cerrar();
                    showdata();
                    txtIDP.Clear();
                    txtCantidad.Clear();
                    txtFactura.Clear();
                    txtImp.Clear();
                    txtPrecio.Clear();
                    txtProducto.Clear();
                    txtSubtotal.Clear();
                    txtTotal.Clear();
                    cboxCliente.ResetText();
                    cboxEmp.ResetText();
                    


                    this.txtProducto.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error...El formato del ID de factura no es válido.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
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
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand modificar = new SqlCommand(
     "UPDATE Facturass SET empleado_factura = @empleado_factura, cliente_factura = @cliente_factura, " +
     "Id_producto = @Id_producto, nombre_producto = @nombre_producto, precio = @precio, cantidad = @cantidad, " +
     "subtotal = @subtotal, impuesto = @impuesto, total = @total WHERE Id_factura = @Id_factura",
     BD.sconexion
 );
                    modificar.Parameters.AddWithValue("@Id_factura", txtFactura.Text);
                    modificar.Parameters.AddWithValue("@empleado_factura", cboxEmp.Text);
                    modificar.Parameters.AddWithValue("@cliente_factura", cboxCliente.Text);
                    modificar.Parameters.AddWithValue("@Id_producto", txtIDP.Text);
                    modificar.Parameters.AddWithValue("@nombre_producto", txtProducto.Text);

                    // Convertir los campos que deberían ser numéricos
                    modificar.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                    modificar.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));
                    modificar.Parameters.AddWithValue("@subtotal", Convert.ToDecimal(txtSubtotal.Text));
                    modificar.Parameters.AddWithValue("@impuesto", Convert.ToDecimal(txtImp.Text));
                    modificar.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.Text));


                    modificar.ExecuteNonQuery();
                    MessageBox.Show("Aviso ... Los Datos se modificaron exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BD.cerrar();
                    showdata();
                    txtIDP.Clear();
                    txtCantidad.Clear();
                    txtFactura.Clear();
                    txtImp.Clear();
                    txtPrecio.Clear();
                    txtProducto.Clear();
                    txtSubtotal.Clear();
                    txtTotal.Clear();
                    cboxCliente.ResetText();
                    cboxEmp.ResetText();



                    this.txtIDP.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error...El formato del ID de factura no es válido.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        private void dgvFactura_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string testt = dgvFactura.CurrentRow.Cells[4].Value.ToString();
            //int testtt = Int32.Parse(testt);
            //txtIDP.Text = testtt;
            //txtProducto.Text = dgvFactura.CurrentRow.Cells[5].Value.ToString();
            //txtPrecio.Text = dgvFactura.CurrentRow.Cells[6].Value.ToString();
            //txtCantidad.Text = dgvFactura.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
                    SqlCommand eliminar = new SqlCommand("delete from Facturass where Id_factura = @Id_factura", BD.sconexion);
                    eliminar.Parameters.AddWithValue("@Id_Factura", Convert.ToInt32(txtFactura.Text));



                    eliminar.ExecuteNonQuery();
                    MessageBox.Show("Aviso ... Los Datos se eliminaron exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BD.cerrar();
                    showdata();
                    txtIDP.Clear();
                    txtCantidad.Clear();
                    txtFactura.Clear();
                    txtImp.Clear();
                    txtPrecio.Clear();
                    txtProducto.Clear();
                    txtSubtotal.Clear();
                    txtTotal.Clear();
                    cboxCliente.ResetText();
                    cboxEmp.ResetText();



                    this.txtProducto.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error...El formato del ID de factura no es válido.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
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

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFactura.Text = dgvFactura.CurrentRow.Cells[0].Value.ToString();
            cboxEmp.Text = dgvFactura.CurrentRow.Cells[1].Value.ToString();
            cboxCliente.Text = dgvFactura.CurrentRow.Cells[2].Value.ToString();
            txtIDP.Text = dgvFactura.CurrentRow.Cells[3].Value.ToString();    
            txtProducto.Text = dgvFactura.CurrentRow.Cells[4].Value.ToString();
            txtPrecio.Text = dgvFactura.CurrentRow.Cells[5].Value.ToString();
            txtCantidad.Text = dgvFactura.CurrentRow.Cells[6].Value.ToString();
            txtSubtotal.Text = dgvFactura.CurrentRow.Cells[7].Value.ToString();
            txtImp.Text = dgvFactura.CurrentRow.Cells[8].Value.ToString();
            txtTotal.Text = dgvFactura.CurrentRow.Cells[9].Value.ToString();
            
            
           
           
           
           
            

            
        }
        
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
           
        }
        Class1 validaciones = new Class1();

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un dígito o un punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // No permitir la entrada
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // No permitir más de un punto decimal
            }
        }

        private void txtIDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // No permitir la entrada
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // No permitir más de un punto decimal
            }
        }

        private void cboxEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra o un carácter de control (Backspace, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // No permitir la entrada
            }
        }

        private void cboxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra o un carácter de control (Backspace, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // No permitir la entrada
            }
        }

        private void cboxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
