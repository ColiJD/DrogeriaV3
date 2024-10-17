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
    public partial class Fr_Empleado_Admin : Form
    {
        public Fr_Empleado_Admin()
        {
            InitializeComponent();
        }

        private void Fr_Empleado_Admin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet2.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.dROGUERIADataSet2.Empleado);
            //cls_Conexion BD = new cls_Conexion();
            //BD.abrir();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Empleado", BD.sconexion);


            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dtg_administrador_empleado.DataSource = dt;
            //BD.cerrar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Fr_Administrador fr_Administrador = new Fr_Administrador();
            fr_Administrador.Show();
        }

        private void FrmLector_Load(object sender, EventArgs e)
        {
            cls_Conexion clsConexion1 = new cls_Conexion();
            clsConexion1.cargarDatos(dtg_administrador_empleado);
        }
        int i;


        private void dgv_gerente_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txt_idEmpleado_gr.Text = dtg_administrador_empleado.CurrentRow.Cells[0].Value.ToString();
            txt_nomempl_gr.Text = dtg_administrador_empleado.CurrentRow.Cells[1].Value.ToString();
            txt_usuaempl_gr.Text = dtg_administrador_empleado.CurrentRow.Cells[2].Value.ToString();
            txt_pas_ad.Text = dtg_administrador_empleado.CurrentRow.Cells[3].Value.ToString();
            txt_tipoempl_gr.Text = dtg_administrador_empleado.CurrentRow.Cells[4].Value.ToString();
            txt_correoempl_gr.Text = dtg_administrador_empleado.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay campos vacíos
                if (string.IsNullOrWhiteSpace(txt_tipoempl_gr.Text) ||
                    string.IsNullOrWhiteSpace(txt_usuaempl_gr.Text) ||
                    string.IsNullOrWhiteSpace(txt_nomempl_gr.Text) ||
                    string.IsNullOrWhiteSpace(txt_pas_ad.Text) ||
                    string.IsNullOrWhiteSpace(txt_correoempl_gr.Text))
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();

                    // Verificar si el username o el correo ya existen en la base de datos
                    SqlCommand verificar = new SqlCommand("SELECT COUNT(*) FROM Empleado WHERE username = @username OR correo = @correo", BD.sconexion);
                    verificar.Parameters.AddWithValue("@username", txt_usuaempl_gr.Text);
                    verificar.Parameters.AddWithValue("@correo", txt_correoempl_gr.Text);

                    int count = (int)verificar.ExecuteScalar();

                    if (count > 0)
                    {
                        // Si el username o el correo ya existen, mostramos un mensaje de error
                        MessageBox.Show("Error... El usuario o el correo ya existen en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Si no existen duplicados, procedemos con la inserción
                        SqlCommand agregar = new SqlCommand("INSERT INTO Empleado (nombre_empleado, username, password, codigo_tipo, correo) VALUES (@nombre_empleado, @username, @password, @codigo_tipo, @correo)", BD.sconexion);
                        agregar.Parameters.AddWithValue("@nombre_empleado", txt_nomempl_gr.Text);
                        agregar.Parameters.AddWithValue("@username", txt_usuaempl_gr.Text);
                        agregar.Parameters.AddWithValue("@password", txt_pas_ad.Text);
                        agregar.Parameters.AddWithValue("@codigo_tipo", txt_tipoempl_gr.Text);
                        agregar.Parameters.AddWithValue("@correo", txt_correoempl_gr.Text);

                        agregar.ExecuteNonQuery();

                        // Limpiamos los campos y mostramos un mensaje de éxito
                        txt_tipoempl_gr.Clear();
                        txt_usuaempl_gr.Clear();
                        txt_idEmpleado_gr.Clear();
                        txt_nomempl_gr.Clear();
                        txt_pas_ad.Clear();
                        txt_correoempl_gr.Clear();

                        MessageBox.Show("Datos Agregados Correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar datos en la tabla
                        cls_Conexion clsConexion1 = new cls_Conexion();
                        clsConexion1.cargarDatos(dtg_administrador_empleado, "Empleado");
                    }

                    BD.cerrar();
                    this.txt_nomempl_gr.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpiar los errores de validación en los campos
                errorP_nombemp_ad.Clear();
                errorP_pas_ad.Clear();
                errorP_tipempl_ad.Clear();
                errorP_usu_ad.Clear();
                errorP_correoempl_ad.Clear();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay campos vacíos
                if (string.IsNullOrWhiteSpace(txt_tipoempl_gr.Text) ||
                    string.IsNullOrWhiteSpace(txt_usuaempl_gr.Text) ||
                    string.IsNullOrWhiteSpace(txt_nomempl_gr.Text) ||
                    string.IsNullOrWhiteSpace(txt_pas_ad.Text) ||
                    string.IsNullOrWhiteSpace(txt_correoempl_gr.Text))
                {
                    MessageBox.Show("Error... No puede modificar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();

                    // Verificar si el username o correo ya están en uso por otro empleado
                    SqlCommand verificar = new SqlCommand("SELECT COUNT(*) FROM Empleado WHERE (username = @username OR correo = @correo) AND codigo_empleado != @codigo_empleado", BD.sconexion);
                    verificar.Parameters.AddWithValue("@username", txt_usuaempl_gr.Text);
                    verificar.Parameters.AddWithValue("@correo", txt_correoempl_gr.Text);
                    verificar.Parameters.AddWithValue("@codigo_empleado", txt_idEmpleado_gr.Text);

                    int count = (int)verificar.ExecuteScalar();

                    if (count > 0)
                    {
                        // Si el username o el correo ya están en uso, mostramos un mensaje de error
                        MessageBox.Show("Error... El usuario o el correo ya están en uso por otro empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Si no hay duplicados, procedemos con la modificación
                        SqlCommand modificar = new SqlCommand("UPDATE Empleado SET nombre_empleado=@nombre_empleado, username=@username, password=@password, correo=@correo, codigo_tipo=@codigo_tipo WHERE codigo_empleado=@codigo_empleado", BD.sconexion);
                        modificar.Parameters.AddWithValue("@codigo_empleado", txt_idEmpleado_gr.Text);
                        modificar.Parameters.AddWithValue("@nombre_empleado", txt_nomempl_gr.Text);
                        modificar.Parameters.AddWithValue("@username", txt_usuaempl_gr.Text);
                        modificar.Parameters.AddWithValue("@password", txt_pas_ad.Text);
                        modificar.Parameters.AddWithValue("@correo", txt_correoempl_gr.Text);
                        modificar.Parameters.AddWithValue("@codigo_tipo", txt_tipoempl_gr.Text);

                        modificar.ExecuteNonQuery();

                        // Limpiar campos y mostrar mensaje de éxito
                        txt_idEmpleado_gr.Clear();
                        txt_nomempl_gr.Clear();
                        txt_tipoempl_gr.Clear();
                        txt_usuaempl_gr.Clear();
                        txt_pas_ad.Clear();
                        txt_correoempl_gr.Clear();

                        MessageBox.Show("Datos Modificados Correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar datos en la tabla
                        cls_Conexion clsConexion1 = new cls_Conexion();
                        clsConexion1.cargarDatos(dtg_administrador_empleado, "Empleado");
                    }

                    BD.cerrar();
                    this.txt_nomempl_gr.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpiar los errores de validación en los campos
                errorP_nombemp_ad.Clear();
                errorP_pas_ad.Clear();
                errorP_tipempl_ad.Clear();
                errorP_usu_ad.Clear();
                errorP_correoempl_ad.Clear();
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tipoempl_gr.Text == string.Empty || txt_usuaempl_gr.Text == string.Empty || txt_idEmpleado_gr.Text == string.Empty || txt_nomempl_gr.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede eliminar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand eliminar = new SqlCommand("delete from Empleado where codigo_empleado=@codigo_empleado", BD.sconexion);
                    eliminar.Parameters.AddWithValue("@codigo_empleado", Convert.ToInt32(txt_idEmpleado_gr.Text));



                    eliminar.ExecuteNonQuery();
                    MessageBox.Show("Aviso... Se eliminaron los datos con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BD.cerrar();
                    txt_idEmpleado_gr.Clear();
                    txt_nomempl_gr.Clear();
                    txt_tipoempl_gr.Clear();
                    txt_usuaempl_gr.Clear();
                    txt_pas_ad.Clear();
                    errorP_correoempl_ad.Clear();



                    this.txt_idEmpleado_gr.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dtg_administrador_empleado, "Empleado");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }


        Class1 validaciones = new Class1();
        private void txt_nombretxt_nomempl_gr_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_nomempl_gr_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetras(txt_nomempl_gr.Text, "El nombre no permite caracteres especiales"))
            {
                errorP_nombemp_ad.SetError(txt_nomempl_gr, "El nombre no permite caracteres especiales");
                txt_nomempl_gr.Text = "";
            }
        }

        private void txt_pas_ad_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarlogin(txt_pas_ad.Text, "La password solo debe contener letras y numeros"))
            {
                errorP_pas_ad.SetError(txt_pas_ad, "La password solo debe contener letras y numeros");
                txt_pas_ad.Text = "";
            }
        }

        private void txt_usuaempl_gr_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarlogin(txt_usuaempl_gr.Text, "El usuario no permite caracteres especiales"))
            {
                errorP_usu_ad.SetError(txt_usuaempl_gr, "El usuario no permite caracteres especiales");
                txt_usuaempl_gr.Text = "";
            }
        }

        private void txt_tipoempl_gr_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validartipo_u(txt_tipoempl_gr.Text, "El tipo de empleado solo debe contener numeros del 1-3"))
            {
                errorP_tipempl_ad.SetError(txt_tipoempl_gr, "El tipo de empleado solo debe contener numeros del 1-3");
                txt_tipoempl_gr.Text = "";
            }
        }

        private void dtg_administrador_empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_correoempl_gr_TextChanged(object sender, EventArgs e)
        {
            
                //if (validaciones.validarcorreo(txt_correoempl_gr.Text, "El correo solo permite @ _ . y letras"))
                //{
                    //errorP_correoempl_ad.SetError(txt_correoempl_gr, "El correo solo permite @ _ . y letras");
                    //txt_correoempl_gr.Text = "";
                //}
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
