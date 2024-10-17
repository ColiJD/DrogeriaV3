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
using System.Text.RegularExpressions;

namespace Drogueria_proyecto
{
    public partial class Fr_gerente_proveedores : Form
    {
        public Fr_gerente_proveedores()
        {
            InitializeComponent();
            errorP_correoprov_g = new ErrorProvider();
        }

        private void btn_gr_agreprov_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay campos vacíos
                if (string.IsNullOrWhiteSpace(txt_gr_corprov.Text) ||
                    string.IsNullOrWhiteSpace(txt_gr_desprov.Text) ||
                    string.IsNullOrWhiteSpace(txt_gr_nomprov.Text) ||
                    string.IsNullOrWhiteSpace(txt_gr_telprov.Text))
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();

                    // Comprobar si ya existe el nombre o correo del proveedor en la base de datos
                    SqlCommand verificar = new SqlCommand("SELECT COUNT(*) FROM Proveedor WHERE nombre_proveedor = @nombre_proveedor OR correo_proveedor = @correo_proveedor", BD.sconexion);
                    verificar.Parameters.AddWithValue("@nombre_proveedor", txt_gr_nomprov.Text);
                    verificar.Parameters.AddWithValue("@correo_proveedor", txt_gr_corprov.Text);

                    int count = (int)verificar.ExecuteScalar();

