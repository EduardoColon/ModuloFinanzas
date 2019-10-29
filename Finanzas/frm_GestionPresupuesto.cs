using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDiseno;
using CapaLogicaFinanzas;

namespace Finanzas
{
    public partial class frm_GestionPresupuesto : Form
    {
        public frm_GestionPresupuesto()
        {
            InitializeComponent();
            logica logic = new logica();
            dataGridView1.DataSource = logic.consultaLogicaBitacora().Tables[0];
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_GestionPresupuesto_Load(object sender, EventArgs e)
        {
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
