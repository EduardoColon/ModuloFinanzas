using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDiseno;

namespace Finanzas
{

    public partial class frm_tipoCuentaContable : Form
    {
        string usuario = "";
        public frm_tipoCuentaContable(string user)
        {
            InitializeComponent();
            //Parametros de Navegador

            usuario = user;
            string[] alias = { "Codigo Tipo Cuenta", "Nombre", "descripcion", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.Coral);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("501");
            navegador1.asignarTabla("tbl_tipoCuenta");
            navegador1.asignarNombreForm("Tipo de Cuenta Contable");
        }


        private void frm_tipoCuentaContable_Load(object sender, EventArgs e)
        {

        }

        private void frm_tipoCuentaContable_Load_1(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
        
    }
}
