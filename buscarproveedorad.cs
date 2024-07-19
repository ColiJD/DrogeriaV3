using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drogueria_proyecto
{
    public partial class buscarproveedorad : Form
    {
        fr_Producto_Admin administradorform = new fr_Producto_Admin();
        public buscarproveedorad()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Normal;
            // Asegurar que la barra de tareas sea visible
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

        }

        private void buscarproveedorad_Load(object sender, EventArgs e)
        {
            // esta línea de código carga datos en la tabla 'dROGUERIADataSet8.Proveedor' 
            this.proveedorTableAdapter.Fill(this.dROGUERIADataSet8.Proveedor);
            cls_Conexion conexion = new cls_Conexion();
            conexion.cargarDatos(dataGridView1, "Proveedor");
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            // Obtén una referencia al formulario padre
            var administradorform = this.Owner as fr_Producto_Admin;
            if (administradorform != null)
            {
                administradorform.txt_provinv_ad.Text = id;
            }

            this.Close();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buscarproveedorad_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Si la ventana está maximizada, quita el borde del formulario
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                // Si la ventana no está maximizada, permite redimensionar el formulario
                FormBorderStyle = FormBorderStyle.Sizable;
                CenterToScreen();
            }
        }
    }
}
