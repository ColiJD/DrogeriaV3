
namespace Drogueria_proyecto
{
    partial class buscarproveedorad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarproveedorad));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet8 = new Drogueria_proyecto.DROGUERIADataSet8();
            this.proveedorTableAdapter = new Drogueria_proyecto.DROGUERIADataSet8TableAdapters.ProveedorTableAdapter();
            this.PanelTitulo = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.BtnMaximizar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet8)).BeginInit();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoproveedorDataGridViewTextBoxColumn,
            this.nombreproveedorDataGridViewTextBoxColumn,
            this.direccionproveedorDataGridViewTextBoxColumn,
            this.correoproveedorDataGridViewTextBoxColumn,
            this.telefonoproveedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(765, 487);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // codigoproveedorDataGridViewTextBoxColumn
            // 
            this.codigoproveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoproveedorDataGridViewTextBoxColumn.DataPropertyName = "codigo_proveedor";
            this.codigoproveedorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigoproveedorDataGridViewTextBoxColumn.Name = "codigoproveedorDataGridViewTextBoxColumn";
            this.codigoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoproveedorDataGridViewTextBoxColumn.Width = 65;
            // 
            // nombreproveedorDataGridViewTextBoxColumn
            // 
            this.nombreproveedorDataGridViewTextBoxColumn.DataPropertyName = "nombre_proveedor";
            this.nombreproveedorDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreproveedorDataGridViewTextBoxColumn.Name = "nombreproveedorDataGridViewTextBoxColumn";
            this.nombreproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionproveedorDataGridViewTextBoxColumn
            // 
            this.direccionproveedorDataGridViewTextBoxColumn.DataPropertyName = "direccion_proveedor";
            this.direccionproveedorDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.direccionproveedorDataGridViewTextBoxColumn.Name = "direccionproveedorDataGridViewTextBoxColumn";
            this.direccionproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoproveedorDataGridViewTextBoxColumn
            // 
            this.correoproveedorDataGridViewTextBoxColumn.DataPropertyName = "correo_proveedor";
            this.correoproveedorDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.correoproveedorDataGridViewTextBoxColumn.Name = "correoproveedorDataGridViewTextBoxColumn";
            this.correoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoproveedorDataGridViewTextBoxColumn
            // 
            this.telefonoproveedorDataGridViewTextBoxColumn.DataPropertyName = "telefono_proveedor";
            this.telefonoproveedorDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.telefonoproveedorDataGridViewTextBoxColumn.Name = "telefonoproveedorDataGridViewTextBoxColumn";
            this.telefonoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dROGUERIADataSet8;
            // 
            // dROGUERIADataSet8
            // 
            this.dROGUERIADataSet8.DataSetName = "DROGUERIADataSet8";
            this.dROGUERIADataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.PanelTitulo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.PanelTitulo.Controls.Add(this.BtnSalir);
            this.PanelTitulo.Controls.Add(this.BtnMaximizar);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(784, 60);
            this.PanelTitulo.TabIndex = 3;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
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
            this.BtnSalir.Location = new System.Drawing.Point(722, 17);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(31, 31);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.AutoSize = true;
            this.BtnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximizar.IconColor = System.Drawing.Color.White;
            this.BtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximizar.IconSize = 25;
            this.BtnMaximizar.Location = new System.Drawing.Point(685, 17);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(31, 31);
            this.BtnMaximizar.TabIndex = 3;
            this.BtnMaximizar.UseVisualStyleBackColor = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // buscarproveedorad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(115)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "buscarproveedorad";
            this.Text = "buscarproveedorAd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.buscarproveedorad_Load);
            this.Resize += new System.EventHandler(this.buscarproveedorad_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet8)).EndInit();
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DROGUERIADataSet8 dROGUERIADataSet8;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DROGUERIADataSet8TableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoproveedorDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Panel PanelTitulo;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnMaximizar;
    }
}