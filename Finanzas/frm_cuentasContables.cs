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
    public partial class frm_cuentasContables : Form
    {
        string usuario = "";
        public frm_cuentasContables(string user)
        {
            InitializeComponent();

            usuario = user;
            string[] alias = { "Codigo Cuenta", "Tipo de Cuenta", "Nombre", "Descripcion", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarComboConTabla("tbl_tipoCuenta", "nombre_tipoCuenta",1);
            navegador1.asignarAyuda("4");
            navegador1.asignarTabla("tbl_cuentas");
            navegador1.asignarNombreForm("Cuentas Contables");
        }

        private void frm_cuentasContables_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
