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
using static Drogueria_proyecto.fr_menu_gerente;
using System.Runtime.InteropServices;


namespace Drogueria_proyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            // Asegurar que la barra de tareas sea visible
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            
            textUsuario.MaxLength = 50;
            textContrasena.MaxLength = 80;
            textUsuario.TextChanged += new EventHandler(VerificarCampos);
            textContrasena.TextChanged += new EventHandler(VerificarCampos);
            textUsuario.KeyDown += new KeyEventHandler(AvanzarConEnter);
            textContrasena.KeyDown += new KeyEventHandler(AvanzarConEnter);

            // Llamamos a la función de verificación al iniciar para manejar estado inicial
            VerificarCampos(null, null);



        }
        // Función que verifica si los campos de usuario y contraseña están vacíos
        private void VerificarCampos(object sender, EventArgs e)
        {
            // Si ambos campos tienen texto, habilitar el botón; de lo contrario, deshabilitar
            button1.Enabled = !string.IsNullOrWhiteSpace(textUsuario.Text) &&
                               !string.IsNullOrWhiteSpace(textContrasena.Text);
        }
        private void AvanzarConEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;  // Evita que se realicen otras acciones por defecto (como borrar)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }




        private void cb_cargo_login_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Color bgColor = RGBColors.colorBg;
            BackColor = bgColor;
            textUsuario.Focus();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

          //  int tipousuario;
            int tipologin = 0;
           
            

             //   tipousuario = 1;
                cls_Conexion BD = new cls_Conexion();
                BD.abrir();

                SqlCommand cmd = new SqlCommand("SELECT codigo_tipo, username, password FROM Empleado WHERE username=@usuario AND password=@pas", BD.sconexion);

                cmd.Parameters.AddWithValue("usuario", textUsuario.Text.ToString());
                cmd.Parameters.AddWithValue("pas", textContrasena.Text.ToString());
                SqlDataReader sda;

                sda = cmd.ExecuteReader();
                if (sda.Read() == true)
                {
                  
                    tipologin = Convert.ToInt32(sda[0]);
                    if(tipologin == 1)
                {
                    MessageBox.Show("Usuario Encontrado");
                    Login.ActiveForm.Hide();
                    fr_menu_gerente Gerenteform = new fr_menu_gerente();
                    Gerenteform.Show();
                }
                    if (tipologin == 2)
                {   
                     MessageBox.Show("Usuario Encontrado");
                     Login.ActiveForm.Hide();
                     Fr_Administrador Administradorform = new Fr_Administrador();
                     Administradorform.Show();
                }
                if (tipologin == 3)
                {
                    MessageBox.Show("Usuario Encontrado");
                    Login.ActiveForm.Hide();
                    fr_Vendedor_menu Vendedorform = new fr_Vendedor_menu();
                    Vendedorform.Show();

                }
                    

                }
                else
                {
                    MessageBox.Show("Usuario No Encontrado");
                }
                BD.cerrar();

            errorP_usuario_login.Clear();
            errorP_pas_login.Clear();

            }
        

        //Metodo para ocultar la contraseña o mostrarla mediante un checkbox

        private void checkBox_contra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_contra.Checked == true)
            {
                textContrasena.PasswordChar = '\0';
            }
            else
            {
                textContrasena.PasswordChar = '*';

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Class1 validaciones = new Class1();

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarlogin (textUsuario.Text, "El nombre de usuario no permite caracteres especiales"))
            {
                errorP_usuario_login.SetError(textUsuario, "El nombre de usuario no permite caracteres especiales");
                textUsuario.Text = "";

            }
            // Formatear: la primera letra en mayúscula y el resto en minúsculas
            if (textUsuario.Text.Length > 0)
            {
                textUsuario.Text = char.ToUpper(textUsuario.Text[0]) + textUsuario.Text.Substring(1).ToLower();

                // Mantener el cursor al final del texto
                textUsuario.SelectionStart = textUsuario.Text.Length;
            }
            
        }

        private void textContrasena_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarlogin(textContrasena.Text, "La password no permite caracteres especiales"))
            {
                errorP_pas_login.SetError(textContrasena, "La password no permite caracteres especiales");
                textContrasena.Text = "";

            }
            //else if (validaciones.validarEmpty(textContrasena.Text, "La password no puede estar vacio"))
            //{
            //    errorP_pas_login.SetError(textContrasena, "La password no puede estar vacio");

            //}

        }

        private void BtnSecurityPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crear una instancia del nuevo formulario
            SecurityForm SForm = new SecurityForm();
            

            // Mostrar el nuevo formulario
            SForm.Show();

            // Ocultar el formulario actual

            // Opcional: puedes cerrar el formulario actual si ya no lo necesitas
            // this.Close();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        /// <summary>
        /// Minimiza el formulario cuando se hace clic en el botón de minimizar.
        /// </summary>
        public void ToggleWindoeStateMini()
        {
            // Cambiar el estado de la ventana a minimizado
             this.WindowState = FormWindowState.Minimized;
            
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            ToggleWindoeStateMini();
        }

        /// <summary>
        /// Maximiza o restaura el tamaño del formulario cuando se hace clic en el botón de maximizar.
        /// </summary>
        public void ToggleWindowState()
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            ToggleWindowState();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /// <summary>
        /// Maneja el evento de redimensionamiento del formulario fr_menu_gerente.
        /// </summary>
        public void ToggleRezise() {

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

        private void Login_Resize(object sender, EventArgs e)
        {
            ToggleRezise();
           
        }
    }



}

   