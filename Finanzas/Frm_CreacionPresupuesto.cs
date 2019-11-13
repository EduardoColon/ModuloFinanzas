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
            string[] alias = { "Id", "Moneda", "Area", "Cuenta", "Nombre", "Fecha", "Descripcion", "Monto", "Anotacion", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.Coral);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarComboConTabla("tbl_moneda", "nombre_moneda", 1);
            navegador1.asignarComboConTabla("tbl_areas", "nombreArea", 1);
            navegador1.asignarComboConTabla("tbl_cuentas", "nombre", 1);
            navegador1.asignarAyuda("512");
            navegador1.asignarTabla("tbl_presupuesto");
            navegador1.asignarNombreForm("Creacion Presupuesto");
        }

        private void Navegador1_Load(object sender, EventArgs e)
        {

        }

        private void Frm_CreacionPresupuesto_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }

        private void Navegador1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
