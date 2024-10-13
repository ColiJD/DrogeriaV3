
namespace Drogueria_proyecto
{
    partial class Fr_Empleado_Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Empleado_Admin));
            this.dtg_administrador_empleado = new System.Windows.Forms.DataGridView();
            this.codigoempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigotipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet2 = new Drogueria_proyecto.DROGUERIADataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idEmpleado_gr = new System.Windows.Forms.TextBox();
            this.txt_usuaempl_gr = new System.Windows.Forms.TextBox();
            this.txt_nomempl_gr = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txt_tipoempl_gr = new System.Windows.Forms.TextBox();
            this.txt_pas_ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorP_usu_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_nombemp_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_pas_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_tipempl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_correoempl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txt_correoempl_gr = new System.Windows.Forms.TextBox();
            this.empleadoTableAdapter = new Drogueria_proyecto.DROGUERIADataSet2TableAdapters.EmpleadoTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_administrador_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_usu_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombemp_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_pas_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tipempl_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_correoempl_ad)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_administrador_empleado
            // 
            this.dtg_administrador_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_administrador_empleado.AutoGenerateColumns = false;
            this.dtg_administrador_empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_administrador_empleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.dtg_administrador_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_administrador_empleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoempleadoDataGridViewTextBoxColumn,
            this.nombreempleadoDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.codigotipoDataGridViewTextBoxColumn,
            this.correo});
            this.dtg_administrador_empleado.DataSource = this.empleadoBindingSource;
            this.dtg_administrador_empleado.Location = new System.Drawing.Point(0, 323);
            this.dtg_administrador_empleado.Name = "dtg_administrador_empleado";
            this.dtg_administrador_empleado.RowHeadersVisible = false;
            this.dtg_administrador_empleado.RowHeadersWidth = 51;
            this.dtg_administrador_empleado.RowTemplate.Height = 46;
            this.dtg_administrador_empleado.Size = new System.Drawing.Size(784, 240);
            this.dtg_administrador_empleado.TabIndex = 1;
            this.dtg_administrador_empleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_administrador_empleado_CellContentClick);
            this.dtg_administrador_empleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerente_clientes_CellDoubleClick);
            // 
            // codigoempleadoDataGridViewTextBoxColumn
            // 
            this.codigoempleadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoempleadoDataGridViewTextBoxColumn.DataPropertyName = "codigo_empleado";
            this.codigoempleadoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoempleadoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigoempleadoDataGridViewTextBoxColumn.Name = "codigoempleadoDataGridViewTextBoxColumn";
            this.codigoempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoempleadoDataGridViewTextBoxColumn.Width = 65;
            // 
            // nombreempleadoDataGridViewTextBoxColumn
            // 
            this.nombreempleadoDataGridViewTextBoxColumn.DataPropertyName = "nombre_empleado";
            this.nombreempleadoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreempleadoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreempleadoDataGridViewTextBoxColumn.Name = "nombreempleadoDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // codigotipoDataGridViewTextBoxColumn
            // 
            this.codigotipoDataGridViewTextBoxColumn.DataPropertyName = "codigo_tipo";
            this.codigotipoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.codigotipoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigotipoDataGridViewTextBoxColumn.Name = "codigotipoDataGridViewTextBoxColumn";
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.dROGUERIADataSet2;
            // 
            // dROGUERIADataSet2
            // 
            this.dROGUERIADataSet2.DataSetName = "DROGUERIADataSet2";
            this.dROGUERIADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(55, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(56, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(56, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(419, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre:";
            // 
            // txt_idEmpleado_gr
            // 
            this.txt_idEmpleado_gr.Enabled = false;
            this.txt_idEmpleado_gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idEmpleado_gr.Location = new System.Drawing.Point(60, 63);
            this.txt_idEmpleado_gr.Multiline = true;
            this.txt_idEmpleado_gr.Name = "txt_idEmpleado_gr";
            this.txt_idEmpleado_gr.Size = new System.Drawing.Size(263, 24);
            this.txt_idEmpleado_gr.TabIndex = 6;
            // 
            // txt_usuaempl_gr
            // 
            this.txt_usuaempl_gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuaempl_gr.Location = new System.Drawing.Point(61, 140);
            this.txt_usuaempl_gr.MaxLength = 35;
            this.txt_usuaempl_gr.Multiline = true;
            this.txt_usuaempl_gr.Name = "txt_usuaempl_gr";
            this.txt_usuaempl_gr.Size = new System.Drawing.Size(263, 24);
            this.txt_usuaempl_gr.TabIndex = 7;
            this.txt_usuaempl_gr.TextChanged += new System.EventHandler(this.txt_usuaempl_gr_TextChanged);
            // 
            // txt_nomempl_gr
            // 
            this.txt_nomempl_gr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nomempl_gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomempl_gr.Location = new System.Drawing.Point(424, 63);
            this.txt_nomempl_gr.MaxLength = 35;
            this.txt_nomempl_gr.Multiline = true;
            this.txt_nomempl_gr.Name = "txt_nomempl_gr";
            this.txt_nomempl_gr.Size = new System.Drawing.Size(263, 24);
            this.txt_nomempl_gr.TabIndex = 8;
            this.txt_nomempl_gr.TextChanged += new System.EventHandler(this.txt_nomempl_gr_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(253, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 49);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(399, 1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 49);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modifcar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(547, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 49);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txt_tipoempl_gr
            // 
            this.txt_tipoempl_gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoempl_gr.Location = new System.Drawing.Point(61, 223);
            this.txt_tipoempl_gr.MaxLength = 1;
            this.txt_tipoempl_gr.Multiline = true;
            this.txt_tipoempl_gr.Name = "txt_tipoempl_gr";
            this.txt_tipoempl_gr.Size = new System.Drawing.Size(263, 24);
            this.txt_tipoempl_gr.TabIndex = 9;
            this.txt_tipoempl_gr.TextChanged += new System.EventHandler(this.txt_tipoempl_gr_TextChanged);
            // 
            // txt_pas_ad
            // 
            this.txt_pas_ad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pas_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pas_ad.Location = new System.Drawing.Point(424, 140);
            this.txt_pas_ad.MaxLength = 35;
            this.txt_pas_ad.Multiline = true;
            this.txt_pas_ad.Name = "txt_pas_ad";
            this.txt_pas_ad.Size = new System.Drawing.Size(263, 24);
            this.txt_pas_ad.TabIndex = 13;
            this.txt_pas_ad.TextChanged += new System.EventHandler(this.txt_pas_ad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(419, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password:";
            // 
            // errorP_usu_ad
            // 
            this.errorP_usu_ad.ContainerControl = this;
            // 
            // errorP_nombemp_ad
            // 
            this.errorP_nombemp_ad.ContainerControl = this;
            // 
            // errorP_pas_ad
            // 
            this.errorP_pas_ad.ContainerControl = this;
            // 
            // errorP_tipempl_ad
            // 
            this.errorP_tipempl_ad.ContainerControl = this;
            // 
            // errorP_correoempl_ad
            // 
            this.errorP_correoempl_ad.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(419, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Correo:";
            // 
            // txt_correoempl_gr
            // 
            this.txt_correoempl_gr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_correoempl_gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correoempl_gr.Location = new System.Drawing.Point(424, 223);
            this.txt_correoempl_gr.MaxLength = 45;
            this.txt_correoempl_gr.Multiline = true;
            this.txt_correoempl_gr.Name = "txt_correoempl_gr";
            this.txt_correoempl_gr.Size = new System.Drawing.Size(263, 24);
            this.txt_correoempl_gr.TabIndex = 17;
            this.txt_correoempl_gr.TextChanged += new System.EventHandler(this.txt_correoempl_gr_TextChanged);
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txt_tipoempl_gr);
            this.guna2Panel1.Controls.Add(this.txt_correoempl_gr);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txt_pas_ad);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txt_idEmpleado_gr);
            this.guna2Panel1.Controls.Add(this.txt_usuaempl_gr);
            this.guna2Panel1.Controls.Add(this.txt_nomempl_gr);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(784, 273);
            this.guna2Panel1.TabIndex = 18;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnModificar);
            this.guna2Panel2.Controls.Add(this.btnAgregar);
            this.guna2Panel2.Controls.Add(this.btnEliminar);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 273);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(784, 49);
            this.guna2Panel2.TabIndex = 19;
            // 
            // Fr_Empleado_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(784, 560);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dtg_administrador_empleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 580);
            this.Name = "Fr_Empleado_Admin";
            this.Text = "Empleados_Ad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_Empleado_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_administrador_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_usu_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombemp_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_pas_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tipempl_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_correoempl_ad)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_administrador_empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idEmpleado_gr;
        private System.Windows.Forms.TextBox txt_usuaempl_gr;
        private System.Windows.Forms.TextBox txt_nomempl_gr;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txt_tipoempl_gr;
        private System.Windows.Forms.TextBox txt_pas_ad;
        private System.Windows.Forms.Label label6;
        private DROGUERIADataSet2 dROGUERIADataSet2;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DROGUERIADataSet2TableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.ErrorProvider errorP_usu_ad;
        private System.Windows.Forms.ErrorProvider errorP_nombemp_ad;
        private System.Windows.Forms.ErrorProvider errorP_pas_ad;
        private System.Windows.Forms.ErrorProvider errorP_tipempl_ad;
        private System.Windows.Forms.ErrorProvider errorP_correoempl_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigotipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_correoempl_gr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}