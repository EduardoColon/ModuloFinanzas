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

/*-------------------------------------------------------Allan Letona---------------------------------------------*/

namespace Finanzas
{
    public partial class frm_polizas : Form
    {
        logica logic = new logica();
        public frm_polizas()
        {
            InitializeComponent();
        }


        private void frm_polizas_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtUsuario = logic.consultaLogicaTipoPolizas();

                foreach (DataRow row in dtUsuario.Rows)
                {
                    cbo_tipoPoliza.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           



        }

        void limpiarForm()
        {
            cbo_tipoPoliza.Text = "";
            dgv_polizas.Rows.Clear();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            limpiarForm();
            string sFechaInicio = null;
            string sFechaFinal = null;
            string sTipoDePoliza = null;

            sFechaInicio = dtp_fechaInicial.Value.ToString("yyyy-MM-dd");
            sFechaFinal = dtp_fechaFinal.Value.ToString("yyyy-MM-dd");


            if (cbo_tipoPoliza.SelectedItem != null)
            {
                sTipoDePoliza = cbo_tipoPoliza.SelectedItem.ToString();

                try
                {
                    DataTable dtPoliza = logic.consultaLogicaPolizas(sFechaInicio, sFechaFinal, sTipoDePoliza);
                    foreach (DataRow dt in dtPoliza.Rows)
                    {
                        string sCodigoCuenta = dt[1].ToString();

                        string sNombreCuenta = logic.consultaLogicaNombreCuentaContable(sCodigoCuenta);

                        dgv_polizas.Rows.Add(dt[0].ToString(), sNombreCuenta, dt[2].ToString(), dt[3].ToString());
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return;
                }

            }
            else
            {
                MessageBox.Show("No ha seleccionado un tipo de poliza");
            }
        }

        private void btn_IngresoLibroDiario_Click(object sender, EventArgs e)
        {

        }

        private void cbo_tipoPoliza_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarForm();
        }
    }
}
