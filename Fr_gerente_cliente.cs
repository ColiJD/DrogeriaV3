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
    public partial class Fr_gerente_cliente : Form
    {
        public Fr_gerente_cliente()
        {
            InitializeComponent();
        }

        // Boton para regresar al menu de gerente
        private void button_grcli_regresar_Click(object sender, EventArgs e)
        {
            
            this.Close();
            fr_menu_gerente fr_Menu_Gerente = new fr_menu_gerente();
            fr_Menu_Gerente.Show();

        }

        //Metodo al cargar del formulario
        /// <param name="cls_Conexion"></Crea una instancia a la clase conexion>


        private void FrmLector_Load(object sender, EventArgs e)
        {
            cls_Conexion clsConexion1 = new cls_Conexion();
            clsConexion1.cargarDatos(dgv_gerente_clientes);
        }
        int i;

        

        private void dgv_gerente_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            txt_idcliente_gr.Text = dgv_gerente_clientes.CurrentRow.Cells[0].Value.ToString();
            txt_nombclien_gr.Text = dgv_gerente_clientes.CurrentRow.Cells[1].Value.ToString();
            txt_gr_dirclien.Text = dgv_gerente_clientes.CurrentRow.Cells[2].Value.ToString();
            txt_gr_correoclien.Text = dgv_gerente_clientes.CurrentRow.Cells[3].Value.ToString();
            txt_gr_telclien.Text = dgv_gerente_clientes.CurrentRow.Cells[4].Value.ToString();
        }

        
       
        private void Fr_gerente_cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet5.Cliente' Puede moverla o quitarla según sea necesario.
            clienteTableAdapter.Fill(dROGUERIADataSet5.Cliente);
           // cls_Conexion BD = new cls_Conexion();
            //BD.abrir();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", BD.sconexion);

            
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dgv_gerente_clientes.DataSource = dt;
            //BD.cerrar();
        }

        private void dgv_gerente_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Metodo al seleccion una celda del datagridview

        private void dgv_gerente_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idcliente_gr.Text = dgv_gerente_clientes.CurrentRow.Cells[0].Value.ToString();
            txt_nombclien_gr.Text = dgv_gerente_clientes.CurrentRow.Cells[1].Value.ToString();
            txt_gr_dirclien.Text = dgv_gerente_clientes.CurrentRow.Cells[2].Value.ToString();
            txt_gr_correoclien.Text = dgv_gerente_clientes.CurrentRow.Cells[3].Value.ToString();
            txt_gr_telclien.Text = dgv_gerente_clientes.CurrentRow.Cells[4].Value.ToString();

        }

        //Boton que realiza la accion de agregar los datos a la base de datos

        private void btn_gr_agreclien_Click_1(object sender, EventArgs e)
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
                    SqlCommand agregar = new SqlCommand("insert into Cliente values (@nombre_cliente ,@direccion_cliente,@correo_cliente,@telefono_cliente)", BD.sconexion);
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

                    this.txt_idcliente_gr.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dgv_gerente_clientes, "Cliente");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
            errorP_nombcl_gr.Clear();
            errorP_dirc_cl_g.Clear();
            errorP_tel_cl_g.Clear();
            errorPro_correocli_g.Clear();
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
                    eliminar.Parameters.AddWithValue("@codigo_cliente",Convert.ToInt32(txt_idcliente_gr.Text));
                   


                    eliminar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_idcliente_gr.Clear();
                    txt_nombclien_gr.Clear();
                    txt_gr_correoclien.Clear();
                    txt_gr_dirclien.Clear();
                    txt_gr_telclien.Clear();

                    this.txt_idcliente_gr.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dgv_gerente_clientes, "Cliente");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }

        }

        private void btn_gr_modclien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombclien_gr.Text == string.Empty || txt_gr_correoclien.Text == string.Empty || txt_gr_dirclien.Text == string.Empty || txt_gr_correoclien.Text == string.Empty || txt_gr_telclien.Text == string.Empty)
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
                    modificar.Parameters.AddWithValue("@direccion_cliente", txt_gr_dirclien.Text);
                    modificar.Parameters.AddWithValue("@correo_cliente", txt_gr_correoclien.Text);
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
                    clsConexion1.cargarDatos(dgv_gerente_clientes, "Cliente");
                }
           }
            catch
           {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
            errorP_nombcl_gr.Clear();
            errorP_dirc_cl_g.Clear();
            errorP_tel_cl_g.Clear();
            errorPro_correocli_g.Clear();

        }
        Class1 validaciones = new Class1();
        private void txt_nombclien_gr_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetrasyNumeros(txt_nombclien_gr.Text, "El nombre solo permite # numeros y letras"))
            {
                errorP_nombcl_gr.SetError(txt_nombclien_gr, "El nombre solo permite # numeros y letras");
                txt_nombclien_gr.Text = "";

            }
        }

        private void txt_gr_correoclien_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarcorreo(txt_gr_correoclien.Text, "El correo solo permite @ _ . y letras"))
            {
                errorPro_correocli_g.SetError(txt_gr_correoclien, "El correo solo permite @ _ . y letras");
                txt_gr_correoclien.Text = "";

            }
        }

        private void txt_gr_dirclien_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetrasyNumeros(txt_gr_dirclien.Text, "La direccion solo permite # numeros y letras"))
            {
                errorP_dirc_cl_g.SetError(txt_gr_dirclien, "La direccion solo permite # numeros y letras");
                txt_gr_dirclien.Text = "";
            }
        }

        private void txt_gr_telclien_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarNumeros(txt_gr_telclien.Text, "El numero de telefono solo debe contener numeros"))
            {
                errorP_tel_cl_g.SetError(txt_gr_telclien, "El numero de telefono solo debe contener numeros");
                txt_gr_telclien.Text = "";
            }
        }
    }
}
