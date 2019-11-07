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
    public partial class frm_envioPolizas : Form
    {
        private string sUsuario;
        List<string> lIdCuentas = new List<string>();
        logica logic = new logica();

        public frm_envioPolizas(string sUsuario)
        {
            InitializeComponent();
            this.sUsuario = sUsuario;
            llenarComboBoxCuentas();
        }


        private void llenarComboBoxCuentas()
        {
            try
            {
                DataTable dtModulos = logic.consultaLogicaCuentasEnvioPolizas();

                foreach (DataRow row in dtModulos.Rows)
                {
                    Cbo_cuentas.Items.Add(row[1].ToString());
                    lIdCuentas.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }

            if (lIdCuentas.Count > 0)
                Cbo_cuentas.SelectedIndex = 0;
        }

  
        private void Frm_envioPolizas_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if(DateTime.Compare(DtpFechaInicial.Value, DtpFechaFinal.Value) > 0)
            {
                MessageBox.Show("La fecha final no puede ser anterior a la fecha inicial.");
            }
            else
            {
                llenarDataGrid();
            }

        }

        private void llenarDataGrid()
        {
            LblTotal.Text = "";
            DgvMovimientos.DataSource = null;
            DgvMovimientos.Refresh();
          
                try
                {
                    DataSet ds = logic.consultaLogicaLibroBancosEnvioPoliza(DtpFechaInicial.Text, DtpFechaFinal.Text);
                    DgvMovimientos.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return;
                }   
        }

        private void DgvMovimientos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewCheckBoxColumn d = new DataGridViewCheckBoxColumn();
            d.Name = "Seleccionar";
            DgvMovimientos.Columns.Add(d);
        }
    }
}
