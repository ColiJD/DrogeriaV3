﻿
namespace Drogueria_proyecto
{
    partial class Fr_gerente_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_gerente_cliente));
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet5 = new Drogueria_proyecto.DROGUERIADataSet5();
            this.btn_gr_agreclien = new System.Windows.Forms.Button();
            this.btn_gr_eliclien = new System.Windows.Forms.Button();
            this.btn_gr_modclien = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new Drogueria_proyecto.DROGUERIADataSet5TableAdapters.ClienteTableAdapter();
            this.errorP_dirc_cl_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_tel_cl_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_nombcl_gr = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPro_correocli_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_gerente_clientes = new System.Windows.Forms.DataGridView();
            this.codigoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gr_dirclien = new System.Windows.Forms.TextBox();
            this.txt_gr_telclien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gr_correoclien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombclien_gr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idcliente_gr = new System.Windows.Forms.TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_dirc_cl_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tel_cl_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombcl_gr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro_correocli_g)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gerente_clientes)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dROGUERIADataSet5;
            // 
            // dROGUERIADataSet5
            // 
            this.dROGUERIADataSet5.DataSetName = "DROGUERIADataSet5";
            this.dROGUERIADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btn_gr_agreclien.Click += new System.EventHandler(this.btn_gr_agreclien_Click_1);
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
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // errorP_dirc_cl_g
            // 
            this.errorP_dirc_cl_g.ContainerControl = this;
            // 
            // errorP_tel_cl_g
            // 
            this.errorP_tel_cl_g.ContainerControl = this;
            // 
            // errorP_nombcl_gr
            // 
            this.errorP_nombcl_gr.ContainerControl = this;
            // 
            // errorPro_correocli_g
            // 
            this.errorPro_correocli_g.ContainerControl = this;
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
            this.guna2Panel3.TabIndex = 18;
            // 
            // dgv_gerente_clientes
            // 
            this.dgv_gerente_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_gerente_clientes.AutoGenerateColumns = false;
            this.dgv_gerente_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_gerente_clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.dgv_gerente_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gerente_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.direccionclienteDataGridViewTextBoxColumn,
            this.correoclienteDataGridViewTextBoxColumn,
            this.telefonoclienteDataGridViewTextBoxColumn});
            this.dgv_gerente_clientes.DataSource = this.clienteBindingSource;
            this.dgv_gerente_clientes.Location = new System.Drawing.Point(0, 329);
            this.dgv_gerente_clientes.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_gerente_clientes.Name = "dgv_gerente_clientes";
            this.dgv_gerente_clientes.ReadOnly = true;
            this.dgv_gerente_clientes.RowHeadersVisible = false;
            this.dgv_gerente_clientes.RowHeadersWidth = 123;
            this.dgv_gerente_clientes.RowTemplate.Height = 46;
            this.dgv_gerente_clientes.Size = new System.Drawing.Size(784, 234);
            this.dgv_gerente_clientes.TabIndex = 3;
            this.dgv_gerente_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerente_clientes_CellContentClick);
            this.dgv_gerente_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerente_clientes_CellDoubleClick);
            // 
            // codigoclienteDataGridViewTextBoxColumn
            // 
            this.codigoclienteDataGridViewTextBoxColumn.DataPropertyName = "codigo_cliente";
            this.codigoclienteDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoclienteDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.codigoclienteDataGridViewTextBoxColumn.Name = "codigoclienteDataGridViewTextBoxColumn";
            this.codigoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.FillWeight = 300F;
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionclienteDataGridViewTextBoxColumn
            // 
            this.direccionclienteDataGridViewTextBoxColumn.DataPropertyName = "direccion_cliente";
            this.direccionclienteDataGridViewTextBoxColumn.FillWeight = 200F;
            this.direccionclienteDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.direccionclienteDataGridViewTextBoxColumn.Name = "direccionclienteDataGridViewTextBoxColumn";
            this.direccionclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoclienteDataGridViewTextBoxColumn
            // 
            this.correoclienteDataGridViewTextBoxColumn.DataPropertyName = "correo_cliente";
            this.correoclienteDataGridViewTextBoxColumn.FillWeight = 200F;
            this.correoclienteDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.correoclienteDataGridViewTextBoxColumn.Name = "correoclienteDataGridViewTextBoxColumn";
            this.correoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoclienteDataGridViewTextBoxColumn
            // 
            this.telefonoclienteDataGridViewTextBoxColumn.DataPropertyName = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.FillWeight = 200F;
            this.telefonoclienteDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoclienteDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.telefonoclienteDataGridViewTextBoxColumn.Name = "telefonoclienteDataGridViewTextBoxColumn";
            this.telefonoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoSize = true;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 273);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(784, 0);
            this.guna2Panel2.TabIndex = 17;
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
            this.txt_gr_dirclien.TextChanged += new System.EventHandler(this.txt_gr_dirclien_TextChanged);
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
            this.txt_gr_telclien.TextChanged += new System.EventHandler(this.txt_gr_telclien_TextChanged);
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
            this.txt_gr_correoclien.TextChanged += new System.EventHandler(this.txt_gr_correoclien_TextChanged);
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
            this.txt_nombclien_gr.TextChanged += new System.EventHandler(this.txt_nombclien_gr_TextChanged);
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
            this.guna2Panel1.TabIndex = 16;
            // 
            // Fr_gerente_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgv_gerente_clientes);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(800, 597);
            this.Name = "Fr_gerente_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes_G";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_gerente_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_dirc_cl_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tel_cl_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombcl_gr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro_correocli_g)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gerente_clientes)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gr_agreclien;
        private System.Windows.Forms.Button btn_gr_eliclien;
        private System.Windows.Forms.Button btn_gr_modclien;
        private DROGUERIADataSet5 dROGUERIADataSet5;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DROGUERIADataSet5TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ErrorProvider errorP_dirc_cl_g;
        private System.Windows.Forms.ErrorProvider errorP_tel_cl_g;
        private System.Windows.Forms.ErrorProvider errorP_nombcl_gr;
        private System.Windows.Forms.ErrorProvider errorPro_correocli_g;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView dgv_gerente_clientes;
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
    }
}