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
    public partial class frm_ActualizacionPolizas : Form
    {
        logica logic = new logica();
        public frm_ActualizacionPolizas()
        {
            InitializeComponent();
        }

        void limpiarForm()
        {
          dgv_polizas.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarForm();

            string sFechaInicio = null;
            string sFechaFinal = null;

            sFechaInicio = dtp_fechaInicial.Value.ToString("yyyy-MM-dd");
            sFechaFinal = dtp_fechaFinal.Value.ToString("yyyy-MM-dd");


                try
                {
                    DataTable dtPoliza = logic.consultaLogicaActualizacionPolizas(sFechaInicio, sFechaFinal);


                    foreach (DataRow dt in dtPoliza.Rows)
                    {
                        string sCodigoCuenta = dt[2].ToString();

                        string sNombreCuenta = logic.consultaLogicaNombreCuentaContable(sCodigoCuenta);

                        dgv_polizas.Rows.Add(dt[0].ToString(), dt[1].ToString(), dt[2].ToString(), sNombreCuenta, dt[3].ToString(), dt[4].ToString());
            
                    }

                    if (dgv_polizas.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay polizas en ese rango de fechas");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return;
                }
        }
    }
}
