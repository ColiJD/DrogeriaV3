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
    public partial class FormReporteProducto : Form
    {
        public FormReporteProducto()
        {
            InitializeComponent();
        }

        private void FormReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'producto_vendedor.view_producto' Puede moverla o quitarla según sea necesario.
           // this.view_productoTableAdapter.Fill(this.producto_vendedor.view_producto);
            // TODO: esta línea de código carga datos en la tabla 'DROGUERIADataSet10.Producto' Puede moverla o quitarla según sea necesario.
            this.ProductoTableAdapter.Fill(this.DROGUERIADataSet10.Producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
