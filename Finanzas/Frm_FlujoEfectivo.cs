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


//----------------------------------------------------------------------Diego Gomez
namespace Finanzas
{
    public partial class Frm_FlujoEfectivo : Form
    {
        logica logic = new logica();

        public Frm_FlujoEfectivo()
        {
            InitializeComponent();
            Ingresos.DataSource = logic.consultaIngresos().Tables[0];
            Egresos.DataSource = logic.consultaEgresos().Tables[0];
            Total_Ingresos.DataSource = logic.TotalIngresos().Tables[0];
            Total_Egresos.DataSource = logic.TotalEgresos().Tables[0];

            Saldo.DataSource = logic.Saldo().Tables[0];

            string prueba;

            prueba = Saldo.Rows[0].Cells[2].Value.ToString();
            Saldo.AllowUserToAddRows = false;
            Ingresos.AllowUserToAddRows = false;
            Egresos.AllowUserToAddRows = false;
            Total_Egresos.AllowUserToAddRows = false;
            Total_Ingresos.AllowUserToAddRows = false;

            Saldo.ClearSelection();

            this.Saldo.Columns["Saldo_Ingresos"].Visible = false;
            this.Saldo.Columns["Saldo_Egresos"].Visible = false;

            if (Int32.Parse(prueba) > 0)
            {
                Saldo.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                Saldo.EnableHeadersVisualStyles = false;
                Saldo.Columns[2].DefaultCellStyle.ForeColor = Color.Green;
            }
            else
            {
                Saldo.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                Saldo.EnableHeadersVisualStyles = false;
                Saldo.Columns[2].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_FlujoEfectivo_Load(object sender, EventArgs e)
        {
            Saldo.ClearSelection();
            Total_Egresos.ClearSelection();
            Total_Ingresos.ClearSelection();
            Ingresos.ClearSelection();
            Egresos.ClearSelection();
        }
    }
}
