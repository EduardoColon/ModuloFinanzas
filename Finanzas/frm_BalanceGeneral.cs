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
    public partial class frm_BalanceGeneral : Form
    {
        logica logic = new logica();
        public frm_BalanceGeneral()
        {
            InitializeComponent();
        }

        private void btn_consultar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable ObtenerTiposDeCuentas = logic.consultaLogicaObtenerTipoDeCuenta();

                foreach(DataRow fila in ObtenerTiposDeCuentas.Rows)
                {
                    dgv_balancegeneral.Rows.Add(fila[0].ToString(), fila[1].ToString());

                    if (fila[0].ToString() == "1.1")
                    {
                        dgv_balancegeneral.Rows.Add("1.1.1", "Caja","1000");
                        dgv_balancegeneral.Rows.Add("1.1.2", "Bancos", "22000");
                    }
                    else if (fila[0].ToString() == "1.2")
                    {
                        dgv_balancegeneral.Rows.Add("1.2.1", "Vehiculos", "15000");
                    }
                    else if(fila[0].ToString() == "2.1")
                    {
                        dgv_balancegeneral.Rows.Add("2.1.1", "Proveedores", "500");
                    }
                    else if (fila[0].ToString() == "2.2")
                    {
                        dgv_balancegeneral.Rows.Add("2.2.1", "Hipoteca", "50000");
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