                    if (count > 0)
                    {
                        // Si el nombre o el correo ya existen, mostramos un mensaje de error
                        MessageBox.Show("Error... El proveedor ya existe en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_gr_telprov.Text.Length < 8)
                    {
                        // Validar que el teléfono tenga al menos 8 caracteres
                        MessageBox.Show("Error... El teléfono debe tener al menos 8 dígitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (errorP_correoprov_g.GetError(txt_gr_corprov) != string.Empty)
                    {
                        // Validar que no haya errores en el correo
                        MessageBox.Show("Error... El correo electrónico tiene un formato inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Si no existen, procedemos con la inserción
                        SqlCommand agregar = new SqlCommand("INSERT INTO Proveedor (nombre_proveedor, direccion_proveedor, correo_proveedor, telefono_proveedor) VALUES (@nombre_proveedor, @direccion_proveedor, @correo_proveedor, @telefono_proveedor)", BD.sconexion);
                        agregar.Parameters.AddWithValue("@nombre_proveedor", txt_gr_nomprov.Text);
                        agregar.Parameters.AddWithValue("@direccion_proveedor", txt_gr_desprov.Text);
                        agregar.Parameters.AddWithValue("@correo_proveedor", txt_gr_corprov.Text);
                        agregar.Parameters.AddWithValue("@telefono_proveedor", txt_gr_telprov.Text);

                        agregar.ExecuteNonQuery();

                        // Limpiar los campos y mostrar mensaje de éxito
                        txt_codprov_gr.Clear();
                        txt_gr_corprov.Clear();
                        txt_gr_desprov.Clear();
                        txt_gr_nomprov.Clear();
                        txt_gr_telprov.Clear();

                        MessageBox.Show("Datos Agregados Correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar datos en la tabla
                        cls_Conexion clsConexion1 = new cls_Conexion();
                        clsConexion1.cargarDatos(dataGridView1, "Proveedor");
                    }

                    BD.cerrar();
                    this.txt_codprov_gr.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpiar los errores de validación en los campos
                errorP_direcprov_g.Clear();
                errorP_nombprov_g.Clear();
                errorP_telprov_g.Clear();
            }



        }

        private void ce(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codprov_gr.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_gr_nomprov.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_gr_desprov.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_gr_corprov.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_gr_telprov.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Fr_gerente_proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet7.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dROGUERIADataSet7.Proveedor);

            //cls_Conexion BD = new cls_Conexion();
            //BD.abrir();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Proveedor", BD.sconexion);


            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //BD.cerrar();
        }

        private void btn_gr_eliprov_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_gr_corprov.Text == string.Empty || txt_gr_desprov.Text == string.Empty || txt_gr_telprov.Text == string.Empty || txt_gr_nomprov.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede eliminar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand agregar = new SqlCommand("delete from Proveedor where codigo_proveedor=@codigo_proveedor", BD.sconexion);
                    agregar.Parameters.AddWithValue("@codigo_proveedor", Convert.ToInt32(txt_codprov_gr.Text));
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Datos eliminados Correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BD.cerrar();
                    txt_codprov_gr.Clear();
                    txt_gr_corprov.Clear();
                    txt_gr_desprov.Clear();
                    txt_gr_nomprov.Clear();
                    txt_gr_telprov.Clear();
                    this.txt_codprov_gr.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dataGridView1, "Proveedor");


                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void btn_gr_modprov_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay campos vacíos
                if (string.IsNullOrWhiteSpace(txt_gr_corprov.Text) ||
                    string.IsNullOrWhiteSpace(txt_gr_desprov.Text) ||
                    string.IsNullOrWhiteSpace(txt_gr_nomprov.Text) ||
                    string.IsNullOrWhiteSpace(txt_gr_telprov.Text))
                {
                    MessageBox.Show("Error... No puede modificar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_gr_telprov.Text.Length < 8)
                {
                    // Validar que el teléfono tenga al menos 8 caracteres
                    MessageBox.Show("Error... El teléfono debe tener al menos 8 dígitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorP_correoprov_g.GetError(txt_gr_corprov) != string.Empty)
                {
                    // Validar que no haya errores en el correo
                    MessageBox.Show("Error... El correo electrónico tiene un formato inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();

                    // Preparar el comando de actualización
                    SqlCommand modificar = new SqlCommand("UPDATE Proveedor SET nombre_proveedor = @nombre_proveedor, direccion_proveedor = @direccion_proveedor, correo_proveedor = @correo_proveedor, telefono_proveedor = @telefono_proveedor WHERE codigo_proveedor = @codigo_proveedor", BD.sconexion);

                    // Agregar parámetros
                    modificar.Parameters.AddWithValue("@codigo_proveedor", txt_codprov_gr.Text);
                    modificar.Parameters.AddWithValue("@nombre_proveedor", txt_gr_nomprov.Text);
                    modificar.Parameters.AddWithValue("@direccion_proveedor", txt_gr_desprov.Text);
                    modificar.Parameters.AddWithValue("@correo_proveedor", txt_gr_corprov.Text);
                    modificar.Parameters.AddWithValue("@telefono_proveedor", txt_gr_telprov.Text);

                    // Ejecutar la actualización
                    int rowsAffected = modificar.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Si se actualizó correctamente, limpiar los campos
                        txt_codprov_gr.Clear();
                        txt_gr_corprov.Clear();
                        txt_gr_desprov.Clear();
                        txt_gr_nomprov.Clear();
                        txt_gr_telprov.Clear();
                        MessageBox.Show("Datos Modificados Correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error... No se encontró el proveedor para modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    BD.cerrar();
                    this.txt_codprov_gr.Focus();

                    // Recargar datos en la tabla
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dataGridView1, "Proveedor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpiar los errores de validación en los campos
                errorP_direcprov_g.Clear();
                errorP_nombprov_g.Clear();
                errorP_telprov_g.Clear();
            }



        }

        private void btn_grprov_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            fr_menu_gerente fr_Menu_Gerente = new fr_menu_gerente();
            fr_Menu_Gerente.Show();
        }


        Class1 validaciones = new Class1();

        private void txt_gr_nomprov_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetras(txt_gr_nomprov.Text, "El nombre no permite caracteres especiales ni numeros"))
            {
                errorP_nombprov_g.SetError(txt_gr_nomprov, "El nombre no permite caracteres especiales ni numeros");
                
                txt_gr_nomprov.Text = "";
            }
        }

        private void txt_gr_desprov_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetrasyNumeros(txt_gr_desprov.Text, "La direccion solo debe contener letras y numeros"))
            {
                errorP_direcprov_g.SetError(txt_gr_desprov, "La direccion solo debe contener letras y numeros");
                txt_gr_desprov.Text = "";
            }
        }

        private void txt_gr_telprov_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_gr_corprov_TextChanged(object sender, EventArgs e)
        {
            // Expresión regular para validar el formato del correo electrónico
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txt_gr_corprov.Text, emailPattern))
            {
                // Mostrar un mensaje de error si el formato es incorrecto
                errorP_correoprov_g.SetError(txt_gr_corprov, "Formato de correo no válido.");
            }
            else
            {
                errorP_correoprov_g.Clear(); // Limpiar error si el formato es correcto
            }


        }

        private void txt_gr_telprov_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos (números) y evitar que se ingrese más de 8 caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No permite caracteres no numéricos
            }

            // Limitar a 8 dígitos
            if (txt_gr_telprov.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // No permite más de 8 dígitos
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

