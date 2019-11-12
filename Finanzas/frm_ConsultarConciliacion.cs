using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaLogicaFinanzas;

namespace Finanzas
{
    public partial class frm_ConsultarConciliacion : Form
    {

        List<string> lIdBanco = new List<string>();
        List<string> lIdMoneda = new List<string>();
        logica logic = new logica();
        string sFecha = "", sBanco = "", sMoneda = "";
        string sUsuario;

        public frm_ConsultarConciliacion(string sUsuario)
        {
            InitializeComponent();
            llenarComboBoxBancos();
            llenarComboBoxMonedas();
            this.sUsuario = sUsuario;
        }

        private void Frm_ConsultarConciliacion_Load(object sender, EventArgs e)
        {

        }


        private void llenarComboBoxBancos()
        {

            try
            {
                DataTable dtModulos = logic.consultaLogicaBancos();

                foreach (DataRow row in dtModulos.Rows)
                {
                    Cbo_bancos.Items.Add(row[1].ToString());
                    lIdBanco.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }

            if (lIdBanco.Count > 0)
                Cbo_bancos.SelectedIndex = 0;

        }

        private void llenarComboBoxMonedas()
        {

            try
            {
                DataTable dtModulos = logic.consultaLogicaMonedas();

                foreach (DataRow row in dtModulos.Rows)
                {
                    CboMonedas.Items.Add(row[1].ToString());
                    lIdMoneda.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }

            if (lIdMoneda.Count > 0)
                CboMonedas.SelectedIndex = 0;

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (lIdBanco.Count > 0 && lIdMoneda.Count > 0)
            {
                llenarDgvConciliacion();
            }

        }

        private void llenarDgvConciliacion()
        {
            DgvConciliacion.DataSource = null;
            DgvConciliacion.Refresh();
            int iMes = DtpPeriodo.Value.Month;
            int iAnio = DtpPeriodo.Value.Year;
            string periodo = iAnio + "-" + iMes;

           

            if (Cbo_bancos.Text.Trim() != "" && CboMonedas.Text.Trim() != "")
            {
                try
                {
                    DataSet ds = logic.consultaLogicaConciliacionBancaria(lIdBanco[Cbo_bancos.SelectedIndex].ToString(), periodo, lIdMoneda[CboMonedas.SelectedIndex].ToString());
                    DgvConciliacion.DataSource = ds.Tables[0];

                    sFecha = periodo;
                    sMoneda = CboMonedas.Text;
                    sBanco = Cbo_bancos.Text;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return;
                }

            }
        }

        private void DgvConciliacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_Conciliacion_detalle frm_Conciliacion = new frm_Conciliacion_detalle(sBanco, sMoneda, sFecha, DgvConciliacion.CurrentRow.Cells[0].Value.ToString(), sUsuario);

                frm_Conciliacion.Show();
                sentencia s = new sentencia();
                s.insertarBitacora(sUsuario, "Consulto una conciliacion bancaria", "tbl_conciliacion_bancaria_detalle");
            }
    
        }
    }
}
