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
    public partial class Frm_PatidaPresupuestaria : Form
    {
        logica logic = new logica();
        int llenar;
        public Frm_PatidaPresupuestaria()
        {
            InitializeComponent();
            dataGridView1.DataSource = logic.consultaPresupuesto().Tables[0];
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string consulta = txt_buscar.Text;
            bool modificar = false;
            logica logicas = new logica();
            DataTable mostrar = logicas.datos(consulta);
           
            foreach (DataRow row in mostrar.Rows)
            {
                if (row[0] != null)
                    modificar = true;
               
            }

            txt_buscar.Clear();
            dataGridView2.DataSource = mostrar;
        }

       
        private void Frm_PatidaPresupuestaria_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string consulta = textBox1.Text;
            bool modificar = false;
            logica logicas = new logica();
            DataTable mostrar = logicas.datos1(consulta);

            foreach (DataRow row in mostrar.Rows)
            {
                if (row[0] != null)
                    modificar = true;

            }
            textBox1.Clear();
            dataGridView3.DataSource = mostrar;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txt_nombre.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txt_moneda.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txt_monto.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

                txt_id.Enabled = false;
                txt_nombre.Enabled = false;
                txt_moneda.Enabled = false;
                txt_monto.Enabled = false;
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_nombreori.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                txt_montoori.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                txt_estadoori.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
                

                txt_nombreori.Enabled = false;
                txt_montoori.Enabled = false;
                txt_estadoori.Enabled = false;
               
            }
            catch
            {

            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string movimiento1 = textBox2.Text;

            string movimiento2 = txt_nombreori.Text;

            string movimiento3 = txt_id.Text;

          

            MessageBox.Show("Presupuesto Actualizado");


        }
    }
}
