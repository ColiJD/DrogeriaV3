
namespace Drogueria_proyecto
{
    partial class fr_Producto_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Producto_Admin));
            this.txt_codinv_ad = new System.Windows.Forms.TextBox();
            this.txt_exisinv_ad = new System.Windows.Forms.TextBox();
            this.txt_desinv_ad = new System.Windows.Forms.TextBox();
            this.txt_provinv_ad = new System.Windows.Forms.TextBox();
            this.txt_Nom_ad = new System.Windows.Forms.TextBox();
            this.txt_catinv_ad = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarad = new System.Windows.Forms.Button();
            this.dgv_prod_ad = new System.Windows.Forms.DataGridView();
            this.codigoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet20 = new Drogueria_proyecto.DROGUERIADataSet20();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet4 = new Drogueria_proyecto.DROGUERIADataSet4();
            this.dROGUERIADataSet = new Drogueria_proyecto.DROGUERIADataSet();
            this.dROGUERIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Drogueria_proyecto.DROGUERIADataSet4TableAdapters.ProductoTableAdapter();
            this.errorP_nombpro_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_despro_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_catpro_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_existpro_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.productoTableAdapter1 = new Drogueria_proyecto.DROGUERIADataSet20TableAdapters.ProductoTableAdapter();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombpro_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_despro_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_catpro_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_existpro_ad)).BeginInit();
            this.panel5.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_codinv_ad
            // 
            this.txt_codinv_ad.Enabled = false;
            this.txt_codinv_ad.Location = new System.Drawing.Point(86, 46);
            this.txt_codinv_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_codinv_ad.Multiline = true;
            this.txt_codinv_ad.Name = "txt_codinv_ad";
            this.txt_codinv_ad.Size = new System.Drawing.Size(263, 24);
            this.txt_codinv_ad.TabIndex = 15;
            this.txt_codinv_ad.TextChanged += new System.EventHandler(this.txt_codinv_ad_TextChanged);
            // 
            // txt_exisinv_ad
            // 
            this.txt_exisinv_ad.Location = new System.Drawing.Point(84, 192);
            this.txt_exisinv_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_exisinv_ad.Multiline = true;
            this.txt_exisinv_ad.Name = "txt_exisinv_ad";
            this.txt_exisinv_ad.Size = new System.Drawing.Size(263, 24);
            this.txt_exisinv_ad.TabIndex = 16;
            this.txt_exisinv_ad.TextChanged += new System.EventHandler(this.txt_exisinv_ad_TextChanged);
            // 
            // txt_desinv_ad
            // 
            this.txt_desinv_ad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_desinv_ad.Location = new System.Drawing.Point(434, 115);
            this.txt_desinv_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_desinv_ad.MaxLength = 60;
            this.txt_desinv_ad.Multiline = true;
            this.txt_desinv_ad.Name = "txt_desinv_ad";
            this.txt_desinv_ad.Size = new System.Drawing.Size(263, 24);
            this.txt_desinv_ad.TabIndex = 17;
            this.txt_desinv_ad.TextChanged += new System.EventHandler(this.txt_desinv_ad_TextChanged);
            // 
            // txt_provinv_ad
            // 
            this.txt_provinv_ad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_provinv_ad.Enabled = false;
            this.txt_provinv_ad.Location = new System.Drawing.Point(434, 192);
            this.txt_provinv_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_provinv_ad.Multiline = true;
            this.txt_provinv_ad.Name = "txt_provinv_ad";
            this.txt_provinv_ad.Size = new System.Drawing.Size(263, 24);
            this.txt_provinv_ad.TabIndex = 18;
            // 
            // txt_Nom_ad
            // 
            this.txt_Nom_ad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nom_ad.Location = new System.Drawing.Point(434, 46);
            this.txt_Nom_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Nom_ad.MaxLength = 80;
            this.txt_Nom_ad.Multiline = true;
            this.txt_Nom_ad.Name = "txt_Nom_ad";
            this.txt_Nom_ad.Size = new System.Drawing.Size(263, 24);
            this.txt_Nom_ad.TabIndex = 19;
            this.txt_Nom_ad.TextChanged += new System.EventHandler(this.txt_Nom_ad_TextChanged);
            // 
            // txt_catinv_ad
            // 
            this.txt_catinv_ad.Location = new System.Drawing.Point(86, 115);
            this.txt_catinv_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_catinv_ad.MaxLength = 1;
            this.txt_catinv_ad.Multiline = true;
            this.txt_catinv_ad.Name = "txt_catinv_ad";
            this.txt_catinv_ad.Size = new System.Drawing.Size(263, 24);
            this.txt_catinv_ad.TabIndex = 20;
            this.txt_catinv_ad.TextChanged += new System.EventHandler(this.txt_catinv_ad_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(429, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(429, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descripción:";
            // 
            // btnBuscarad
            // 
            this.btnBuscarad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btnBuscarad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarad.ForeColor = System.Drawing.Color.White;
            this.btnBuscarad.Location = new System.Drawing.Point(84, 0);
            this.btnBuscarad.Name = "btnBuscarad";
            this.btnBuscarad.Size = new System.Drawing.Size(135, 49);
            this.btnBuscarad.TabIndex = 28;
            this.btnBuscarad.Text = "Buscar";
            this.btnBuscarad.UseVisualStyleBackColor = false;
            this.btnBuscarad.Click += new System.EventHandler(this.btnBuscarad_Click);
            // 
            // dgv_prod_ad
            // 
            this.dgv_prod_ad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_prod_ad.AutoGenerateColumns = false;
            this.dgv_prod_ad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_prod_ad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.dgv_prod_ad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod_ad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoproductoDataGridViewTextBoxColumn,
            this.nombreproductoDataGridViewTextBoxColumn,
            this.descripcionproductoDataGridViewTextBoxColumn,
            this.categoriaproductoDataGridViewTextBoxColumn,
            this.proveedorproductoDataGridViewTextBoxColumn,
            this.existenciaproductoDataGridViewTextBoxColumn,
            this.precioproductoDataGridViewTextBoxColumn});
            this.dgv_prod_ad.DataSource = this.productoBindingSource1;
            this.dgv_prod_ad.Location = new System.Drawing.Point(0, 353);
            this.dgv_prod_ad.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_prod_ad.Name = "dgv_prod_ad";
            this.dgv_prod_ad.RowHeadersVisible = false;
            this.dgv_prod_ad.RowHeadersWidth = 123;
            this.dgv_prod_ad.RowTemplate.Height = 46;
            this.dgv_prod_ad.Size = new System.Drawing.Size(784, 207);
            this.dgv_prod_ad.TabIndex = 29;
            this.dgv_prod_ad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prod_ad_CellContentClick);
            this.dgv_prod_ad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_administrador_producto_CellDoubleClick);
            // 
            // codigoproductoDataGridViewTextBoxColumn
            // 
            this.codigoproductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoproductoDataGridViewTextBoxColumn.DataPropertyName = "codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigoproductoDataGridViewTextBoxColumn.Name = "codigoproductoDataGridViewTextBoxColumn";
            this.codigoproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoproductoDataGridViewTextBoxColumn.Width = 65;
            // 
            // nombreproductoDataGridViewTextBoxColumn
            // 
            this.nombreproductoDataGridViewTextBoxColumn.DataPropertyName = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreproductoDataGridViewTextBoxColumn.Name = "nombreproductoDataGridViewTextBoxColumn";
            // 
            // descripcionproductoDataGridViewTextBoxColumn
            // 
            this.descripcionproductoDataGridViewTextBoxColumn.DataPropertyName = "descripcion_producto";
            this.descripcionproductoDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.descripcionproductoDataGridViewTextBoxColumn.Name = "descripcionproductoDataGridViewTextBoxColumn";
            // 
            // categoriaproductoDataGridViewTextBoxColumn
            // 
            this.categoriaproductoDataGridViewTextBoxColumn.DataPropertyName = "categoria_producto";
            this.categoriaproductoDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoriaproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.categoriaproductoDataGridViewTextBoxColumn.Name = "categoriaproductoDataGridViewTextBoxColumn";
            // 
            // proveedorproductoDataGridViewTextBoxColumn
            // 
            this.proveedorproductoDataGridViewTextBoxColumn.DataPropertyName = "proveedor_producto";
            this.proveedorproductoDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.proveedorproductoDataGridViewTextBoxColumn.Name = "proveedorproductoDataGridViewTextBoxColumn";
            // 
            // existenciaproductoDataGridViewTextBoxColumn
            // 
            this.existenciaproductoDataGridViewTextBoxColumn.DataPropertyName = "existencia_producto";
            this.existenciaproductoDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.existenciaproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.existenciaproductoDataGridViewTextBoxColumn.Name = "existenciaproductoDataGridViewTextBoxColumn";
            // 
            // precioproductoDataGridViewTextBoxColumn
            // 
            this.precioproductoDataGridViewTextBoxColumn.DataPropertyName = "precio_producto";
            this.precioproductoDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.precioproductoDataGridViewTextBoxColumn.Name = "precioproductoDataGridViewTextBoxColumn";
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.dROGUERIADataSet20;
            // 
            // dROGUERIADataSet20
            // 
            this.dROGUERIADataSet20.DataSetName = "DROGUERIADataSet20";
            this.dROGUERIADataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dROGUERIADataSet4;
            // 
            // dROGUERIADataSet4
            // 
            this.dROGUERIADataSet4.DataSetName = "DROGUERIADataSet4";
            this.dROGUERIADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dROGUERIADataSetBindingSource1
            // 
            this.dROGUERIADataSetBindingSource1.DataSource = this.dROGUERIADataSet;
            this.dROGUERIADataSetBindingSource1.Position = 0;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // errorP_nombpro_ad
            // 
            this.errorP_nombpro_ad.ContainerControl = this;
            // 
            // errorP_despro_ad
            // 
            this.errorP_despro_ad.ContainerControl = this;
            // 
            // errorP_catpro_ad
            // 
            this.errorP_catpro_ad.ContainerControl = this;
            // 
            // errorP_existpro_ad
            // 
            this.errorP_existpro_ad.ContainerControl = this;
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(562, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 49);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(421, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 49);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modifcar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(280, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 49);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(81, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Código:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(81, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "Categoría:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(429, 161);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 29);
            this.label14.TabIndex = 26;
            this.label14.Text = "Proveedor:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(81, 161);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 29);
            this.label15.TabIndex = 27;
            this.label15.Text = "Existencia:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(79, 224);
            this.label16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 29);
            this.label16.TabIndex = 32;
            this.label16.Text = "Precio:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(84, 254);
            this.textBox8.Margin = new System.Windows.Forms.Padding(1);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(263, 24);
            this.textBox8.TabIndex = 33;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txt_codinv_ad);
            this.panel5.Controls.Add(this.textBox8);
            this.panel5.Controls.Add(this.txt_exisinv_ad);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.txt_desinv_ad);
            this.panel5.Controls.Add(this.txt_provinv_ad);
            this.panel5.Controls.Add(this.txt_Nom_ad);
            this.panel5.Controls.Add(this.txt_catinv_ad);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 300);
            this.panel5.TabIndex = 36;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnBuscarad);
            this.guna2Panel1.Controls.Add(this.btnAgregar);
            this.guna2Panel1.Controls.Add(this.btnModificar);
            this.guna2Panel1.Controls.Add(this.btnEliminar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 300);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(784, 49);
            this.guna2Panel1.TabIndex = 37;
            // 
            // fr_Producto_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgv_prod_ad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "fr_Producto_Admin";
            this.Text = "Producto_Ad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fr_Producto_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombpro_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_despro_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_catpro_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_existpro_ad)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_codinv_ad;
        private System.Windows.Forms.TextBox txt_exisinv_ad;
        private System.Windows.Forms.TextBox txt_desinv_ad;
        private System.Windows.Forms.TextBox txt_Nom_ad;
        private System.Windows.Forms.TextBox txt_catinv_ad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarad;
        private System.Windows.Forms.DataGridView dgv_prod_ad;
        public System.Windows.Forms.TextBox txt_provinv_ad;
        private System.Windows.Forms.BindingSource dROGUERIADataSetBindingSource1;
        private DROGUERIADataSet dROGUERIADataSet;
        private System.Windows.Forms.BindingSource dROGUERIADataSetBindingSource;
        private DROGUERIADataSet4 dROGUERIADataSet4;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DROGUERIADataSet4TableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.ErrorProvider errorP_nombpro_ad;
        private System.Windows.Forms.ErrorProvider errorP_despro_ad;
        private System.Windows.Forms.ErrorProvider errorP_catpro_ad;
        private System.Windows.Forms.ErrorProvider errorP_existpro_ad;
        private DROGUERIADataSet20 dROGUERIADataSet20;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private DROGUERIADataSet20TableAdapters.ProductoTableAdapter productoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}