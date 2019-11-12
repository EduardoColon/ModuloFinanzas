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
    public partial class frm_ctsbancarias : Form
    {
        string usuario = "";
        public frm_ctsbancarias(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "ID Cuenta:","No._de_Cuenta:", "Descripción:","Banco:","Moneda:","Firmas_Individuales:",
                                "Firmantes_Conjuntos:","Saldo:","Tipo de Cuenta","Estado:" };

            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.Coral);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarComboConTabla("tbl_bancos", "nombre",1); //KidBancos
            navegador1.asignarComboConTabla("tbl_divisa", "Nombre",1); //KidDivisa
            navegador1.asignarComboConTabla("tbl_tipocuentabancaria", "Nombre", 1); //KidTipoCtaBancaria
            navegador1.asignarAyuda("504");
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
