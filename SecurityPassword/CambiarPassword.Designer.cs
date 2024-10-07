
namespace Drogueria_proyecto.SecurityPassword
{
    partial class CambiarPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.txbNPass = new System.Windows.Forms.TextBox();
            this.txbActual = new System.Windows.Forms.TextBox();
            this.lbActual = new System.Windows.Forms.Label();
            this.lbNPass = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbConfirmarPass = new System.Windows.Forms.TextBox();
            this.PanelTitulo = new Guna.UI2.WinForms.Guna2Panel();
            this.LbTituloPanel = new System.Windows.Forms.Label();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btnCambiarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarPass.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCambiarPass.Location = new System.Drawing.Point(33, 394);
            this.btnCambiarPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(135, 49);
            this.btnCambiarPass.TabIndex = 0;
            this.btnCambiarPass.Text = "Cambiar";
            this.btnCambiarPass.UseVisualStyleBackColor = false;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // txbNPass
            // 
            this.txbNPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNPass.Location = new System.Drawing.Point(33, 265);
            this.txbNPass.Margin = new System.Windows.Forms.Padding(2);
            this.txbNPass.Multiline = true;
            this.txbNPass.Name = "txbNPass";
            this.txbNPass.Size = new System.Drawing.Size(424, 24);
            this.txbNPass.TabIndex = 1;
            // 
            // txbActual
            // 
            this.txbActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbActual.Location = new System.Drawing.Point(33, 182);
            this.txbActual.Margin = new System.Windows.Forms.Padding(2);
            this.txbActual.Multiline = true;
            this.txbActual.Name = "txbActual";
            this.txbActual.Size = new System.Drawing.Size(424, 24);
            this.txbActual.TabIndex = 2;
            // 
            // lbActual
            // 
            this.lbActual.AutoSize = true;
            this.lbActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbActual.Location = new System.Drawing.Point(31, 154);
            this.lbActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActual.Name = "lbActual";
            this.lbActual.Size = new System.Drawing.Size(224, 29);
            this.lbActual.TabIndex = 3;
            this.lbActual.Text = "Contraseña Actual";
            // 
            // lbNPass
            // 
            this.lbNPass.AutoSize = true;
            this.lbNPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNPass.Location = new System.Drawing.Point(29, 229);
            this.lbNPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNPass.Name = "lbNPass";
            this.lbNPass.Size = new System.Drawing.Size(227, 29);
            this.lbNPass.TabIndex = 4;
            this.lbNPass.Text = "Nueva Contraseña";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUsuario.Location = new System.Drawing.Point(31, 77);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(103, 29);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuario";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(33, 107);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txbUsuario.Multiline = true;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(424, 24);
            this.txbUsuario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(32, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nueva Contraseña";
            // 
            // txbConfirmarPass
            // 
            this.txbConfirmarPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbConfirmarPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConfirmarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmarPass.Location = new System.Drawing.Point(36, 340);
            this.txbConfirmarPass.Margin = new System.Windows.Forms.Padding(2);
            this.txbConfirmarPass.Multiline = true;
            this.txbConfirmarPass.Name = "txbConfirmarPass";
            this.txbConfirmarPass.Size = new System.Drawing.Size(424, 24);
            this.txbConfirmarPass.TabIndex = 7;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.PanelTitulo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.PanelTitulo.Controls.Add(this.LbTituloPanel);
            this.PanelTitulo.Controls.Add(this.BtnSalir);
            this.PanelTitulo.Controls.Add(this.btnHome);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(493, 60);
            this.PanelTitulo.TabIndex = 9;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // LbTituloPanel
            // 
            this.LbTituloPanel.AutoSize = true;
            this.LbTituloPanel.BackColor = System.Drawing.Color.Transparent;
            this.LbTituloPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTituloPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LbTituloPanel.Location = new System.Drawing.Point(132, 19);
            this.LbTituloPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LbTituloPanel.Name = "LbTituloPanel";
            this.LbTituloPanel.Size = new System.Drawing.Size(251, 24);
            this.LbTituloPanel.TabIndex = 6;
            this.LbTituloPanel.Text = "CAMBIO DE CONTRASEÑA";
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
            this.BtnSalir.Location = new System.Drawing.Point(431, 17);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(31, 31);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 25;
            this.btnHome.Location = new System.Drawing.Point(15, 17);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(31, 26);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // CambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(493, 533);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbConfirmarPass);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lbNPass);
            this.Controls.Add(this.lbActual);
            this.Controls.Add(this.txbActual);
            this.Controls.Add(this.txbNPass);
            this.Controls.Add(this.btnCambiarPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CambiarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarPassword";
            this.Load += new System.EventHandler(this.CambiarPassword_Load);
            this.Resize += new System.EventHandler(this.CambiarPassword_Resize);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarPass;
        private System.Windows.Forms.TextBox txbNPass;
        private System.Windows.Forms.TextBox txbActual;
        private System.Windows.Forms.Label lbActual;
        private System.Windows.Forms.Label lbNPass;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbConfirmarPass;
        private Guna.UI2.WinForms.Guna2Panel PanelTitulo;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Label LbTituloPanel;
    }
}