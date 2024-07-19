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
    public partial class Fr_gerente_proveedores : Form
    {
        public Fr_gerente_proveedores()
        {
            InitializeComponent();
        }

        private void btn_gr_agreprov_Click(object sender, EventArgs e)
        {
            try { 

            if (txt_gr_corprov.Text == string.Empty ||txt_gr_desprov.Text == string.Empty || txt_gr_nomprov.Text == string.Empty || txt_gr_telprov.Text == string.Empty )
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand agregar = new SqlCommand("insert into Proveedor values (@nombre_proveedor ,@direccion_proveedor,@correo_proveedor, @telefono_proveedor)", BD.sconexion);
                    agregar.Parameters.AddWithValue("@nombre_proveedor", txt_gr_nomprov.Text);
                    agregar.Parameters.AddWithValue("@direccion_proveedor", txt_gr_desprov.Text);
                    agregar.Parameters.AddWithValue("@correo_proveedor", txt_gr_corprov.Text);
                    agregar.Parameters.AddWithValue("@telefono_proveedor", txt_gr_telprov.Text);


                    agregar.ExecuteNonQuery();
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
            errorP_direcprov_g.Clear();
            errorP_nombprov_g.Clear();
            errorP_telprov_g.Clear();

            
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
                if (txt_gr_corprov.Text == string.Empty || txt_gr_desprov.Text == string.Empty || txt_gr_telprov.Text == string.Empty || txt_gr_nomprov.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede modificar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand modificar = new SqlCommand("update Proveedor set nombre_proveedor=@nombre_proveedor,direccion_proveedor=@direccion_proveedor ,correo_proveedor=@correo_proveedor," +
                        "telefono_proveedor=@telefono_proveedor where codigo_proveedor=@codigo_proveedor", BD.sconexion);
                    modificar.Parameters.AddWithValue("@codigo_proveedor", txt_codprov_gr.Text);
                    modificar.Parameters.AddWithValue("@nombre_proveedor", txt_gr_nomprov.Text);
                    modificar.Parameters.AddWithValue("@direccion_proveedor", txt_gr_desprov.Text);
                    modificar.Parameters.AddWithValue("@correo_proveedor", txt_gr_corprov.Text);
                    modificar.Parameters.AddWithValue("@telefono_proveedor", txt_gr_telprov.Text);


                    modificar.ExecuteNonQuery();
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
            errorP_direcprov_g.Clear();
            errorP_nombprov_g.Clear();
            errorP_telprov_g.Clear();

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
            if (validaciones.validarNumeros(txt_gr_telprov.Text, "El numero de telefono solo debe contener numeros"))
            {
                errorP_telprov_g.SetError(txt_gr_telprov, "El numero de telefono solo debe contener numeros");
                txt_gr_telprov.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
    

