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
    public partial class frm_conciliacionBancaria : Form
    {
        string sUsuario;
        public frm_conciliacionBancaria(string sUsuario)
        {
            InitializeComponent();
            this.sUsuario = sUsuario;
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
    }
}
