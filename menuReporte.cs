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
    public partial class menuReporte : Form
    {
        public menuReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReporteProducto formReporteProducto = new FormReporteProducto();
            formReporteProducto.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReporteFactura formReporteFactura = new FormReporteFactura();
            formReporteFactura.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormReporteCliente formReporteCliente = new FormReporteCliente();
            formReporteCliente.Show();
        }

        private void btn_regresar_mr_Click(object sender, EventArgs e)
        {
            this.Close();
            fr_menu_gerente fr_Menu_Gerente = new fr_menu_gerente();
            fr_Menu_Gerente.Show();
        }
    }
}
