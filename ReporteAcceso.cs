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
    public partial class ReporteAcceso : Form
    {
        public ReporteAcceso()
        {
            InitializeComponent();
        }

        private void ReporteAcceso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'resporeAcceso.AuditoriaLogin' Puede moverla o quitarla según sea necesario.
            this.auditoriaLoginTableAdapter.Fill(this.resporeAcceso.AuditoriaLogin);

            this.reportViewer1.RefreshReport();
        }
    }
}
