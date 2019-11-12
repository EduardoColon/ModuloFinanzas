﻿using System;
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
    public partial class frm_clasificadordemovimientos : Form
    {
        string usuario = "";
        public frm_clasificadordemovimientos(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "ID tipo movimiento:", "Nombre:", "Descripción:", "estado:" };

            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.Coral);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("507");
            navegador1.asignarTabla("tbl_tipo_movimiento");
            navegador1.asignarNombreForm("Clasificador de movimientos");
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
