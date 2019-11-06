using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDiseno;
using CapaLogicaFinanzas;

namespace Finanzas
{
    public partial class Frm_GestionPresupuesto : Form
    {

        logica logic = new logica();
        public Frm_GestionPresupuesto()
        {
            InitializeComponent();
            logica logic = new logica();
            dataGridView1.DataSource = logic.consultaLogicapresupuesto().Tables[0];
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string consulta = txt_buscar.Text;
            bool modificar = false;
            try
            {
               
                DataTable mostrar = logic.ConsultaLogicaPerfil(consulta);

                foreach (DataRow row in mostrar.Rows)
                {
                    if (row[0] != null)
                        modificar = true;

                    txt_id.Text = (row[0].ToString());
                    txt_nombre.Text = (row[4].ToString());
                    txt_monto.Text = (row[7].ToString());
                    txt_moneda.Text = (row[11].ToString());
                    txt_area.Text = (row[15].ToString());
                    txt_des.Text = (row[6].ToString());

                }

                if (modificar == true)
                {


                    txt_id.Enabled = false;
                    txt_nombre.Enabled = false;
                    txt_monto.Enabled = false;
                    txt_moneda.Enabled = false;
                    txt_area.Enabled = false;
                    txt_des.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontró el Presupuesto Buscado");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
