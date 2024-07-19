
namespace Drogueria_proyecto
{
    partial class FormReporteFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteFactura));
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DROGUERIADataSet12 = new Drogueria_proyecto.DROGUERIADataSet12();
            this.DataGridViewFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DROGUERIADataSet14 = new Drogueria_proyecto.DROGUERIADataSet14();
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DROGUERIADataSet11 = new Drogueria_proyecto.DROGUERIADataSet11();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaTableAdapter = new Drogueria_proyecto.DROGUERIADataSet11TableAdapters.FacturaTableAdapter();
            this.DataGridViewFacturaTableAdapter = new Drogueria_proyecto.DROGUERIADataSet14TableAdapters.DataGridViewFacturaTableAdapter();
            this.DROGUERIADataSet17 = new Drogueria_proyecto.DROGUERIADataSet17();
            this.DROGUERIADataSet24 = new Drogueria_proyecto.DROGUERIADataSet24();
            this.DROGUERIADataSet25 = new Drogueria_proyecto.DROGUERIADataSet25();
            this.FacturaEnReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaEnReporteTableAdapter = new Drogueria_proyecto.DROGUERIADataSet25TableAdapters.FacturaEnReporteTableAdapter();
            this.ClienteTableAdapter = new Drogueria_proyecto.DROGUERIADataSet12TableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaEnReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.DROGUERIADataSet12;
            // 
            // DROGUERIADataSet12
            // 
            this.DROGUERIADataSet12.DataSetName = "DROGUERIADataSet12";
            this.DROGUERIADataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataGridViewFacturaBindingSource
            // 
            this.DataGridViewFacturaBindingSource.DataMember = "DataGridViewFactura";
            this.DataGridViewFacturaBindingSource.DataSource = this.DROGUERIADataSet14;
            // 
            // DROGUERIADataSet14
            // 
            this.DROGUERIADataSet14.DataSetName = "DROGUERIADataSet14";
            this.DROGUERIADataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataMember = "Factura";
            this.FacturaBindingSource.DataSource = this.DROGUERIADataSet11;
            // 
            // DROGUERIADataSet11
            // 
            this.DROGUERIADataSet11.DataSetName = "DROGUERIADataSet11";
            this.DROGUERIADataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetCliente";
            reportDataSource1.Value = this.ClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Drogueria_proyecto.ReporteCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 564);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturaTableAdapter
            // 
            this.FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridViewFacturaTableAdapter
            // 
            this.DataGridViewFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // DROGUERIADataSet17
            // 
            this.DROGUERIADataSet17.DataSetName = "DROGUERIADataSet17";
            this.DROGUERIADataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DROGUERIADataSet24
            // 
            this.DROGUERIADataSet24.DataSetName = "DROGUERIADataSet24";
            this.DROGUERIADataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DROGUERIADataSet25
            // 
            this.DROGUERIADataSet25.DataSetName = "DROGUERIADataSet25";
            this.DROGUERIADataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturaEnReporteBindingSource
            // 
            this.FacturaEnReporteBindingSource.DataMember = "FacturaEnReporte";
            this.FacturaEnReporteBindingSource.DataSource = this.DROGUERIADataSet25;
            // 
            // FacturaEnReporteTableAdapter
            // 
            this.FacturaEnReporteTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteTableAdapter
            // 
            this.ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormReporteFactura";
            this.Text = "Reporte de Facturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DROGUERIADataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaEnReporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
        private DROGUERIADataSet11 DROGUERIADataSet11;
        private DROGUERIADataSet11TableAdapters.FacturaTableAdapter FacturaTableAdapter;
        private System.Windows.Forms.BindingSource DataGridViewFacturaBindingSource;
        private DROGUERIADataSet14 DROGUERIADataSet14;
        private DROGUERIADataSet14TableAdapters.DataGridViewFacturaTableAdapter DataGridViewFacturaTableAdapter;
        private DROGUERIADataSet17 DROGUERIADataSet17;
        private DROGUERIADataSet24 DROGUERIADataSet24;
        private System.Windows.Forms.BindingSource FacturaEnReporteBindingSource;
        private DROGUERIADataSet25 DROGUERIADataSet25;
        private DROGUERIADataSet25TableAdapters.FacturaEnReporteTableAdapter FacturaEnReporteTableAdapter;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private DROGUERIADataSet12 DROGUERIADataSet12;
        private DROGUERIADataSet12TableAdapters.ClienteTableAdapter ClienteTableAdapter;
    }
}