using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaFinanzas;

namespace Finanzas
{
    public partial class MDI_Finanzas : Form
    {
        logica logic = new logica();
        string sUsuario = "miusuario";
        private int childFormNumber = 0;

        public MDI_Finanzas()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tipoDeCuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ConciliacionesBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_conciliacionBancaria conciliacionBancaria = new frm_conciliacionBancaria(sUsuario);
            conciliacionBancaria.MdiParent = this;
            conciliacionBancaria.Show();
        }

        private void MDI_Finanzas_Load(object sender, EventArgs e)
        {

        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tipoDePolizaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void libroDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void TipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MovimientosDeBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CreacionPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void GestionPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void chequerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bancosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void cuentasContablesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_cuentasContables cuentas_contables = new frm_cuentasContables(sUsuario);
            cuentas_contables.MdiParent = this;
            cuentas_contables.Show();
        }

        private void tiposDeCuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tipoCuentaContable tipocuenta = new frm_tipoCuentaContable(sUsuario);
            tipocuenta.MdiParent = this;
            tipocuenta.Show();
        }

        private void tiposDePolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tipoPoliza tipoPoliza = new frm_tipoPoliza(sUsuario);
            tipoPoliza.MdiParent = this;
            tipoPoliza.Show();
        }

        private void creacionPresupuestoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_CreacionPresupuesto presupuesto = new Frm_CreacionPresupuesto(sUsuario);
            presupuesto.MdiParent = this;
            presupuesto.Show();
        }

        private void cuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ctsbancarias ctsbancarias = new frm_ctsbancarias(sUsuario);
            ctsbancarias.MdiParent = this;
            ctsbancarias.Show();
        }

        private void chequeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manchequera chequeras = new frm_manchequera(sUsuario);
            chequeras.MdiParent = this;
            chequeras.Show();
        }

        private void bancosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_manbancos bancos = new frm_manbancos(sUsuario);
            bancos.MdiParent = this;
            bancos.Show();
        }

        private void polizasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_polizas polizas = new frm_polizas();
            polizas.MdiParent = this;
            polizas.Show();
        }

        private void libroDiarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_libroDiario libroDiario = new frm_libroDiario();
            libroDiario.MdiParent = this;
            libroDiario.Show();
        }

        private void gestionDePresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GestionPresupuesto presupuesto1 = new Frm_GestionPresupuesto();
            presupuesto1.MdiParent = this;
            presupuesto1.Show();
        }

        private void movimientosDeBancosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_MovimientosBancarios movimientosbancarios = new Frm_MovimientosBancarios();
            movimientosbancarios.MdiParent = this;
            movimientosbancarios.Show();
        }

        private void tipoDeCambioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_CambioMoneda cambioMoneda = new frm_CambioMoneda();
            cambioMoneda.MdiParent = this;
            cambioMoneda.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreacionPresupuestoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Ayudas/CreacionPresupuesto.chm");
        }

        private void ConciliacionBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_conciliacionBancaria frm_Conciliacion = new frm_conciliacionBancaria(sUsuario);
            frm_Conciliacion.MdiParent = this;
            frm_Conciliacion.Show();
        }

        private void ConciliaciónBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Help.ShowHelp(this, "C:/Ayudas/ConciliacionBancaria.chm");
        }
    }
}
