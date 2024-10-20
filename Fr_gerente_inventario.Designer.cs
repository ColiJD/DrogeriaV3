
namespace Drogueria_proyecto
{
    partial class Fr_gerente_inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_gerente_inventario));
            this.txt_gr_catinv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gr_nominv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gr_desinv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_codinv_gr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_exisinv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gr_provinv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_gr_modinv = new System.Windows.Forms.Button();
            this.btn_gr_elinv = new System.Windows.Forms.Button();
            this.btn_gr_agreinv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet18 = new Drogueria_proyecto.DROGUERIADataSet18();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet6 = new Drogueria_proyecto.DROGUERIADataSet6();
            this.button1 = new System.Windows.Forms.Button();
            this.productoTableAdapter = new Drogueria_proyecto.DROGUERIADataSet6TableAdapters.ProductoTableAdapter();
            this.errorP_nombpro_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_catpro_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_existpro_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_despro_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.dROGUERIADataSet = new Drogueria_proyecto.DROGUERIADataSet();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter1 = new Drogueria_proyecto.DROGUERIADataSetTableAdapters.ProductoTableAdapter();
            this.productoTableAdapter2 = new Drogueria_proyecto.DROGUERIADataSet18TableAdapters.ProductoTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_precioPro_g = new System.Windows.Forms.TextBox();
            this.errorPro_precioPro_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_preciopro_ge = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombpro_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_catpro_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_existpro_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_despro_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro_precioPro_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_preciopro_ge)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_gr_catinv
            // 
            this.txt_gr_catinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gr_catinv.Location = new System.Drawing.Point(174, 81);
            this.txt_gr_catinv.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_catinv.MaxLength = 1;
            this.txt_gr_catinv.Multiline = true;
            this.txt_gr_catinv.Name = "txt_gr_catinv";
            this.txt_gr_catinv.Size = new System.Drawing.Size(263, 24);
            this.txt_gr_catinv.TabIndex = 18;
            this.txt_gr_catinv.TextChanged += new System.EventHandler(this.txt_gr_catinv_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(41, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Categoría:";
            // 
            // txt_gr_nominv
            // 
            this.txt_gr_nominv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_gr_nominv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gr_nominv.Location = new System.Drawing.Point(621, 19);
            this.txt_gr_nominv.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_nominv.MaxLength = 80;
            this.txt_gr_nominv.Multiline = true;
            this.txt_gr_nominv.Name = "txt_gr_nominv";
            this.txt_gr_nominv.Size = new System.Drawing.Size(263, 24);
            this.txt_gr_nominv.TabIndex = 16;
            this.txt_gr_nominv.TextChanged += new System.EventHandler(this.txt_gr_nominv_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(463, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre:";
            // 
            // txt_gr_desinv
            // 
            this.txt_gr_desinv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_gr_desinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gr_desinv.Location = new System.Drawing.Point(621, 139);
            this.txt_gr_desinv.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_desinv.MaxLength = 60;
            this.txt_gr_desinv.Multiline = true;
            this.txt_gr_desinv.Name = "txt_gr_desinv";
            this.txt_gr_desinv.Size = new System.Drawing.Size(263, 24);
            this.txt_gr_desinv.TabIndex = 14;
            this.txt_gr_desinv.TextChanged += new System.EventHandler(this.txt_gr_desinv_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(463, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descripción:";
            // 
            // txt_codinv_gr
            // 
            this.txt_codinv_gr.Enabled = false;
            this.txt_codinv_gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codinv_gr.Location = new System.Drawing.Point(174, 24);
            this.txt_codinv_gr.Margin = new System.Windows.Forms.Padding(1);
            this.txt_codinv_gr.Multiline = true;
            this.txt_codinv_gr.Name = "txt_codinv_gr";
            this.txt_codinv_gr.Size = new System.Drawing.Size(263, 24);
            this.txt_codinv_gr.TabIndex = 12;
            this.txt_codinv_gr.TextChanged += new System.EventHandler(this.txt_codinv_gr_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(41, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Código:";
            // 
            // txt_exisinv
            // 
            this.txt_exisinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exisinv.Location = new System.Drawing.Point(174, 141);
            this.txt_exisinv.Margin = new System.Windows.Forms.Padding(1);
            this.txt_exisinv.Multiline = true;
            this.txt_exisinv.Name = "txt_exisinv";
            this.txt_exisinv.Size = new System.Drawing.Size(263, 24);
            this.txt_exisinv.TabIndex = 22;
            this.txt_exisinv.TextChanged += new System.EventHandler(this.txt_exisinv_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(41, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Existencia:";
            // 
            // txt_gr_provinv
            // 
            this.txt_gr_provinv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_gr_provinv.Enabled = false;
            this.txt_gr_provinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gr_provinv.Location = new System.Drawing.Point(621, 79);
            this.txt_gr_provinv.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_provinv.Multiline = true;
            this.txt_gr_provinv.Name = "txt_gr_provinv";
            this.txt_gr_provinv.Size = new System.Drawing.Size(263, 24);
            this.txt_gr_provinv.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(463, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Proveedor:";
            // 
            // btn_gr_modinv
            // 
            this.btn_gr_modinv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gr_modinv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btn_gr_modinv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gr_modinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_modinv.ForeColor = System.Drawing.Color.White;
            this.btn_gr_modinv.Location = new System.Drawing.Point(602, 4);
            this.btn_gr_modinv.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_modinv.Name = "btn_gr_modinv";
            this.btn_gr_modinv.Size = new System.Drawing.Size(135, 49);
            this.btn_gr_modinv.TabIndex = 26;
            this.btn_gr_modinv.Text = "Modificar";
            this.btn_gr_modinv.UseVisualStyleBackColor = false;
            this.btn_gr_modinv.Click += new System.EventHandler(this.btn_gr_modinv_Click);
            // 
            // btn_gr_elinv
            // 
            this.btn_gr_elinv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gr_elinv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btn_gr_elinv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gr_elinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_elinv.ForeColor = System.Drawing.Color.White;
            this.btn_gr_elinv.Location = new System.Drawing.Point(749, 4);
            this.btn_gr_elinv.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_elinv.Name = "btn_gr_elinv";
            this.btn_gr_elinv.Size = new System.Drawing.Size(135, 49);
            this.btn_gr_elinv.TabIndex = 25;
            this.btn_gr_elinv.Text = "Eliminar";
            this.btn_gr_elinv.UseVisualStyleBackColor = false;
            this.btn_gr_elinv.Click += new System.EventHandler(this.btn_gr_elinv_Click);
            // 
            // btn_gr_agreinv
            // 
            this.btn_gr_agreinv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gr_agreinv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btn_gr_agreinv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gr_agreinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_agreinv.ForeColor = System.Drawing.Color.White;
            this.btn_gr_agreinv.Location = new System.Drawing.Point(452, 4);
            this.btn_gr_agreinv.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_agreinv.Name = "btn_gr_agreinv";
            this.btn_gr_agreinv.Size = new System.Drawing.Size(135, 49);
            this.btn_gr_agreinv.TabIndex = 23;
            this.btn_gr_agreinv.Text = "Agregar";
            this.btn_gr_agreinv.UseVisualStyleBackColor = false;
            this.btn_gr_agreinv.Click += new System.EventHandler(this.btn_gr_agreinv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoproductoDataGridViewTextBoxColumn,
            this.nombreproductoDataGridViewTextBoxColumn,
            this.descripcionproductoDataGridViewTextBoxColumn,
            this.categoriaproductoDataGridViewTextBoxColumn,
            this.proveedorproductoDataGridViewTextBoxColumn,
            this.existenciaproductoDataGridViewTextBoxColumn,
            this.precioproductoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 297);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(934, 266);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // codigoproductoDataGridViewTextBoxColumn
            // 
            this.codigoproductoDataGridViewTextBoxColumn.DataPropertyName = "codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigoproductoDataGridViewTextBoxColumn.Name = "codigoproductoDataGridViewTextBoxColumn";
            this.codigoproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreproductoDataGridViewTextBoxColumn
            // 
            this.nombreproductoDataGridViewTextBoxColumn.DataPropertyName = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreproductoDataGridViewTextBoxColumn.Name = "nombreproductoDataGridViewTextBoxColumn";
            this.nombreproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionproductoDataGridViewTextBoxColumn
            // 
            this.descripcionproductoDataGridViewTextBoxColumn.DataPropertyName = "descripcion_producto";
            this.descripcionproductoDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.descripcionproductoDataGridViewTextBoxColumn.Name = "descripcionproductoDataGridViewTextBoxColumn";
            this.descripcionproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaproductoDataGridViewTextBoxColumn
            // 
            this.categoriaproductoDataGridViewTextBoxColumn.DataPropertyName = "categoria_producto";
            this.categoriaproductoDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoriaproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.categoriaproductoDataGridViewTextBoxColumn.Name = "categoriaproductoDataGridViewTextBoxColumn";
            this.categoriaproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorproductoDataGridViewTextBoxColumn
            // 
            this.proveedorproductoDataGridViewTextBoxColumn.DataPropertyName = "proveedor_producto";
            this.proveedorproductoDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.proveedorproductoDataGridViewTextBoxColumn.Name = "proveedorproductoDataGridViewTextBoxColumn";
            this.proveedorproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // existenciaproductoDataGridViewTextBoxColumn
            // 
            this.existenciaproductoDataGridViewTextBoxColumn.DataPropertyName = "existencia_producto";
            this.existenciaproductoDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.existenciaproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.existenciaproductoDataGridViewTextBoxColumn.Name = "existenciaproductoDataGridViewTextBoxColumn";
            this.existenciaproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioproductoDataGridViewTextBoxColumn
            // 
            this.precioproductoDataGridViewTextBoxColumn.DataPropertyName = "precio_producto";
            this.precioproductoDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.precioproductoDataGridViewTextBoxColumn.Name = "precioproductoDataGridViewTextBoxColumn";
            this.precioproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource2
            // 
            this.productoBindingSource2.DataMember = "Producto";
            this.productoBindingSource2.DataSource = this.dROGUERIADataSet18;
            // 
            // dROGUERIADataSet18
            // 
            this.dROGUERIADataSet18.DataSetName = "DROGUERIADataSet18";
            this.dROGUERIADataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dROGUERIADataSet6;
            // 
            // dROGUERIADataSet6
            // 
            this.dROGUERIADataSet6.DataSetName = "DROGUERIADataSet6";
            this.dROGUERIADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(238, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 49);
            this.button1.TabIndex = 28;
            this.button1.Text = "Buscar Proveedor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // errorP_nombpro_g
            // 
            this.errorP_nombpro_g.ContainerControl = this;
            // 
            // errorP_catpro_g
            // 
            this.errorP_catpro_g.ContainerControl = this;
            // 
            // errorP_existpro_g
            // 
            this.errorP_existpro_g.ContainerControl = this;
            // 
            // errorP_despro_g
            // 
            this.errorP_despro_g.ContainerControl = this;
            // 
            // dROGUERIADataSet
            // 
            this.dROGUERIADataSet.DataSetName = "DROGUERIADataSet";
            this.dROGUERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.dROGUERIADataSet;
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // productoTableAdapter2
            // 
            this.productoTableAdapter2.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(41, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "Precio:";
            // 
            // txt_precioPro_g
            // 
            this.txt_precioPro_g.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioPro_g.Location = new System.Drawing.Point(174, 199);
            this.txt_precioPro_g.Margin = new System.Windows.Forms.Padding(1);
            this.txt_precioPro_g.Multiline = true;
            this.txt_precioPro_g.Name = "txt_precioPro_g";
            this.txt_precioPro_g.Size = new System.Drawing.Size(263, 24);
            this.txt_precioPro_g.TabIndex = 30;
            this.txt_precioPro_g.TextChanged += new System.EventHandler(this.txt_precioPro_g_TextChanged);
            // 
            // errorPro_precioPro_g
            // 
            this.errorPro_precioPro_g.ContainerControl = this;
            // 
            // errorP_preciopro_ge
            // 
            this.errorP_preciopro_ge.ContainerControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txt_precioPro_g);
            this.guna2Panel1.Controls.Add(this.txt_codinv_gr);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txt_exisinv);
            this.guna2Panel1.Controls.Add(this.txt_gr_desinv);
            this.guna2Panel1.Controls.Add(this.txt_gr_catinv);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.txt_gr_provinv);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txt_gr_nominv);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(934, 236);
            this.guna2Panel1.TabIndex = 31;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.button1);
            this.guna2Panel2.Controls.Add(this.btn_gr_agreinv);
            this.guna2Panel2.Controls.Add(this.btn_gr_modinv);
            this.guna2Panel2.Controls.Add(this.btn_gr_elinv);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 236);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(934, 57);
            this.guna2Panel2.TabIndex = 32;
            // 
            // Fr_gerente_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(800, 599);
            this.Name = "Fr_gerente_inventario";
            this.Text = "Productos_G";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_gerente_inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombpro_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_catpro_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_existpro_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_despro_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro_precioPro_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_preciopro_ge)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_gr_catinv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gr_nominv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_gr_desinv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_codinv_gr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_exisinv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_gr_modinv;
        private System.Windows.Forms.Button btn_gr_elinv;
        private System.Windows.Forms.Button btn_gr_agreinv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_gr_provinv;
        private DROGUERIADataSet6 dROGUERIADataSet6;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DROGUERIADataSet6TableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.ErrorProvider errorP_nombpro_g;
        private System.Windows.Forms.ErrorProvider errorP_catpro_g;
        private System.Windows.Forms.ErrorProvider errorP_existpro_g;
        private System.Windows.Forms.ErrorProvider errorP_despro_g;
        private DROGUERIADataSet dROGUERIADataSet;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private DROGUERIADataSetTableAdapters.ProductoTableAdapter productoTableAdapter1;
        private DROGUERIADataSet18 dROGUERIADataSet18;
        private System.Windows.Forms.BindingSource productoBindingSource2;
        private DROGUERIADataSet18TableAdapters.ProductoTableAdapter productoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_precioPro_g;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorPro_precioPro_g;
        private System.Windows.Forms.ErrorProvider errorP_preciopro_ge;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}