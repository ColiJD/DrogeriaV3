namespace Drogueria_proyecto
{
    partial class ReporteAcceso
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
            this.resporeAccesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resporeAcceso = new Drogueria_proyecto.ResporeAcceso();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.auditoriaLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditoriaLoginTableAdapter = new Drogueria_proyecto.ResporeAccesoTableAdapters.AuditoriaLoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.resporeAccesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resporeAcceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditoriaLoginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // resporeAccesoBindingSource
            // 
            this.resporeAccesoBindingSource.DataSource = this.resporeAcceso;
            this.resporeAccesoBindingSource.Position = 0;
            // 
            // resporeAcceso
            // 
            this.resporeAcceso.DataSetName = "ResporeAcceso";
            this.resporeAcceso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportedeAcceso";
            reportDataSource1.Value = this.auditoriaLoginBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Drogueria_proyecto.ReporteAcceso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // auditoriaLoginBindingSource
            // 
            this.auditoriaLoginBindingSource.DataMember = "AuditoriaLogin";
            this.auditoriaLoginBindingSource.DataSource = this.resporeAccesoBindingSource;
            // 
            // auditoriaLoginTableAdapter
            // 
            this.auditoriaLoginTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAcceso";
            this.Text = "ReporteAcceso";
            this.Load += new System.EventHandler(this.ReporteAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resporeAccesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resporeAcceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditoriaLoginBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource resporeAccesoBindingSource;
        private ResporeAcceso resporeAcceso;
        private System.Windows.Forms.BindingSource auditoriaLoginBindingSource;
        private ResporeAccesoTableAdapters.AuditoriaLoginTableAdapter auditoriaLoginTableAdapter;
    }
}