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
    public partial class FormReporteCliente : Form
    {
        public FormReporteCliente()
        {
            InitializeComponent();
        }

        private void FormReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DROGUERIADataSet12.Cliente' Puede moverla o quitarla según sea necesario.
            this.ClienteTableAdapter.Fill(this.DROGUERIADataSet12.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
