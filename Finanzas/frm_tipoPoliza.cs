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
    public partial class frm_tipoPoliza : Form
    {
        string usuario = "";
        public frm_tipoPoliza(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "Codigo Tipo Poliza", "Descripcion", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.Coral);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("500");
            navegador1.asignarTabla("tbl_tipo_poliza");
            navegador1.asignarNombreForm("Tipo de Poliza");
        }

        private void frm_tipoPoliza_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }

        private void Navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
