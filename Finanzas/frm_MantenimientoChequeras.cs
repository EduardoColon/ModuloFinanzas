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
    public partial class frm_MantenimientoChequeras : Form
    {
        string usuario="";
        public frm_MantenimientoChequeras(string user)
        {
            usuario = user;
            InitializeComponent();
            string[] alias = { "ID Chequera:", "Cuenta Bancaria:", "No. Cheques:", "estado:" };

            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarComboConTabla("tbl_cuentabancaria", "PK_IDCuentaBancaria");
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_chequera");
            navegador1.asignarNombreForm("Mantenimiento de Chequeras");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
