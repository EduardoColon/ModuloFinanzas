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
    public partial class Frm_MantenimientoCuentasBancarias : Form
    {

        ///////////////////////// VARIABLES GLOBALES//////////////////////
        string usuario = "";


       
        public Frm_MantenimientoCuentasBancarias(string user)
        {
            InitializeComponent();

            usuario = user;
            string[] alias = { "ID Cuenta:","No._de_Cuenta:", "Descripción:","Banco:","Moneda:","Firmas_Individuales:",
                                "Firmantes_Conjuntos:","Saldo:","Cuenta_Primaria:","Estado:" };

            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarComboConTabla("tbl_bancos", "KidBanco");
            navegador1.asignarComboConTabla("tbl_divisa", "KidDivisa");
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_cuentabancaria");
            navegador1.asignarNombreForm("Mantenimiento Cuentas Bancarias");
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