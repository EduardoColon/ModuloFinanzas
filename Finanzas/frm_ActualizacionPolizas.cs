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
using CapaDatos;

namespace Finanzas
{
    public partial class frm_ActualizacionPolizas : Form
    {
        logica logic = new logica();
        sentencia s = new sentencia();
        string sUsuario = "";
        public frm_ActualizacionPolizas(string sUsuario)
        {
            InitializeComponent();
            this.sUsuario = sUsuario;
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
            

            if(cbo_TipoPoliza.SelectedIndex.Equals(-1) || cbo_TipoPoliza.Text == "")
            {
                MessageBox.Show("Seleccione su tipo de poliza");
            }
            else
            {
                string sTipoPoliza = cbo_TipoPoliza.SelectedItem.ToString();
                try
                {

                    if (sTipoPoliza == "Polizas Actualizadas")
                    {
                        btn_actualizar.Enabled = false;
                        DataTable dtPoliza = logic.consultaLogicaActualizacionPolizas(sFechaInicio, sFechaFinal);


                        foreach (DataRow dt in dtPoliza.Rows)
                        {
                            string sCodigoCuenta = dt[2].ToString();

                            string sNombreCuenta = logic.consultaLogicaNombreCuentaContable(sCodigoCuenta);

                            dgv_polizas.Rows.Add(dt[0].ToString(), dt[1].ToString(), dt[2].ToString(), sNombreCuenta, dt[3].ToString(), dt[4].ToString());

                            cbo_TipoPoliza.Text = "";

                        }

                        s.insertarBitacora(sUsuario, "Consulto Las Polizas Actualizadas", "tbl_poliza_encabezado");

                        if (dgv_polizas.Rows.Count == 0)
                        {
                            MessageBox.Show("No hay polizas en ese rango de fechas");
                            cbo_TipoPoliza.Text = "";
                        }
                    }
                    else if (sTipoPoliza == "Polizas Sin Actualizar")
                    {
                        btn_actualizar.Enabled = true;
                        DataTable dtPoliza = logic.consultaLogicaPolizas(sFechaInicio, sFechaFinal);


                        foreach (DataRow dt in dtPoliza.Rows)
                        {
                            string sCodigoCuenta = dt[2].ToString();

                            string sNombreCuenta = logic.consultaLogicaNombreCuentaContable(sCodigoCuenta);

                            dgv_polizas.Rows.Add(dt[0].ToString(), dt[1].ToString(), dt[2].ToString(), sNombreCuenta, dt[3].ToString(), dt[4].ToString());

                            cbo_TipoPoliza.Text = "";

                        }

                        s.insertarBitacora(sUsuario, "Consulto Las Polizas Sin Actualizar", "tbl_poliza_encabezado");

                        if (dgv_polizas.Rows.Count == 0)
                        {
                            MessageBox.Show("No hay polizas en ese rango de fechas");
                            cbo_TipoPoliza.Text = "";
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return;
                }

                
            }
           
        }

        public static int contadorFila = 0;

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            DateTime FechaActual = DateTime.Today;
            string sFecha_actual = FechaActual.ToString("yyyy-MM-dd");
            string sCodigoPoliza = "";
            string sTotalPoliza = "";


            if(dgv_polizas.Rows.Count != 0)
            {
                foreach (DataGridViewRow Fila in dgv_polizas.Rows)
                {
                    sCodigoPoliza = Fila.Cells[0].Value.ToString();

                    if (sCodigoPoliza != txt_noPoliza.Text)
                    {
                        DataTable dtPoliza = logic.consultaLogicaObtenerTotalPoliza(Int32.Parse(sCodigoPoliza));

                        foreach (DataRow dt in dtPoliza.Rows)
                        {
                            sTotalPoliza = dt[0].ToString();
                        }

                        logic.consultaLogicaIngresarLibroDiario(Int32.Parse(sCodigoPoliza), sFecha_actual, Convert.ToDouble(sTotalPoliza), Convert.ToDouble(sTotalPoliza));
                    }
                    txt_noPoliza.Text = sCodigoPoliza;
                }

                txt_noPoliza.Text = "0";


                string sFechaInicio = null;
                string sFechaFinal = null;

                sFechaInicio = dtp_fechaInicial.Value.ToString("yyyy-MM-dd");
                sFechaFinal = dtp_fechaFinal.Value.ToString("yyyy-MM-dd");

                try
                {
                    DataTable TotalesDeCuentasContables = logic.consultaLogicaObtenerTotalesCuentasContables(sFechaInicio, sFechaFinal);

                    foreach (DataRow dt in TotalesDeCuentasContables.Rows)
                    {
                        string sCodigoCuenta = dt[0].ToString();
                        double sTotalDebe = Convert.ToDouble(dt[1].ToString());
                        double sTotalHaber = Convert.ToDouble(dt[2].ToString());

                        try
                        {
                            logic.consultaLogicaInsertarBalanceGeneral(sCodigoCuenta, sFecha_actual,sTotalDebe, sTotalHaber);
                            dgv_polizas.Rows.Clear();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }

                    }

                    MessageBox.Show("Polizas Actualizadas Correctamente");
                    s.insertarBitacora(sUsuario, "Actualizo Las Polizas", "tbl_poliza_encabezado");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado polizas para actualizar");
            }
            cbo_TipoPoliza.Text = "";

        }

        private void frm_ActualizacionPolizas_Load(object sender, EventArgs e)
        {
            cbo_TipoPoliza.Items.Add("Polizas Actualizadas");
            cbo_TipoPoliza.Items.Add("Polizas Sin Actualizar");
        }
    }
}
