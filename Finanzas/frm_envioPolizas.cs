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
        private bool columnaAgregada = false;
        private string sUsuario;
        List<string> lIdCuentas = new List<string>();
        logica logic = new logica();
        DataGridViewCheckBoxColumn d = new DataGridViewCheckBoxColumn();
        double total = 0.0;


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
            if (!columnaAgregada)
            {
                d.Name = "Seleccionar";
                DgvMovimientos.Columns.Add(d);
                columnaAgregada = true;
            }
         
        }

        private void DgvMovimientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DgvMovimientos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == d.Index && e.RowIndex != -1)
            {
                calcularTotal();
            }
        }

        private void calcularTotal()
        {
            total = 0.00;
            foreach(DataGridViewRow row in DgvMovimientos.Rows)
            {
                if (row["s"] == true)
                {
                    total = total + double.Parse(row.Cells[3].Value.ToString());
                }
            }
            LblTotal.Text = total.ToString();
        }
    }
}
