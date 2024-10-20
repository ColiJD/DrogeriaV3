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
    public partial class fr_Producto_Admin : Form
    {
        private string categoria = "";
        public fr_Producto_Admin()
        {
            InitializeComponent();
        }
        public void cargartxtproveedor(string id)
        {
            txt_provinv_ad.Text = id;
        }
        public string ProveedorID
        {
            get { return txt_provinv_ad.Text; }
            set { txt_provinv_ad.Text = value; }
        }

        private void fr_Producto_Admin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet20.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter1.Fill(this.dROGUERIADataSet20.Producto);
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet4.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dROGUERIADataSet4.Producto);
            //cls_Conexion BD = new cls_Conexion();
            //BD.abrir();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", BD.sconexion);


            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dgv_prod_ad.DataSource = dt;
            //BD.cerrar();
            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = DROGUERIA; Integrated Security = True");
            SqlCommand cmdProduct = new SqlCommand("Select codigo_categoria, descripcion_categoria from Categoria", conn);
            SqlDataAdapter product = new SqlDataAdapter(cmdProduct);
            DataTable table3 = new DataTable();
            product.Fill(table3);
            DataRow emptyProduct = table3.NewRow();
            table3.Rows.InsertAt(emptyProduct, 0);
            cbcategoria.DataSource = table3;
            cbcategoria.DisplayMember = "descripcion_categoria";
            cbcategoria.ValueMember = "codigo_categoria";
            conn.Close();
        }

        private void dvg_administrador_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvg_administrador_producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codinv_ad.Text = dgv_prod_ad.CurrentRow.Cells[0].Value.ToString();
            txt_Nom_ad.Text = dgv_prod_ad.CurrentRow.Cells[1].Value.ToString();
            txt_desinv_ad.Text = dgv_prod_ad.CurrentRow.Cells[2].Value.ToString();
            categoria = dgv_prod_ad.CurrentRow.Cells[3].Value.ToString();

            // Establece el valor del ComboBox a la categoría correspondiente
            cbcategoria.SelectedValue = categoria;
            txt_provinv_ad.Text = dgv_prod_ad.CurrentRow.Cells[4].Value.ToString();
            txt_exisinv_ad.Text = dgv_prod_ad.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dgv_prod_ad.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_exisinv_ad.Text) ||
                    string.IsNullOrWhiteSpace(cbcategoria.Text) ||
                    string.IsNullOrWhiteSpace(txt_desinv_ad.Text) ||
                    string.IsNullOrWhiteSpace(txt_Nom_ad.Text) ||
                    string.IsNullOrWhiteSpace(txt_provinv_ad.Text))
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();

                    // Verificar si el nombre del producto ya existe en la base de datos
                    SqlCommand verificar = new SqlCommand("SELECT COUNT(*) FROM Producto WHERE nombre_producto = @nombre_producto", BD.sconexion);
                    verificar.Parameters.AddWithValue("@nombre_producto", txt_Nom_ad.Text);

                    int count = (int)verificar.ExecuteScalar();

                    if (count > 0)
                    {
                        // Si el nombre ya existe, mostramos un mensaje de error
                        MessageBox.Show("Error... El nombre del producto ya existe en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Si no existe, se procede a insertar el producto
                        SqlCommand agregar = new SqlCommand("INSERT INTO Producto (nombre_producto, descripcion_producto, categoria_producto, proveedor_producto, existencia_producto, precio_producto) " +
                                                            "VALUES (@nombre_producto, @descripcion_producto, @categoria_producto, @proveedor_producto, @existencia_producto, @precio_producto)", BD.sconexion);
                        agregar.Parameters.AddWithValue("@nombre_producto", txt_Nom_ad.Text);
                        agregar.Parameters.AddWithValue("@descripcion_producto", txt_desinv_ad.Text);
                        agregar.Parameters.AddWithValue("@categoria_producto", categoria);
                        agregar.Parameters.AddWithValue("@proveedor_producto", txt_provinv_ad.Text);
                        agregar.Parameters.AddWithValue("@existencia_producto", txt_exisinv_ad.Text); // Asegúrate de que esto coincida con el nombre en la base de datos
                        agregar.Parameters.AddWithValue("@precio_producto", textBox8.Text);

                        agregar.ExecuteNonQuery();
                        MessageBox.Show("Aviso ... Los Datos se agregaron exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos después de la inserción
                        txt_codinv_ad.Clear();
                        txt_exisinv_ad.Clear();
                        cbcategoria.ResetText();
                        txt_desinv_ad.Clear();
                        txt_Nom_ad.Clear();
                        txt_provinv_ad.Clear();
                        textBox8.Clear();

                        this.txt_Nom_ad.Focus();

                        // Actualizar la tabla de productos
                        cls_Conexion clsConexion1 = new cls_Conexion();
                        clsConexion1.cargarDatos(dgv_prod_ad, "Producto");
                    }

                    BD.cerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                errorP_catpro_ad.Clear();
                errorP_despro_ad.Clear();
                errorP_existpro_ad.Clear();
                errorP_nombpro_ad.Clear();
            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_exisinv_ad.Text == string.Empty || cbcategoria.Text == string.Empty || txt_desinv_ad.Text == string.Empty || txt_Nom_ad.Text == string.Empty || txt_provinv_ad.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede modificar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();

                    // Verificar si el nombre del producto ya existe para otro registro
                    SqlCommand verificar = new SqlCommand("SELECT COUNT(*) FROM Producto WHERE nombre_producto = @nombre_producto AND codigo_producto != @codigo_producto", BD.sconexion);
                    verificar.Parameters.AddWithValue("@nombre_producto", txt_Nom_ad.Text);
                    verificar.Parameters.AddWithValue("@codigo_producto", txt_codinv_ad.Text);

                    int count = (int)verificar.ExecuteScalar();

                    if (count > 0)
                    {
                        // Si el nombre ya está en uso por otro producto, mostramos un mensaje de error
                        MessageBox.Show("Error... El nombre del producto ya existe en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Si no hay duplicados, procedemos con la modificación
                        SqlCommand modificar = new SqlCommand("UPDATE Producto SET nombre_producto=@nombre_producto, descripcion_producto=@descripcion_producto, categoria_producto=@categoria_producto, " +
                            "proveedor_producto=@proveedor_producto, existencia_producto=@existencia, precio_producto=@precio_producto WHERE codigo_producto=@codigo_producto", BD.sconexion);
                        modificar.Parameters.AddWithValue("@codigo_producto", txt_codinv_ad.Text);
                        modificar.Parameters.AddWithValue("@nombre_producto", txt_Nom_ad.Text);
                        modificar.Parameters.AddWithValue("@descripcion_producto", txt_desinv_ad.Text);
                        modificar.Parameters.AddWithValue("@categoria_producto", categoria);
                        modificar.Parameters.AddWithValue("@proveedor_producto", txt_provinv_ad.Text);
                        modificar.Parameters.AddWithValue("@existencia", txt_exisinv_ad.Text);
                        modificar.Parameters.AddWithValue("@precio_producto", textBox8.Text);

                        modificar.ExecuteNonQuery();
                        MessageBox.Show("Aviso ... Los Datos se modificaron exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos después de la modificación
                        txt_codinv_ad.Clear();
                        txt_exisinv_ad.Clear();
                        cbcategoria.ResetText();
                        txt_desinv_ad.Clear();
                        txt_Nom_ad.Clear();
                        txt_provinv_ad.Clear();
                        textBox8.Clear();

                        this.txt_Nom_ad.Focus();

                        // Actualizar la tabla de productos
                        cls_Conexion clsConexion1 = new cls_Conexion();
                        clsConexion1.cargarDatos(dgv_prod_ad, "Producto");
                    }

                    BD.cerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                errorP_catpro_ad.Clear();
                errorP_despro_ad.Clear();
                errorP_existpro_ad.Clear();
                errorP_nombpro_ad.Clear();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txt_exisinv_ad.Text == string.Empty || cbcategoria.Text == string.Empty || txt_desinv_ad.Text == string.Empty || txt_Nom_ad.Text == string.Empty || txt_provinv_ad.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede eliminar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand eliminar = new SqlCommand("delete from Producto where codigo_producto=@codigo_producto", BD.sconexion);
                    eliminar.Parameters.AddWithValue("@codigo_producto", txt_codinv_ad.Text);


                    eliminar.ExecuteNonQuery();
                    MessageBox.Show("Aviso ... Los Datos se eliminaron exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BD.cerrar();
                    txt_codinv_ad.Clear();
                    txt_exisinv_ad.Clear();
                    cbcategoria.ResetText();
                    txt_desinv_ad.Clear();
                    txt_Nom_ad.Clear();
                    txt_provinv_ad.Clear();

                    this.txt_Nom_ad.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dgv_prod_ad, "Producto");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void btnBuscarad_Click(object sender, EventArgs e)
        {
            buscarproveedorad buscarprov = new buscarproveedorad();
            buscarprov.Owner = this; // Establece el formulario actual como el propietario
            buscarprov.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Fr_Administrador fr_Administrador = new Fr_Administrador();
            fr_Administrador.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        Class1 validaciones = new Class1();

        private void txt_Nom_ad_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetras(txt_Nom_ad.Text, "El nombre no permite caracteres especiales"))
            {
                errorP_nombpro_ad.SetError(txt_Nom_ad, "El nombre no permite caracteres especiales");
                txt_Nom_ad.Text = "";

            }
        }

        private void txt_catinv_ad_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void txt_exisinv_ad_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarNumeros(txt_exisinv_ad.Text, "La existencia solo debe contener números"))
            {
                errorP_existpro_ad.SetError(txt_exisinv_ad, " La existencia solo debe contener numeros");
                txt_exisinv_ad.Text = "";

            }
        }

        private void txt_desinv_ad_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetras(txt_desinv_ad.Text, "La descripcion no permite caracteres especiales ni números"))
            {
                errorP_despro_ad.SetError(txt_desinv_ad, "La descripcion no permite caracteres especiales ni números");
                txt_desinv_ad.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarprecio(textBox8.Text, "El precio no permite caracteres especiales ni letras"))
            {
                errorP_despro_ad.SetError(textBox8, "El precio no permite caracteres especiales ni letras");
                textBox8.Text = "";
            }

        }

        private void txt_codinv_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_prod_ad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_catinv_ad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_catinv_ad_TextChanged_1(object sender, EventArgs e)
        {
            
        }

       

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtBuscar.Text.Trim();

            cls_Conexion BD = new cls_Conexion();
            BD.abrir();

            SqlCommand buscar;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // Si el campo está vacío, selecciona todos los clientes
                buscar = new SqlCommand("SELECT * FROM Producto", BD.sconexion);
            }
            else
            {
                // Si hay texto en el campo, filtra por el nombre del cliente
                buscar = new SqlCommand("SELECT * FROM Producto WHERE nombre_producto LIKE @nombre_producto", BD.sconexion);
                buscar.Parameters.AddWithValue("@nombre_producto", "%" + searchTerm + "%");
            }

            SqlDataAdapter adapter = new SqlDataAdapter(buscar);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Asignar los resultados al DataGridView
            dgv_prod_ad.DataSource = dt;

            BD.cerrar();
        }

        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si hay un elemento seleccionado
            if (cbcategoria.SelectedValue != null)
            {
                // Guarda el codigo_empleado en una variable
                categoria = cbcategoria.SelectedValue.ToString();

                // Puedes usar la variable codigoEmpleado como desees
                Console.WriteLine("Código del empleado seleccionado: " + categoria);
            }
        }
    }
}

