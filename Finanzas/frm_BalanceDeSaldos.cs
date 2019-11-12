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
    public partial class frm_BalanceDeSaldos : Form
    {
        logica logic = new logica();
        public frm_BalanceDeSaldos()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dgv_BalanceDeSaldos.Rows.Clear();
            string sFechaInicial = dtp_fechaInicial.Value.ToString("yyyy-MM-dd");
            string sFechaFinal = dtp_fechaFinal.Value.ToString("yyyy-MM-dd");
            double debe;
            double haber;
            double total;
            double TotalGeneralDebe = 0.0;
            double TotalGeneralHaber = 0.0;

            try
            {
                DataTable BalanceDeSaldos = logic.consultaLogicaBalanceDeSaldos(sFechaInicial, sFechaFinal);

                foreach(DataRow fila in BalanceDeSaldos.Rows)
                {
                    string sCodigoCuenta = fila[0].ToString();

                    string nombreCuenta = logic.consultaLogicaNombreCuentaContable(sCodigoCuenta);

                    debe = Convert.ToDouble(fila[1].ToString());
                    haber = Convert.ToDouble(fila[2].ToString());

                    if(debe>haber)
                    {
                        total = debe - haber;
                        TotalGeneralDebe = TotalGeneralDebe + total;
                    }
                    else if(haber>debe)
                    {
                        total = haber - debe;
                        TotalGeneralHaber = TotalGeneralHaber + total;
                    }
                    else
                    {
                        total = debe - haber;
                        TotalGeneralDebe = TotalGeneralDebe + total;
                    }

                    if(debe == 0)
                    {
                        dgv_BalanceDeSaldos.Rows.Add(sCodigoCuenta, nombreCuenta, "", haber);
                    }
                    else if(haber == 0)
                    {
                        dgv_BalanceDeSaldos.Rows.Add(sCodigoCuenta, nombreCuenta, debe, "");
                    }

                }
                dgv_BalanceDeSaldos.Rows.Add("", "TOTALES", TotalGeneralDebe, TotalGeneralHaber);
                foreach (DataGridViewRow row in dgv_BalanceDeSaldos.Rows)
                {
                    
                    if (Convert.ToString(row.Cells[1].Value) == "TOTALES")
                    {
                        double totalDebe = Convert.ToDouble(row.Cells[2].Value.ToString());
                        double totalHaber = Convert.ToDouble(row.Cells[3].Value.ToString());

                        if(totalDebe==totalHaber)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            MessageBox.Show("Saldos Balanceados");
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                            MessageBox.Show("Saldos No Balanceados");
                        }
                        
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
