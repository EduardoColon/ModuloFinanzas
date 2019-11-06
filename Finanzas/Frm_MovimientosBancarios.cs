using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas
{
    public partial class Frm_MovimientosBancarios : Form
    {
        public Frm_MovimientosBancarios()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        
        
        private void Frm_MovimientosBancarios_Load(object sender, EventArgs e)
        {

        }



        void deshabilitar()
        {
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            textBox1.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;

            if (comboBox1.Text == "Cheque")
            {
                //llamar consulta de cuentas bancarias con cheques disponibles
                comboBox3.Enabled = false;
                
            }

            if (comboBox1.Text == "Deposito")
            {
                //llama consultas de cuentas bancarias propias
                comboBox3.Enabled = true;
                comboBox4.Enabled = false;
            }

            if(comboBox1.Text== "Transacción a Cuentas Propias")
            {
                //llama consulta de cuentas bancarias proopias
                comboBox3.Enabled = true;
                comboBox4.Enabled = false;
            }
        }
    }
}
