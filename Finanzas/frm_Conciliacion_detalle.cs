using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaFinanzas;

namespace Finanzas
{
    public partial class frm_Conciliacion_detalle : Form
    {

        logica logic = new logica();
        public frm_Conciliacion_detalle(string sBanco, string sMoneda, string sFecha, string idConciliacion)
        {
            InitializeComponent();
            LblBanco.Text = sBanco;
            LblMoneda.Text = sMoneda;
            LblMes.Text = sFecha;

            llenarDataGrid(idConciliacion);
        }

        private void llenarDataGrid(string idConciliacion)
        {
            try
            {
                DataSet ds = logic.consultaLogicaConciliacionBancariaDetalle(idConciliacion);
                DgvConciliacion.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }

        }

        private void Frm_Conciliacion_detalle_Load(object sender, EventArgs e)
        {

        }
    }
}
