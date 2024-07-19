
namespace Drogueria_proyecto
{
    partial class fr_cargos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_cargos));
            this.button_cargo_g = new System.Windows.Forms.Button();
            this.button_cargo_ad = new System.Windows.Forms.Button();
            this.button_cargo_vend = new System.Windows.Forms.Button();
            this.PanelTitulo = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.BtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cargo_g
            // 
            this.button_cargo_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cargo_g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.button_cargo_g.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cargo_g.ForeColor = System.Drawing.Color.White;
            this.button_cargo_g.Location = new System.Drawing.Point(303, 165);
            this.button_cargo_g.Margin = new System.Windows.Forms.Padding(1);
            this.button_cargo_g.Name = "button_cargo_g";
            this.button_cargo_g.Size = new System.Drawing.Size(180, 60);
            this.button_cargo_g.TabIndex = 0;
            this.button_cargo_g.Text = "Gerente";
            this.button_cargo_g.UseVisualStyleBackColor = false;
            // 
            // button_cargo_ad
            // 
            this.button_cargo_ad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cargo_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.button_cargo_ad.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cargo_ad.ForeColor = System.Drawing.Color.White;
            this.button_cargo_ad.Location = new System.Drawing.Point(303, 242);
            this.button_cargo_ad.Margin = new System.Windows.Forms.Padding(1);
            this.button_cargo_ad.Name = "button_cargo_ad";
            this.button_cargo_ad.Size = new System.Drawing.Size(180, 60);
            this.button_cargo_ad.TabIndex = 1;
            this.button_cargo_ad.Text = "Administrador";
            this.button_cargo_ad.UseVisualStyleBackColor = false;
            // 
            // button_cargo_vend
            // 
            this.button_cargo_vend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cargo_vend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.button_cargo_vend.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cargo_vend.ForeColor = System.Drawing.Color.White;
            this.button_cargo_vend.Location = new System.Drawing.Point(303, 320);
            this.button_cargo_vend.Margin = new System.Windows.Forms.Padding(1);
            this.button_cargo_vend.Name = "button_cargo_vend";
            this.button_cargo_vend.Size = new System.Drawing.Size(180, 60);
            this.button_cargo_vend.TabIndex = 2;
            this.button_cargo_vend.Text = "Vendedor";
            this.button_cargo_vend.UseVisualStyleBackColor = false;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.PanelTitulo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.PanelTitulo.Controls.Add(this.BtnSalir);
            this.PanelTitulo.Controls.Add(this.BtnMaximizar);
            this.PanelTitulo.Controls.Add(this.BtnMinimizar);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(784, 60);
            this.PanelTitulo.TabIndex = 3;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalir.IconSize = 25;
            this.BtnSalir.Location = new System.Drawing.Point(722, 17);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(31, 31);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.AutoSize = true;
            this.BtnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximizar.IconColor = System.Drawing.Color.White;
            this.BtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximizar.IconSize = 25;
            this.BtnMaximizar.Location = new System.Drawing.Point(685, 17);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(31, 31);
            this.BtnMaximizar.TabIndex = 3;
            this.BtnMaximizar.UseVisualStyleBackColor = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.AutoSize = true;
            this.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizar.IconColor = System.Drawing.Color.White;
            this.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimizar.IconSize = 25;
            this.BtnMinimizar.Location = new System.Drawing.Point(648, 17);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(31, 31);
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // fr_cargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.BackgroundImage = global::Drogueria_proyecto.Properties.Resources.Fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.button_cargo_vend);
            this.Controls.Add(this.button_cargo_ad);
            this.Controls.Add(this.button_cargo_g);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(800, 599);
            this.Name = "fr_cargos";
            this.Opacity = 0.85D;
            this.Text = "CARGO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.fr_cargos_Resize);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cargo_g;
        private System.Windows.Forms.Button button_cargo_ad;
        private System.Windows.Forms.Button button_cargo_vend;
        private Guna.UI2.WinForms.Guna2Panel PanelTitulo;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnMaximizar;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
    }
}

