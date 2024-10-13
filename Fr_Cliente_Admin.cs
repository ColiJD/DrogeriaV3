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
    public partial class Fr_Cliente_Admin : Form
    {
        public Fr_Cliente_Admin()
        {
            InitializeComponent();
        }

        private void FrmLector_Load(object sender, EventArgs e)
        {
            cls_Conexion clsConexion1 = new cls_Conexion();
            clsConexion1.cargarDatos(dtg_administrador_empleado);
        }
        int i;

        private void Fr_Cliente_Admin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet1.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dROGUERIADataSet1.Cliente);

        }





        private void dgv_gerente_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idcliente_gr.Text = dtg_administrador_empleado.CurrentRow.Cells[0].Value.ToString();
            txt_nombclien_gr.Text = dtg_administrador_empleado.CurrentRow.Cells[1].Value.ToString();
            txt_gr_dirclien.Text = dtg_administrador_empleado.CurrentRow.Cells[2].Value.ToString();
            txt_gr_correoclien.Text = dtg_administrador_empleado.CurrentRow.Cells[3].Value.ToString();
            txt_gr_telclien.Text = dtg_administrador_empleado.CurrentRow.Cells[4].Value.ToString();

        }

        Class1 validaciones = new Class1();
        private void txt_gr_telclien_TextChanged_1(object sender, EventArgs e)
        {
            if (validaciones.validarMinimoOchoCaracteres(txt_gr_telclien.Text, "Ingrese minimo 8 caracteres"))
            {
               // errorP_telcl_ad.SetError(txt_gr_telclien, "Ingrese minimo 8 caracteres");
                
            }
            if ((validaciones.validarMinimoOchoCaracteres(txt_gr_telclien.Text, "Ingrese minimo 8 caracteres") &&
                (validaciones.validarNumeros(txt_gr_telclien.Text, "La direccion solo debe contener  numeros"))))
            {
                errorP_telcl_ad.SetError(txt_gr_telclien, "La direccion solo debe contener numeros");
                txt_gr_telclien.Text = "";
            }
            


        }

        private void txt_gr_dirclien_TextChanged_1(object sender, EventArgs e)

        {
            if (validaciones.validarLetrasyNumeros(txt_gr_dirclien.Text, "La direccion solo debe contener letras y numeros"))
            {
                errorP_dircl_ad.SetError(txt_gr_dirclien, "La direccion solo debe contener letras y numeros");
                txt_gr_dirclien.Text = "";
            }
           
            
        }

        private void txt_gr_correoclien_TextChanged_1(object sender, EventArgs e)
        {
            if (validaciones.validarcorreo(txt_gr_correoclien.Text, "El correo solo permite @ _ . y letras"))
            {
                errorPro_correoCli_ad.SetError(txt_gr_correoclien, "El correo solo permite @ _ . y letras");
                txt_gr_correoclien.Text = "";
            }
        }

        private void txt_nombclien_gr_TextChanged_1(object sender, EventArgs e)
        {
            if (validaciones.validarLetrasyNumeros(txt_nombclien_gr.Text, "El nombre solo permite # numeros y letras"))
            {
                errorP_nombcli_ad.SetError(txt_nombclien_gr, "El nombre solo permite # numeros y letras");
                txt_nombclien_gr.Text = "";
            }
        }

        private void btn_gr_agreclien_Click(object sender, EventArgs e)
        {
                try
                {
                    if (txt_nombclien_gr.Text == string.Empty || txt_gr_correoclien.Text == string.Empty || txt_gr_dirclien.Text == string.Empty || txt_gr_correoclien.Text == string.Empty || txt_gr_telclien.Text == string.Empty)
                    {
                        MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        cls_Conexion BD = new cls_Conexion();
                        BD.abrir();
                    if (txt_gr_telclien.Text.Length >= 8)
                    {
                        SqlCommand agregar = new SqlCommand("insert into Cliente values (@nombre_cliente,@direccion_cliente, @correo_cliente,@telefono_cliente)", BD.sconexion);
                        agregar.Parameters.AddWithValue("@nombre_cliente", txt_nombclien_gr.Text);
                        agregar.Parameters.AddWithValue("@correo_cliente", txt_gr_correoclien.Text);
                        agregar.Parameters.AddWithValue("@direccion_cliente", txt_gr_dirclien.Text);
                        agregar.Parameters.AddWithValue("@telefono_cliente", txt_gr_telclien.Text);
                        agregar.ExecuteNonQuery();

                        BD.cerrar();
                        txt_idcliente_gr.Clear();
                        txt_nombclien_gr.Clear();
                        txt_gr_correoclien.Clear();
                        txt_gr_dirclien.Clear();
                        txt_gr_telclien.Clear();
                    }
                    else { MessageBox.Show("Error telefono invalido"); }

                    txt_gr_telclien.Clear();







                    this.txt_idcliente_gr.Focus();
                        cls_Conexion clsConexion1 = new cls_Conexion();
                        clsConexion1.cargarDatos(dtg_administrador_empleado, "Cliente");
                    }
                }
                catch
                {
                    MessageBox.Show("Error...El codigo ya existe en la base de datos");
                }
                errorP_nombcli_ad.Clear();
                errorP_dircl_ad.Clear();
                errorP_dircl_ad.Clear();
                errorPro_correoCli_ad.Clear();
            
        }

        private void btn_gr_modclien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombclien_gr.Text == string.Empty || txt_gr_correoclien.Text == string.Empty || txt_gr_dirclien.Text == string.Empty || txt_gr_telclien.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede modificar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand modificar = new SqlCommand("update Cliente set nombre_cliente=@nombre_cliente,direccion_cliente=@direccion_cliente,correo_cliente=@correo_cliente," +
                        "telefono_cliente=@telefono_cliente where codigo_cliente=@codigo_cliente", BD.sconexion);
                    modificar.Parameters.AddWithValue("@codigo_cliente", txt_idcliente_gr.Text);
                    modificar.Parameters.AddWithValue("@nombre_cliente", txt_nombclien_gr.Text);
                    modificar.Parameters.AddWithValue("@correo_cliente", txt_gr_correoclien.Text);
                    modificar.Parameters.AddWithValue("@direccion_cliente", txt_gr_dirclien.Text);
                    modificar.Parameters.AddWithValue("@telefono_cliente", txt_gr_telclien.Text);


                    modificar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_idcliente_gr.Clear();
                    txt_nombclien_gr.Clear();
                    txt_gr_correoclien.Clear();
                    txt_gr_dirclien.Clear();
                    txt_gr_telclien.Clear();

                    this.txt_idcliente_gr.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dtg_administrador_empleado, "Cliente");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
            errorP_nombcli_ad.Clear();
            errorP_dircl_ad.Clear();
            errorP_dircl_ad.Clear();
            errorPro_correoCli_ad.Clear();
        }

        private void btn_gr_eliclien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombclien_gr.Text == string.Empty || txt_gr_correoclien.Text == string.Empty || txt_gr_dirclien.Text == string.Empty || txt_gr_correoclien.Text == string.Empty || txt_gr_telclien.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede eliminar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand eliminar = new SqlCommand("delete from Cliente where codigo_cliente=@codigo_cliente", BD.sconexion);
                    eliminar.Parameters.AddWithValue("@codigo_cliente", Convert.ToInt32(txt_idcliente_gr.Text));



                    eliminar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_idcliente_gr.Clear();
                    txt_nombclien_gr.Clear();
                    txt_gr_correoclien.Clear();
                    txt_gr_dirclien.Clear();
                    txt_gr_telclien.Clear();

                    this.txt_idcliente_gr.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dtg_administrador_empleado, "Cliente");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void dtg_administrador_empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_administrador_empleado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
