using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaDatos;
using CapaLogicaFinanzas;

namespace Finanzas
{
    public partial class frm_conciliacionBancaria : Form
    {
        sentencia s = new sentencia();
        string sUsuario;
        double dTotalDebe = 0.00, dTotalHaber = 0.00, dDiferencia = 0.00;
        List<string> lIdBanco = new List<string>();
        List<string> lIdMoneda = new List<string>();
        List<string> lIdMovimientoSeleccionado = new List<string>();
        logica logic = new logica();


        public frm_conciliacionBancaria(string sUsuario)
        {
            InitializeComponent();
            this.sUsuario = sUsuario;
            llenarComboBoxBancos();
            llenarComboBoxMonedas();


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

            if (lIdBanco.Count > 0)
                Cbo_bancos.SelectedIndex = 0;

        }

        private void llenarComboBoxMonedas()
        {

            try
            {
                DataTable dtModulos = logic.consultaLogicaMonedas();

                foreach (DataRow row in dtModulos.Rows)
                {
                    CboMonedas.Items.Add(row[1].ToString());
                    lIdMoneda.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }

            if (lIdMoneda.Count > 0)
                CboMonedas.SelectedIndex = 0;

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
                s.insertarBitacora(sUsuario, "Cargo un estado de cuenta", "tbl_conciliacion_bancaria_encabezado");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cbo_bancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDgvLibroBancos();
            limpiarDgvConciliado();

        }

        private void llenarDgvLibroBancos()
        {
            LblDiferencia.Text = "";
            DgvLibroBancos.DataSource = null;
            DgvLibroBancos.Refresh();
            int iMes = DtpPeriodo.Value.Month;
            int iAnio = DtpPeriodo.Value.Year;
            string periodo = iAnio + "-" + iMes;

            if (Cbo_bancos.Text.Trim() != "" && CboMonedas.Text.Trim() != "")
            {
                try
                {
                    DataSet ds = logic.consultaLogicaLibroBancos(lIdBanco[Cbo_bancos.SelectedIndex].ToString(), periodo, lIdMoneda[CboMonedas.SelectedIndex].ToString());
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

        private void limpiarDgvConciliado()
        {
            DgvConciliado.Rows.Clear();
            lIdMovimientoSeleccionado.Clear();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            llenarDgvLibroBancos();
            limpiarDgvConciliado();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string sMensaje = "Cerrar conciliación bancaria con los siguientes datos: " +
                "\nBanco: " + Cbo_bancos.Text +
                "\nMoneda: " + CboMonedas.Text +
                "\nPeriodo: " + DtpPeriodo.Text +
                "\nSaldo pendiente por cuadrar: " + dDiferencia;

            int iMes = DtpPeriodo.Value.Month;
            int iAnio = DtpPeriodo.Value.Year;
            string periodo = iAnio + "-" + iMes;

            DialogResult dialogResult = MessageBox.Show(sMensaje, "Conciliación bancaria", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < lIdMovimientoSeleccionado.Count; i++)
                {
                    logic.registrarMovimientoConciliado(lIdMovimientoSeleccionado[i]);
                }


                if (
                logic.registrarConciliacionBancaria(lIdBanco[Cbo_bancos.SelectedIndex],
                    lIdMoneda[CboMonedas.SelectedIndex],
                    periodo,
                    dDiferencia.ToString()
                    ))
                {
                    MessageBox.Show("La conciliación fue registrada correctamente");
                    this.Close();
                    logic.registrarConciliacionBancariaDetalle(lIdMovimientoSeleccionado);
                    s.insertarBitacora(sUsuario, "Realizo una conciliacion bancara", "tbl_conciliacion_bancaria_encabezado");
                }
            }
        }

        private void DgvLibroBancos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregarConciliado_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selRow in DgvLibroBancos.SelectedRows.OfType<DataGridViewRow>().ToArray())
            {
                lIdMovimientoSeleccionado.Add(selRow.Cells[0].Value.ToString());
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
            identificarCuentasBancoDgvConciliado();

        }

        private void BtnRegresarConciliado_Click(object sender, EventArgs e)
        {
            if (DgvConciliado.SelectedRows.OfType<DataGridViewRow>().ToArray().Length > 0)
            {
                llenarDgvLibroBancos();
                foreach (DataGridViewRow selRow in DgvConciliado.SelectedRows.OfType<DataGridViewRow>().ToArray())
                {
                    lIdMovimientoSeleccionado.Remove(selRow.Cells[0].Value.ToString());
                    DgvConciliado.Rows.Remove(selRow);
                    eliminarConciliadosDgvBancos();
                }
            }
        }

        private void eliminarConciliadosDgvBancos()
        {
            foreach (DataGridViewRow row in DgvLibroBancos.Rows)
            {
                if (lIdMovimientoSeleccionado.Exists(e => e.Equals(row.Cells[0].Value.ToString())))
                    DgvLibroBancos.Rows.Remove(row);
            }
        }

        private void identificarCuentasBancoDgvBancos()
        {
            dTotalDebe = dTotalHaber = dDiferencia = 0.00;


            foreach (DataGridViewRow row in DgvLibroBancos.Rows)
            {

                if (logic.ConsultaLogicaCuentaBanco(lIdBanco[Cbo_bancos.SelectedIndex].ToString(), row.Cells[1].Value.ToString()))
                {
                    row.Cells[1].Style.BackColor = Color.DarkGray;
                    dTotalDebe = dTotalDebe + Double.Parse(row.Cells[3].Value.ToString());
                }

                if (logic.ConsultaLogicaCuentaBanco(lIdBanco[Cbo_bancos.SelectedIndex].ToString(), row.Cells[2].Value.ToString()))
                {
                    row.Cells[2].Style.BackColor = Color.DarkGray;
                    dTotalHaber = dTotalHaber + Double.Parse(row.Cells[3].Value.ToString());

                }

            }

            dDiferencia = dTotalHaber - dTotalDebe;
            LblDebe.Text = lIdMoneda[CboMonedas.SelectedIndex] + " " + dTotalDebe.ToString();
            LblHaber.Text = lIdMoneda[CboMonedas.SelectedIndex] + " " + dTotalHaber.ToString();
            LblDiferencia.Text = lIdMoneda[CboMonedas.SelectedIndex] + " " + dDiferencia.ToString();

        }

        private void identificarCuentasBancoDgvConciliado()
        {

            foreach (DataGridViewRow row in DgvConciliado.Rows)
            {

                if (logic.ConsultaLogicaCuentaBanco(lIdBanco[Cbo_bancos.SelectedIndex].ToString(), row.Cells[1].Value.ToString()))
                {
                    row.Cells[1].Style.BackColor = Color.DarkGray;

                }

                if (logic.ConsultaLogicaCuentaBanco(lIdBanco[Cbo_bancos.SelectedIndex].ToString(), row.Cells[2].Value.ToString()))
                {
                    row.Cells[2].Style.BackColor = Color.DarkGray;

                }
            }

        }

        private void CboMonedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDgvLibroBancos();
            limpiarDgvConciliado();
        }

        private void PdfEstadoCuenta_Enter(object sender, EventArgs e)
        {

        }

        private void DgvLibroBancos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            identificarCuentasBancoDgvBancos();
        }

        private void DgvConciliado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            identificarCuentasBancoDgvConciliado();
        }
    }
}