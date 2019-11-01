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
    public partial class frm_conciliacionBancaria : Form
    {
        string sUsuario;
        List<string> lIdBanco = new List<string>();
        logica logic = new logica();


        public frm_conciliacionBancaria(string sUsuario)
        {
            InitializeComponent();
            this.sUsuario = sUsuario;
            llenarComboBoxBancos();

            DgvConciliado.Columns.Add("KidMovimientoBancario", "KidMovimientoBancario");
            DgvConciliado.Columns.Add("cuenta_debito", "cuenta_debito");
            DgvConciliado.Columns.Add("cuenta_credito", "cuenta_credito");
            DgvConciliado.Columns.Add("monto", "monto");
            DgvConciliado.Columns.Add("tipo_movimiento", "tipo_movimiento");
            DgvConciliado.Columns.Add("fecha_movimiento", "fecha_movimiento");

        }

        private void llenarComboBoxBancos()
        {

            try
            {
                DataTable dtModulos = logic.consultaLogicaBancos();

                foreach (DataRow row in dtModulos.Rows)
                {
                    Cbo_bancos.Items.Add(row[1].ToString());
                    lIdBanco.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }

            if(lIdBanco.Count > 0)
               Cbo_bancos.SelectedIndex = 0;
            
        }

        private void Frm_conciliacionBancaria_Load(object sender, EventArgs e)
        {

        }

        private void Btn_EstadoCuenta_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Abrir estado de cuenta";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Pdf Files|*.pdf";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                pdfEstadoCuenta.src = fdlg.FileName;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cbo_bancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDgvLibroBancos();
        }

        private void llenarDgvLibroBancos()
        {
            int iMes = DtpPeriodo.Value.Month;
            int iAnio = DtpPeriodo.Value.Year;
            string periodo = iAnio + "-" + iMes;

            if(1 == 1)
            {
                try
                {                   
                    DataSet ds = logic.consultaLogicaLibroBancos(lIdBanco[Cbo_bancos.SelectedIndex].ToString(), periodo);
                    DgvLibroBancos.DataSource = ds.Tables[0];
                    DgvConciliado.DataSource = null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return;
                }

            }
        }


        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            llenarDgvLibroBancos();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            llenarDgvLibroBancos();
        }

        private void DgvLibroBancos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach ( DataGridViewRow selRow in DgvLibroBancos.SelectedRows.OfType<DataGridViewRow>().ToArray())
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(DgvConciliado);
                fila.Cells[0].Value = selRow.Cells[0].Value;
                fila.Cells[1].Value = selRow.Cells[1].Value;
                fila.Cells[2].Value = selRow.Cells[2].Value;
                fila.Cells[3].Value = selRow.Cells[3].Value;
                fila.Cells[4].Value = selRow.Cells[4].Value;
                fila.Cells[5].Value = selRow.Cells[5].Value;


                DgvLibroBancos.Rows.Remove(selRow);


                DgvConciliado.Rows.Add(fila);
            }
        }

    }
}
