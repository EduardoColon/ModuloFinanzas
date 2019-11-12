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
    public partial class frm_manbancos : Form
    {
        string usuario = "";
        public frm_manbancos(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "ID Banco:", "Nombre:", "Descripción:", "estado:" };

            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.Coral);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("506");
            navegador1.asignarTabla("tbl_bancos");
            navegador1.asignarNombreForm("Mantenimiento de Bancos");
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
