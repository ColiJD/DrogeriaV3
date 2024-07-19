using FontAwesome.Sharp;
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
    public partial class fr_Vendedor_menu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public fr_Vendedor_menu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            panelDesktop.Dock = DockStyle.Fill;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            // Asegurar que la barra de tareas sea visible
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
        }
        private void timerV_Tick(object sender, EventArgs e)
        {
            labelhorag.Text = DateTime.Now.ToString("HH:mm:ss");
            labelfechag.Text = DateTime.Now.ToLongDateString();

        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fr_Vendedor_menu_Resize(object sender, EventArgs e)
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

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void button_menug_Product_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorTxtWhile);
            OpenChildForm(new fr_Productos_vendedor());
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            Login FrmLogin = new Login();
            FrmLogin.Show();
            this.Close();

        }
        //Structs
        public struct RGBColors
        {
            public static Color colorBotones = Color.FromArgb(3, 144, 183);
            public static Color colorPanel = Color.FromArgb(18, 93, 120);
            public static Color colorTxtWhile = Color.FromArgb(255, 255, 255);
            public static Color colorBg = Color.FromArgb(10, 115, 148);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.colorPanel;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                LbTituloPanel.Text = currentBtn.Text.ToUpper();
                LbTituloPanel.Font = new Font(LbTituloPanel.Font, FontStyle.Bold);

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.colorBotones;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                LbTituloPanel.Text = "BIENVENIDO VENDEDOR";
            }
        }

        public void OpenChildForm(Form childForm)
        {
            // Cerrar el formulario hijo actual si existe
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;

            // Configurar el nuevo formulario hijo
            childForm.TopLevel = false; // No se comporta como un formulario principal
            childForm.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            childForm.Dock = DockStyle.Fill; // Ocupar todo el espacio disponible

            // Añadir el formulario hijo al panel contenedor
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;

            // Traer al frente y mostrar el formulario hijo
            childForm.BringToFront();
            childForm.Show();
        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    }

}
