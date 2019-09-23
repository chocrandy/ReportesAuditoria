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
    public partial class frm_Inicio : Form
    {
        public frm_Inicio()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_ReporteClientes repC = new frm_ReporteClientes();
            repC.ShowDialog();                        
        }

        private void Frm_Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
