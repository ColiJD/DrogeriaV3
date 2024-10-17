using Drogueria_proyecto.SecurityPassword;
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
//Se agrego el campo de correo a la base de datos revicen que este actualizada 
namespace Drogueria_proyecto
{
    public partial class SecurityForm : Form
    {
        public SecurityForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            // Establecer el estilo del borde del formulario a un tamaño fijo
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Opcional: Deshabilitar los botones de maximizar y minimizar si también lo deseas
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txbCorreo.KeyDown += new KeyEventHandler(AvanzarConEnter);
            txbCorreo.MaxLength = 80;
            txbCorreo.TextChanged += new EventHandler(VerificarCampos);
            // Llamamos a la función de verificación al iniciar para manejar estado inicial
            VerificarCampos(null, null);

        }
        private void VerificarCampos(object sender, EventArgs e)
        {
            // Si ambos campos tienen texto, habilitar el botón; de lo contrario, deshabilitar
            btnEnviar.Enabled = !string.IsNullOrWhiteSpace(txbCorreo.Text);
        }
        private void AvanzarConEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;  // Evita que se realicen otras acciones por defecto (como borrar)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void SecurityForm_Load(object sender, EventArgs e)
        {
            txbCorreo.Focus();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = new NrecuperarPassword();
            var result = user.recoverPassword(txbCorreo.Text);
            MessageBox.Show(result, "Resultado de la Recuperación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbCorreo.Text = "";
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            CambiarPassword CP = new CambiarPassword();
            txbCorreo.Text = "";
            CP.Show();
            this.Hide();
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

        private void SecurityForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Si la ventana está maximizada, quita el borde del formulario
                FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            else
            {
                // Si la ventana no está maximizada, permite redimensionar el formulario
                FormBorderStyle = FormBorderStyle.FixedSingle;
                CenterToScreen();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
