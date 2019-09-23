using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapacitacionReportes
{
    public partial class frm_ReporteClientes : Form
    {
        public frm_ReporteClientes()
        {
            InitializeComponent();                        
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void Frm_ReporteClientes_Load(object sender, EventArgs e)
        {
            reporteClientes repC = new reporteClientes();
            crystalReportViewer1.ReportSource = repC;
        }

        private void Frm_ReporteClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Inicio ini = new frm_Inicio();
            ini.Show();
        }
    }
}
