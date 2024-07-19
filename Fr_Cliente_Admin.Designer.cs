
namespace Drogueria_proyecto
{
    partial class Fr_Cliente_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Cliente_Admin));
            this.dtg_administrador_empleado = new System.Windows.Forms.DataGridView();
            this.codigoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet1 = new Drogueria_proyecto.DROGUERIADataSet1();
            this.dROGUERIADataSet = new Drogueria_proyecto.DROGUERIADataSet();
            this.dROGUERIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorP_nombrecl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_nombcli_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_dircl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_telcl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPro_correoCli_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.clienteTableAdapter = new Drogueria_proyecto.DROGUERIADataSet1TableAdapters.ClienteTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_idcliente_gr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombclien_gr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gr_correoclien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gr_telclien = new System.Windows.Forms.TextBox();
            this.txt_gr_dirclien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_gr_eliclien = new System.Windows.Forms.Button();
            this.btn_gr_agreclien = new System.Windows.Forms.Button();
            this.btn_gr_modclien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_administrador_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombrecl_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombcli_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_dircl_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_telcl_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro_correoCli_ad)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
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
            this.codigoclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.direccionclienteDataGridViewTextBoxColumn,
            this.correoclienteDataGridViewTextBoxColumn,
            this.telefonoclienteDataGridViewTextBoxColumn});
            this.dtg_administrador_empleado.DataSource = this.clienteBindingSource;
            this.dtg_administrador_empleado.Location = new System.Drawing.Point(0, 331);
            this.dtg_administrador_empleado.Name = "dtg_administrador_empleado";
            this.dtg_administrador_empleado.RowHeadersVisible = false;
            this.dtg_administrador_empleado.RowHeadersWidth = 51;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_administrador_empleado.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_administrador_empleado.RowTemplate.Height = 46;
            this.dtg_administrador_empleado.Size = new System.Drawing.Size(784, 229);
            this.dtg_administrador_empleado.TabIndex = 3;
            this.dtg_administrador_empleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerente_clientes_CellDoubleClick);
            // 
            // codigoclienteDataGridViewTextBoxColumn
            // 
            this.codigoclienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoclienteDataGridViewTextBoxColumn.DataPropertyName = "codigo_cliente";
            this.codigoclienteDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigoclienteDataGridViewTextBoxColumn.Name = "codigoclienteDataGridViewTextBoxColumn";
            this.codigoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoclienteDataGridViewTextBoxColumn.Width = 65;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            // 
            // direccionclienteDataGridViewTextBoxColumn
            // 
            this.direccionclienteDataGridViewTextBoxColumn.DataPropertyName = "direccion_cliente";
            this.direccionclienteDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.direccionclienteDataGridViewTextBoxColumn.Name = "direccionclienteDataGridViewTextBoxColumn";
            // 
            // correoclienteDataGridViewTextBoxColumn
            // 
            this.correoclienteDataGridViewTextBoxColumn.DataPropertyName = "correo_cliente";
            this.correoclienteDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.correoclienteDataGridViewTextBoxColumn.Name = "correoclienteDataGridViewTextBoxColumn";
            // 
            // telefonoclienteDataGridViewTextBoxColumn
            // 
            this.telefonoclienteDataGridViewTextBoxColumn.DataPropertyName = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.telefonoclienteDataGridViewTextBoxColumn.Name = "telefonoclienteDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dROGUERIADataSet1;
            // 
            // dROGUERIADataSet1
            // 
            this.dROGUERIADataSet1.DataSetName = "DROGUERIADataSet1";
            this.dROGUERIADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dROGUERIADataSet
            // 
            this.dROGUERIADataSet.DataSetName = "DROGUERIADataSet";
            this.dROGUERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dROGUERIADataSetBindingSource
            // 
            this.dROGUERIADataSetBindingSource.DataSource = this.dROGUERIADataSet;
            this.dROGUERIADataSetBindingSource.Position = 0;
            // 
            // errorP_nombrecl_ad
            // 
            this.errorP_nombrecl_ad.ContainerControl = this;
            // 
            // errorP_nombcli_ad
            // 
            this.errorP_nombcli_ad.ContainerControl = this;
            // 
            // errorP_dircl_ad
            // 
            this.errorP_dircl_ad.ContainerControl = this;
            // 
            // errorP_telcl_ad
            // 
            this.errorP_telcl_ad.ContainerControl = this;
            // 
            // errorPro_correoCli_ad
            // 
            this.errorPro_correoCli_ad.ContainerControl = this;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.txt_idcliente_gr);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.txt_nombclien_gr);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.txt_gr_correoclien);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.txt_gr_telclien);
            this.guna2Panel1.Controls.Add(this.txt_gr_dirclien);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(784, 273);
            this.guna2Panel1.TabIndex = 17;
            // 
            // txt_idcliente_gr
            // 
            this.txt_idcliente_gr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_idcliente_gr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idcliente_gr.Enabled = false;
            this.txt_idcliente_gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idcliente_gr.HideSelection = false;
            this.txt_idcliente_gr.Location = new System.Drawing.Point(103, 53);
            this.txt_idcliente_gr.Margin = new System.Windows.Forms.Padding(1);
            this.txt_idcliente_gr.Multiline = true;
            this.txt_idcliente_gr.Name = "txt_idcliente_gr";
            this.txt_idcliente_gr.Size = new System.Drawing.Size(263, 24);
            this.txt_idcliente_gr.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(400, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(98, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Código:";
            // 
            // txt_nombclien_gr
            // 
            this.txt_nombclien_gr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombclien_gr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombclien_gr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombclien_gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombclien_gr.Location = new System.Drawing.Point(405, 53);
            this.txt_nombclien_gr.Margin = new System.Windows.Forms.Padding(1);
            this.txt_nombclien_gr.MaxLength = 80;
            this.txt_nombclien_gr.Multiline = true;
            this.txt_nombclien_gr.Name = "txt_nombclien_gr";
            this.txt_nombclien_gr.Size = new System.Drawing.Size(263, 24);
            this.txt_nombclien_gr.TabIndex = 4;
            this.txt_nombclien_gr.TextChanged += new System.EventHandler(this.txt_nombclien_gr_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(400, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo:";
            // 
            // txt_gr_correoclien
            // 
            this.txt_gr_correoclien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_gr_correoclien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_gr_correoclien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gr_correoclien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gr_correoclien.Location = new System.Drawing.Point(405, 139);
            this.txt_gr_correoclien.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_correoclien.MaxLength = 60;
            this.txt_gr_correoclien.Multiline = true;
            this.txt_gr_correoclien.Name = "txt_gr_correoclien";
            this.txt_gr_correoclien.Size = new System.Drawing.Size(263, 24);
            this.txt_gr_correoclien.TabIndex = 6;
            this.txt_gr_correoclien.TextChanged += new System.EventHandler(this.txt_gr_correoclien_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(400, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dirección:";
            // 
            // txt_gr_telclien
            // 
            this.txt_gr_telclien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_gr_telclien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gr_telclien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gr_telclien.Location = new System.Drawing.Point(103, 139);
            this.txt_gr_telclien.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_telclien.MaxLength = 8;
            this.txt_gr_telclien.Multiline = true;
            this.txt_gr_telclien.Name = "txt_gr_telclien";
            this.txt_gr_telclien.Size = new System.Drawing.Size(263, 24);
            this.txt_gr_telclien.TabIndex = 10;
            this.txt_gr_telclien.TextChanged += new System.EventHandler(this.txt_gr_telclien_TextChanged_1);
            // 
            // txt_gr_dirclien
            // 
            this.txt_gr_dirclien.AllowDrop = true;
            this.txt_gr_dirclien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_gr_dirclien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_gr_dirclien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gr_dirclien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gr_dirclien.HideSelection = false;
            this.txt_gr_dirclien.Location = new System.Drawing.Point(405, 226);
            this.txt_gr_dirclien.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_dirclien.MaxLength = 60;
            this.txt_gr_dirclien.Multiline = true;
            this.txt_gr_dirclien.Name = "txt_gr_dirclien";
            this.txt_gr_dirclien.Size = new System.Drawing.Size(263, 24);
            this.txt_gr_dirclien.TabIndex = 8;
            this.txt_gr_dirclien.TextChanged += new System.EventHandler(this.txt_gr_dirclien_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(98, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teléfono:";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSize = true;
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Controls.Add(this.btn_gr_eliclien);
            this.guna2Panel3.Controls.Add(this.btn_gr_agreclien);
            this.guna2Panel3.Controls.Add(this.btn_gr_modclien);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 273);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(784, 50);
            this.guna2Panel3.TabIndex = 19;
            // 
            // btn_gr_eliclien
            // 
            this.btn_gr_eliclien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gr_eliclien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btn_gr_eliclien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gr_eliclien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_eliclien.ForeColor = System.Drawing.Color.White;
            this.btn_gr_eliclien.Location = new System.Drawing.Point(528, 0);
            this.btn_gr_eliclien.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_eliclien.Name = "btn_gr_eliclien";
            this.btn_gr_eliclien.Size = new System.Drawing.Size(140, 49);
            this.btn_gr_eliclien.TabIndex = 12;
            this.btn_gr_eliclien.Text = "Eliminar";
            this.btn_gr_eliclien.UseVisualStyleBackColor = false;
            this.btn_gr_eliclien.Click += new System.EventHandler(this.btn_gr_eliclien_Click);
            // 
            // btn_gr_agreclien
            // 
            this.btn_gr_agreclien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gr_agreclien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btn_gr_agreclien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gr_agreclien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_agreclien.ForeColor = System.Drawing.Color.White;
            this.btn_gr_agreclien.Location = new System.Drawing.Point(239, 0);
            this.btn_gr_agreclien.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_agreclien.Name = "btn_gr_agreclien";
            this.btn_gr_agreclien.Size = new System.Drawing.Size(135, 49);
            this.btn_gr_agreclien.TabIndex = 7;
            this.btn_gr_agreclien.Text = "Agregar";
            this.btn_gr_agreclien.UseVisualStyleBackColor = false;
            this.btn_gr_agreclien.Click += new System.EventHandler(this.btn_gr_agreclien_Click);
            // 
            // btn_gr_modclien
            // 
            this.btn_gr_modclien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gr_modclien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btn_gr_modclien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gr_modclien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_modclien.ForeColor = System.Drawing.Color.White;
            this.btn_gr_modclien.Location = new System.Drawing.Point(384, 0);
            this.btn_gr_modclien.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_modclien.Name = "btn_gr_modclien";
            this.btn_gr_modclien.Size = new System.Drawing.Size(135, 49);
            this.btn_gr_modclien.TabIndex = 13;
            this.btn_gr_modclien.Text = "Modificar";
            this.btn_gr_modclien.UseVisualStyleBackColor = false;
            this.btn_gr_modclien.Click += new System.EventHandler(this.btn_gr_modclien_Click);
            // 
            // Fr_Cliente_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dtg_administrador_empleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 597);
            this.Name = "Fr_Cliente_Admin";
            this.Text = "Clientes_Ad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_Cliente_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_administrador_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombrecl_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombcli_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_dircl_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_telcl_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro_correoCli_ad)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_administrador_empleado;
        private DROGUERIADataSet dROGUERIADataSet;
        private System.Windows.Forms.BindingSource dROGUERIADataSetBindingSource;
        private DROGUERIADataSet1 dROGUERIADataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DROGUERIADataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ErrorProvider errorP_nombrecl_ad;
        private System.Windows.Forms.ErrorProvider errorP_nombcli_ad;
        private System.Windows.Forms.ErrorProvider errorP_dircl_ad;
        private System.Windows.Forms.ErrorProvider errorP_telcl_ad;
        private System.Windows.Forms.ErrorProvider errorPro_correoCli_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoclienteDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TextBox txt_idcliente_gr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nombclien_gr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_gr_correoclien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_gr_telclien;
        private System.Windows.Forms.TextBox txt_gr_dirclien;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Button btn_gr_eliclien;
        private System.Windows.Forms.Button btn_gr_agreclien;
        private System.Windows.Forms.Button btn_gr_modclien;
    }
}