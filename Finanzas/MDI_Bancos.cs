using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaLogicaFinanzas;

namespace Finanzas
{

    public partial class MDI_Bancos : Form
    {
        logica logic = new logica();
        string sUsuario = "miusuario";
        private int childFormNumber = 0;

        public MDI_Bancos()
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
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void movimientosDeBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MovimientosBancarios movimientosbancarios = new Frm_MovimientosBancarios();
            movimientosbancarios.MdiParent = this;
            movimientosbancarios.Show();
        }

        private void tipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CambioMoneda cambioMoneda = new frm_CambioMoneda(sUsuario);
            cambioMoneda.MdiParent = this;
            cambioMoneda.Show();
        }

        private void conciliacionBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_conciliacionBancaria conciliacionBancaria = new frm_conciliacionBancaria(sUsuario);
            conciliacionBancaria.MdiParent = this;
            conciliacionBancaria.Show();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manbancos bancos = new frm_manbancos(sUsuario);
            bancos.MdiParent = this;
            bancos.Show();
        }


        private void clasificadorDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_clasificadordemovimientos clasficadordegastos = new frm_clasificadordemovimientos(sUsuario);
            clasficadordegastos.MdiParent = this;
            clasficadordegastos.Show();
        }
        private void EnvioPolizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_envioPolizas frm_Envio = new frm_envioPolizas(sUsuario);
            frm_Envio.MdiParent = this;
            frm_Envio.Show();
        }

        private void ConsultarConciliacionBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultarConciliacion frm_Consultar = new frm_ConsultarConciliacion(sUsuario);
            frm_Consultar.MdiParent = this;
            frm_Consultar.Show();

        }

        private void ConsultarConciliacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultarConciliacion frm_Consultar = new frm_ConsultarConciliacion(sUsuario);
            frm_Consultar.MdiParent = this;
            frm_Consultar.Show();
        }

        private void envioPolizasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_envioPolizas envioPolizas = new frm_envioPolizas(sUsuario);
            envioPolizas.MdiParent = this;
            envioPolizas.Show();
        }

        private void MDI_Bancos_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
            sUsuario = login.obtenerNombreUsuario();
            lbl_usuario.Text = sUsuario;
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ConciliacionBancariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/ConciliacionBancaria.chm");
        }

        private void EnvioDePolizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/EnvioPolizasBancos.chm");

        }
    }
}
