
namespace Drogueria_proyecto
{
    partial class fr_Productos_vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Productos_vendedor));
            this.dgv_producto_v = new System.Windows.Forms.DataGridView();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioncategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewproductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet21 = new Drogueria_proyecto.DROGUERIADataSet21();
            this.viewproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto_vendedor = new Drogueria_proyecto.producto_vendedor();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet = new Drogueria_proyecto.DROGUERIADataSet();
            this.productoTableAdapter = new Drogueria_proyecto.DROGUERIADataSetTableAdapters.ProductoTableAdapter();
            this.view_productoTableAdapter = new Drogueria_proyecto.producto_vendedorTableAdapters.view_productoTableAdapter();
            this.view_productoTableAdapter1 = new Drogueria_proyecto.DROGUERIADataSet21TableAdapters.view_productoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_producto_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewproductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_vendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_producto_v
            // 
            this.dgv_producto_v.AllowUserToDeleteRows = false;
            this.dgv_producto_v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_producto_v.AutoGenerateColumns = false;
            this.dgv_producto_v.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_producto_v.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.dgv_producto_v.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_producto_v.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expr1DataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn,
            this.expr5DataGridViewTextBoxColumn,
            this.expr4DataGridViewTextBoxColumn,
            this.expr6DataGridViewTextBoxColumn,
            this.descripcioncategoriaDataGridViewTextBoxColumn,
            this.nombreproveedorDataGridViewTextBoxColumn,
            this.precioproductoDataGridViewTextBoxColumn,
            this.expr3DataGridViewTextBoxColumn});
            this.dgv_producto_v.DataSource = this.viewproductoBindingSource1;
            this.dgv_producto_v.Location = new System.Drawing.Point(1, 0);
            this.dgv_producto_v.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_producto_v.Name = "dgv_producto_v";
            this.dgv_producto_v.ReadOnly = true;
            this.dgv_producto_v.RowHeadersVisible = false;
            this.dgv_producto_v.RowHeadersWidth = 123;
            this.dgv_producto_v.RowTemplate.Height = 46;
            this.dgv_producto_v.Size = new System.Drawing.Size(805, 551);
            this.dgv_producto_v.TabIndex = 32;
            this.dgv_producto_v.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_producto_v_CellContentClick);
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Código";
            this.expr1DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Width = 65;
            // 
            // expr2DataGridViewTextBoxColumn
            // 
            this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
            this.expr2DataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.expr2DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
            this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr5DataGridViewTextBoxColumn
            // 
            this.expr5DataGridViewTextBoxColumn.DataPropertyName = "Expr5";
            this.expr5DataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.expr5DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr5DataGridViewTextBoxColumn.Name = "expr5DataGridViewTextBoxColumn";
            this.expr5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr4DataGridViewTextBoxColumn
            // 
            this.expr4DataGridViewTextBoxColumn.DataPropertyName = "Expr4";
            this.expr4DataGridViewTextBoxColumn.HeaderText = "Codigo Prov";
            this.expr4DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr4DataGridViewTextBoxColumn.Name = "expr4DataGridViewTextBoxColumn";
            this.expr4DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr4DataGridViewTextBoxColumn.Visible = false;
            // 
            // expr6DataGridViewTextBoxColumn
            // 
            this.expr6DataGridViewTextBoxColumn.DataPropertyName = "Expr6";
            this.expr6DataGridViewTextBoxColumn.HeaderText = "Codigo Categ";
            this.expr6DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr6DataGridViewTextBoxColumn.Name = "expr6DataGridViewTextBoxColumn";
            this.expr6DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr6DataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcioncategoriaDataGridViewTextBoxColumn
            // 
            this.descripcioncategoriaDataGridViewTextBoxColumn.DataPropertyName = "descripcion_categoria";
            this.descripcioncategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.descripcioncategoriaDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.descripcioncategoriaDataGridViewTextBoxColumn.Name = "descripcioncategoriaDataGridViewTextBoxColumn";
            this.descripcioncategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreproveedorDataGridViewTextBoxColumn
            // 
            this.nombreproveedorDataGridViewTextBoxColumn.DataPropertyName = "nombre_proveedor";
            this.nombreproveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.nombreproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreproveedorDataGridViewTextBoxColumn.Name = "nombreproveedorDataGridViewTextBoxColumn";
            this.nombreproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioproductoDataGridViewTextBoxColumn
            // 
            this.precioproductoDataGridViewTextBoxColumn.DataPropertyName = "precio_producto";
            this.precioproductoDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.precioproductoDataGridViewTextBoxColumn.Name = "precioproductoDataGridViewTextBoxColumn";
            this.precioproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr3DataGridViewTextBoxColumn
            // 
            this.expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3";
            this.expr3DataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.expr3DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr3DataGridViewTextBoxColumn.Name = "expr3DataGridViewTextBoxColumn";
            this.expr3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewproductoBindingSource1
            // 
            this.viewproductoBindingSource1.DataMember = "view_producto";
            this.viewproductoBindingSource1.DataSource = this.dROGUERIADataSet21;
            // 
            // dROGUERIADataSet21
            // 
            this.dROGUERIADataSet21.DataSetName = "DROGUERIADataSet21";
            this.dROGUERIADataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewproductoBindingSource
            // 
            this.viewproductoBindingSource.DataMember = "view_producto";
            this.viewproductoBindingSource.DataSource = this.producto_vendedor;
            // 
            // producto_vendedor
            // 
            this.producto_vendedor.DataSetName = "producto_vendedor";
            this.producto_vendedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dROGUERIADataSet;
            // 
            // dROGUERIADataSet
            // 
            this.dROGUERIADataSet.DataSetName = "DROGUERIADataSet";
            this.dROGUERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // view_productoTableAdapter
            // 
            this.view_productoTableAdapter.ClearBeforeFill = true;
            // 
            // view_productoTableAdapter1
            // 
            this.view_productoTableAdapter1.ClearBeforeFill = true;
            // 
            // fr_Productos_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(805, 561);
            this.Controls.Add(this.dgv_producto_v);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(800, 599);
            this.Name = "fr_Productos_vendedor";
            this.Text = "Productos_Vd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fr_Productos_vendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_producto_v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewproductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_vendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_producto_v;
        private DROGUERIADataSet dROGUERIADataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DROGUERIADataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private producto_vendedor producto_vendedor;
        private System.Windows.Forms.BindingSource viewproductoBindingSource;
        private producto_vendedorTableAdapters.view_productoTableAdapter view_productoTableAdapter;
        private DROGUERIADataSet21 dROGUERIADataSet21;
        private System.Windows.Forms.BindingSource viewproductoBindingSource1;
        private DROGUERIADataSet21TableAdapters.view_productoTableAdapter view_productoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioncategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
    }
}