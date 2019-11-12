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
    public partial class frm_BalanceGeneral : Form
    {
        logica logic = new logica();
        sentencia s = new sentencia();
        string sUsuario = "";
        public frm_BalanceGeneral(string sUsuario)
        {
            InitializeComponent();
            this.sUsuario = sUsuario;
        }

        private void btn_consultar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_balancegeneral.Rows.Clear();
            string sFechaInicial = dtp_fechaInicial.Value.ToString("yyyy-MM-dd");
            string sFechaFinal = dtp_fechaFinal.Value.ToString("yyyy-MM-dd");
            double debe;
            double haber;
            double total;
            double subTotales = 0.0;
            double totalActivo = 0.0;
            double totalPasivo = 0.0;
            double totalCapital = 0.0;
            double PasivoCapital = 0.0;
      
            try
            {
                DataTable ObtenerTiposDeCuentas = logic.consultaLogicaObtenerTipoDeCuenta();

                foreach(DataRow fila in ObtenerTiposDeCuentas.Rows)
                {
                    dgv_balancegeneral.Rows.Add(fila[0].ToString(), fila[1].ToString());

                    if (fila[0].ToString() == "1.1")
                    {
                        DataTable ConsultarBalanceGeneral = logic.consultaLogicaConsultarBalanceGeneralActivoCorriente(sFechaInicial, sFechaFinal);

                        foreach (DataRow filaAC in ConsultarBalanceGeneral.Rows)
                        {
                            debe = Convert.ToDouble(filaAC[2].ToString());
                            haber = Convert.ToDouble(filaAC[3].ToString());

                            total = debe - haber;

                            subTotales = subTotales + total;
                            

                            dgv_balancegeneral.Rows.Add(filaAC[0].ToString(), filaAC[1].ToString(), total.ToString());
                        }
                        totalActivo = totalActivo + subTotales;
                        dgv_balancegeneral.Rows.Add("","TOTAL ACTIVO CORRIENTE", subTotales.ToString(), subTotales.ToString());

                       

                        debe = 0.0;
                        haber = 0.0;
                        total = 0.0;
                        subTotales = 0.0;
                    }
                    else if (fila[0].ToString() == "1.2")
                    {
                        DataTable ConsultarBalanceGeneral = logic.consultaLogicaConsultarBalanceGeneralActivoNoCorriente(sFechaInicial, sFechaFinal);

                        foreach (DataRow filaANC in ConsultarBalanceGeneral.Rows)
                        {
                            debe = Convert.ToDouble(filaANC[2].ToString());
                            haber = Convert.ToDouble(filaANC[3].ToString());

                            total = debe - haber;
                            subTotales = subTotales + total;
                            
                            dgv_balancegeneral.Rows.Add(filaANC[0].ToString(), filaANC[1].ToString(), total.ToString());
                        }
                        totalActivo = totalActivo + subTotales;
                        dgv_balancegeneral.Rows.Add("", "TOTAL ACTIVO NO CORRIENTE", subTotales.ToString(), subTotales.ToString());
                        dgv_balancegeneral.Rows.Add("", "TOTAL ACTIVO", totalActivo.ToString(), totalActivo.ToString());

                        debe = 0.0;
                        haber = 0.0;
                        total = 0.0;
                        subTotales = 0.0;
                        //totalActivo = 0.0;

                    }
                    else if(fila[0].ToString() == "2.1")
                    {
                        DataTable ConsultarBalanceGeneral = logic.consultaLogicaConsultarBalanceGeneralPasivoCorriente(sFechaInicial, sFechaFinal);

                        foreach (DataRow filaPC in ConsultarBalanceGeneral.Rows)
                        {

                            debe = Convert.ToDouble(filaPC[2].ToString());
                            haber = Convert.ToDouble(filaPC[3].ToString());

                            if(haber>debe)
                            {
                                total = haber - debe;
                                subTotales = subTotales + total;
                            }
                            else
                            {
                                total = debe - haber;
                                subTotales = subTotales + total;
                            }
                            dgv_balancegeneral.Rows.Add(filaPC[0].ToString(), filaPC[1].ToString(), total.ToString());
                        }

                        totalPasivo = totalPasivo + subTotales;

                        dgv_balancegeneral.Rows.Add("", "TOTAL PASIVO CORRIENTE", subTotales.ToString(), subTotales.ToString());


                        debe = 0.0;
                        haber = 0.0;
                        total = 0.0;
                        subTotales = 0.0;
                    }
                    else if (fila[0].ToString() == "2.2")
                    {
                        DataTable ConsultarBalanceGeneral = logic.consultaLogicaConsultarBalanceGeneralPasivoNoCorriente(sFechaInicial, sFechaFinal);

                        foreach (DataRow filaPNC in ConsultarBalanceGeneral.Rows)
                        {

                            debe = Convert.ToDouble(filaPNC[2].ToString());
                            haber = Convert.ToDouble(filaPNC[3].ToString());

                            if (haber > debe)
                            {
                                total = haber - debe;
                                subTotales = subTotales + total;
                            }
                            else
                            {
                                total = debe - haber;
                                subTotales = subTotales + total;
                            }

                            dgv_balancegeneral.Rows.Add(filaPNC[0].ToString(), filaPNC[1].ToString(), total.ToString());
                        }
                        totalPasivo = totalPasivo + subTotales;
                        dgv_balancegeneral.Rows.Add("", "TOTAL PASIVO NO CORRIENTE", subTotales.ToString(), subTotales.ToString());
                        dgv_balancegeneral.Rows.Add("", "TOTAL PASIVO", totalPasivo.ToString(), totalPasivo.ToString());


                        debe = 0.0;
                        haber = 0.0;
                        total = 0.0;
                        subTotales = 0.0;
                    }


                    else if (fila[0].ToString() == "3.1")
                    {
                        DataTable ConsultarBalanceGeneral = logic.consultaLogicaConsultarBalanceGeneralCapital(sFechaInicial, sFechaFinal);

                        foreach (DataRow filaPNC in ConsultarBalanceGeneral.Rows)
                        {

                            debe = Convert.ToDouble(filaPNC[2].ToString());
                            haber = Convert.ToDouble(filaPNC[3].ToString());

                            if (haber > debe)
                            {
                                total = haber - debe;
                                subTotales = subTotales + total;
                            }
                            else
                            {
                                total = debe - haber;
                                subTotales = subTotales + total;
                            }

                            dgv_balancegeneral.Rows.Add(filaPNC[0].ToString(), filaPNC[1].ToString(), total.ToString());
                        }
                        totalCapital = totalCapital + subTotales;
                        dgv_balancegeneral.Rows.Add("", "TOTAL CAPITAL", subTotales.ToString(), subTotales.ToString());

                        PasivoCapital = totalPasivo + totalCapital;

                        dgv_balancegeneral.Rows.Add("", "SUMA CAPITAL + PASIVO", PasivoCapital.ToString(), PasivoCapital.ToString());


                        debe = 0.0;
                        haber = 0.0;
                        total = 0.0;
                        subTotales = 0.0;
                        totalCapital = 0.0;
                        totalPasivo = 0.0;
                        //PasivoCapital = 0.0;
                    }

                }

                s.insertarBitacora(sUsuario, "Consulto un Balance General", "tbl_balanceGeneral");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            foreach (DataGridViewRow row in dgv_balancegeneral.Rows)
            {
                
                if (Convert.ToString(row.Cells[1].Value) == "TOTAL ACTIVO CORRIENTE" || Convert.ToString(row.Cells[1].Value) ==  "TOTAL ACTIVO NO CORRIENTE" 
                    || Convert.ToString(row.Cells[1].Value) == "TOTAL PASIVO CORRIENTE" || Convert.ToString(row.Cells[1].Value) == "TOTAL PASIVO NO CORRIENTE")
                {
                    row.DefaultCellStyle.BackColor = Color.Bisque;
                }
                else if(Convert.ToString(row.Cells[1].Value) == "TOTAL ACTIVO" || Convert.ToString(row.Cells[1].Value) == "TOTAL PASIVO"
                    || Convert.ToString(row.Cells[1].Value) == "TOTAL CAPITAL")
                {

                    row.DefaultCellStyle.BackColor = Color.DarkOrange;
                }
                else if(Convert.ToString(row.Cells[1].Value) == "SUMA CAPITAL + PASIVO") 
                {
                    if(totalActivo >= PasivoCapital)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        MessageBox.Show("Balance General Cuadrado");
                       
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        MessageBox.Show("Balance General No Cuadrado");
                    }
                    totalActivo = 0.0;
                    PasivoCapital = 0.0;
                }
            }

        }
    }
}
