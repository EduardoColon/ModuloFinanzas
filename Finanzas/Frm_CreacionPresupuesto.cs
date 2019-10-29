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
    public partial class Frm_CreacionPresupuesto : Form
    {
        string usuario = "";
        public Frm_CreacionPresupuesto(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "Codigo", "Moneda", "Area", "Cuenta","Nombre","Fecha","Descripcion","monto","anotacion","estado"};
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarComboConTabla("tbl_divisa", "KidDivisa");
            navegador1.asignarComboConTabla("tbl_areas", "KidArea");
            navegador1.asignarComboConTabla("tbl_cuentas", "KidCuenta");
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_presupuesto");
            navegador1.asignarNombreForm("Creacion de Presupuesto");
        }

        private void Navegador1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
