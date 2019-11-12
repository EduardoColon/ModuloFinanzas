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
    public partial class frm_envioPolizas : Form
    {
        sentencia s = new sentencia();
        private string sUsuario;
        List<string> lIdCuentas = new List<string>();
        logica logic = new logica();
        double total = 0.0;


        public frm_envioPolizas(string sUsuario)
        {
            InitializeComponent();
            this.sUsuario = sUsuario;
            llenarComboBoxCuentas();
            int nPoliza = logic.consultarMaxPoliza();
            LbLNumeroPoliza.Text = nPoliza.ToString();
        }


        private void llenarComboBoxCuentas()
        {
            try
            {
                DataTable dtModulos = logic.consultaLogicaCuentasEnvioPolizas();

                foreach (DataRow row in dtModulos.Rows)
                {
                    lIdCuentas.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }

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
            double total = 0.00;
           foreach(DataGridViewRow row in DgvMovimientos.Rows)
            {
                total = total + double.Parse(row.Cells[3].Value.ToString());
            }
            LblTotal.Text = total.ToString();
        }

        private void DgvMovimientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DgvMovimientos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
        
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if(DgvMovimientos.Rows.Count == 0)
            {
                MessageBox.Show("No es posible crear una poliza vacia, ajuste de nuevo las fecha final y la fecha inicial");
            }
            else
            {

                if (logic.insertarPolizaEncabezado(DgvMovimientos.Rows[0].Cells[0].Value.ToString(), 
                    TxtConcepto.Text, 
                    DtpFechaPoliza.Text,
                    LblTotal.Text.ToString()))
                {
                    int numeroPoliza = logic.consultarMaxPoliza() - 1;
                    List<string> idMovimiento = new List<string>();
                    List<string> idCuentaDebe = new List<string>();
                    List<string> idCuentaHaber = new List<string>();
                    List<string> monto = new List<string>();

                    foreach (DataGridViewRow row in DgvMovimientos.Rows)
                    {
                        idMovimiento.Add(row.Cells[0].Value.ToString());
                        idCuentaDebe.Add(logic.consultarNombreCuentaContable(row.Cells[1].Value.ToString()));
                        idCuentaHaber.Add(logic.consultarNombreCuentaContable(row.Cells[2].Value.ToString()));
                        monto.Add(row.Cells[3].Value.ToString());        
                    }

                    if(logic.insertarPolizaDetalle(numeroPoliza, idCuentaDebe, idCuentaHaber, monto))
                    {
                        MessageBox.Show("La poliza fue enviada correctamente.");
                        logic.marcarMovimientoEnviadoContabilidad(idMovimiento);

                        DgvMovimientos.DataSource = null;
                        LblTotal.Text = "0.00";
                        TxtConcepto.Text = " ";
                        LbLNumeroPoliza.Text = "#";

                        s.insertarBitacora(sUsuario, "Envio una poliza a contabilidad", "tbl_poliza_encabezado");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al intentar enviar la poliza");
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar enviar la poliza");
                }
            
            }
        }
    }
}
