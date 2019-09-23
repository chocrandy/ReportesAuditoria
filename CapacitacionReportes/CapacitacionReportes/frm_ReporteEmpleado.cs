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
    public partial class frm_ReporteEmpleado : Form
    {
        public frm_ReporteEmpleado()
        {
            InitializeComponent();
        }

        private void Frm_ReporteEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Inicio ini = new frm_Inicio();
            ini.Show();
        }
    }
}
