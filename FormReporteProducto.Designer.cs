
namespace Drogueria_proyecto
{
    partial class FormReporteProducto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteProducto));
            this.view_productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto_vendedor = new Drogueria_proyecto.producto_vendedor();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DROGUERIADataSet10 = new Drogueria_proyecto.DROGUERIADataSet10();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductoTableAdapter = new Drogueria_proyecto.DROGUERIADataSet10TableAdapters.ProductoTableAdapter();
            this.view_productoTableAdapter = new Drogueria_proyecto.producto_vendedorTableAdapters.view_productoTableAdapter();
            this.DROGUERIADataSet23 = new Drogueria_proyecto.DROGUERIADataSet23();
            ((System.ComponentModel.ISupportInitialize)(this.view_productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_vendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet23)).BeginInit();
            this.SuspendLayout();
            // 
            // view_productoBindingSource
            // 
            this.view_productoBindingSource.DataMember = "view_producto";
            this.view_productoBindingSource.DataSource = this.producto_vendedor;
            // 
            // producto_vendedor
            // 
            this.producto_vendedor.DataSetName = "producto_vendedor";
            this.producto_vendedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataMember = "Producto";
            this.ProductoBindingSource.DataSource = this.DROGUERIADataSet10;
            // 
            // DROGUERIADataSet10
            // 
            this.DROGUERIADataSet10.DataSetName = "DROGUERIADataSet10";
            this.DROGUERIADataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetProducts2";
            reportDataSource1.Value = this.view_productoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Drogueria_proyecto.ReportProducts.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, -1);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(788, 566);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProductoTableAdapter
            // 
            this.ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // view_productoTableAdapter
            // 
            this.view_productoTableAdapter.ClearBeforeFill = true;
            // 
            // DROGUERIADataSet23
            // 
            this.DROGUERIADataSet23.DataSetName = "DROGUERIADataSet23";
            this.DROGUERIADataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormReporteProducto";
            this.Text = "Reporte de Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReporteProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_vendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet23)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private DROGUERIADataSet10 DROGUERIADataSet10;
        private DROGUERIADataSet10TableAdapters.ProductoTableAdapter ProductoTableAdapter;
        private System.Windows.Forms.BindingSource view_productoBindingSource;
        private producto_vendedor producto_vendedor;
        private producto_vendedorTableAdapters.view_productoTableAdapter view_productoTableAdapter;
        private DROGUERIADataSet23 DROGUERIADataSet23;
    }
}