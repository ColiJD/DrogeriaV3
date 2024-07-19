using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drogueria_proyecto
{
    public partial class FormReporteFactura : Form
    {
        public FormReporteFactura()
        {
            InitializeComponent();
        }

        private void FormReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DROGUERIADataSet12.Cliente' Puede moverla o quitarla según sea necesario.
            //this.ClienteTableAdapter.Fill(this.DROGUERIADataSet12.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'DROGUERIADataSet25.FacturaEnReporte' Puede moverla o quitarla según sea necesario.
            //this.FacturaEnReporteTableAdapter.Fill(this.DROGUERIADataSet25.FacturaEnReporte);
            // TODO: esta línea de código carga datos en la tabla 'DROGUERIADataSet14.DataGridViewFactura' Puede moverla o quitarla según sea necesario.
            //this.DataGridViewFacturaTableAdapter.Fill(this.DROGUERIADataSet14.DataGridViewFactura);
            // TODO: esta línea de código carga datos en la tabla 'DROGUERIADataSet11.Factura' Puede moverla o quitarla según sea necesario.
            //this.FacturaTableAdapter.Fill(this.DROGUERIADataSet11.Factura);
            this.FacturaEnReporteTableAdapter.Fill(this.DROGUERIADataSet25.FacturaEnReporte);

            this.reportViewer1.RefreshReport();
        }
    }
}
