using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaFinanzas;

namespace Finanzas
{
    public partial class frm_CambioMoneda : Form
    {

        List<string> lIDMoneda = new List<string>();
        List<string> lNombreMoneda = new List<string>();

        public frm_CambioMoneda()
        {
            InitializeComponent();
            llenarComboBox();
            Lbl_Resultado.Text = "         ";
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_CambioMoneda_Load(object sender, EventArgs e)
        {

        }

        private void llenarComboBox()
        {
            lIDMoneda.Clear();
            lNombreMoneda.Clear();
            Cbo_MonedaBase.Items.Clear();
            Cbo_MonedaObjetivo.Items.Clear();

            logica logic = new logica();

            lIDMoneda = logic.obtenerIdDivisa();
            lNombreMoneda = logic.obtenerNombreMoneda();

            if (lIDMoneda.Count > 0)
            {
                if (lIDMoneda.Count == lNombreMoneda.Count)
                {

                    for (int i = 0; i < lIDMoneda.Count; i++)
                    {
                        Cbo_MonedaBase.Items.Add(lIDMoneda[i] + " - " + lNombreMoneda[i]);
                        Cbo_MonedaObjetivo.Items.Add(lIDMoneda[i] + " - " + lNombreMoneda[i]);
                    }
                }

                Cbo_MonedaBase.SelectedIndex = 0;
                Cbo_MonedaObjetivo.SelectedIndex = 0;
            }
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            logica logic = new logica();

            Lbl_Resultado.Text = consultarTipoCambio(lIDMoneda[Cbo_MonedaBase.SelectedIndex],
                lIDMoneda[Cbo_MonedaObjetivo.SelectedIndex]);
        }

        public string consultarTipoCambio(string sMonedaBase, string sMonedaObjetivo)
        {
            logica logic = new logica();

            string resultado = "";

             resultado = logic.consultarTipoCambio(
                 sMonedaBase,
                sMonedaObjetivo);

            return resultado;
        }

    }
}
