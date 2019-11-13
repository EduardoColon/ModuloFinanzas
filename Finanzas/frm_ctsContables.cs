using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDisenoBARRA;
using CapaLogicaFinanzas;

namespace Finanzas
{
    public partial class frm_ctsContables : Form
    {
        string usuario = "";
        int boton = 0;
        logica logic = new logica();

        public frm_ctsContables(string user)
        {
            InitializeComponent();
            usuario = user;
            navegador1.asignarSalida(this);
            navegador1.asignarAyuda("503");
            navegador1.Btn_Ingresar.Click += Btn_Ingresar_Click;
            navegador1.Btn_Modificar.Click += Btn_Modificar_Click;
            navegador1.Btn_Guardar.Click += Btn_Guardar_Click;
            navegador1.Btn_Eliminar.Click += Btn_Eliminar_Click;
            navegador1.Btn_Cancelar.Click += Btn_Cancelar_Click;
            navegador1.Btn_FlechaInicio.Click += Btn_FlechaInicio_Click;
            navegador1.Btn_Siguiente.Click += Btn_Siguiente_Click;
            navegador1.Btn_Anterior.Click += Btn_Anterior_Click;
            navegador1.Btn_FlechaFin.Click += Btn_FlechaFin_Click;
            navegador1.Btn_Refrescar.Click += Btn_Refrescar_Click;
            llenarComboBox();
           
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            dgv_cuentasContables.DataSource = logic.consultaLogicaCuentasContables().Tables[0];
        }

        private void Btn_FlechaFin_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            /*dgv_cuentasContables.Rows[dgv_cuentasContables.Rows.Count - 2].Selected = true;
            dgv_cuentasContables.CurrentCell = dgv_cuentasContables.Rows[dgv_cuentasContables.Rows.Count - 2].Cells[0];
            int fila = dgv_cuentasContables.SelectedRows[0].Index;
            if (fila < dgv_cuentasContables.Rows.Count - 1)
            {
                dgv_cuentasContables.Rows[dgv_cuentasContables.Rows.Count - 2].Selected = true;
                dgv_cuentasContables.CurrentCell = dgv_cuentasContables.Rows[dgv_cuentasContables.Rows.Count - 2].Cells[0];
            }*/
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            /*int fila = dgv_cuentasContables.SelectedRows[0].Index;
            if (fila > 0)
            {
                dgv_cuentasContables.Rows[fila - 1].Selected = true;
                dgv_cuentasContables.CurrentCell = dgv_cuentasContables.Rows[fila - 1].Cells[0];
            }*/
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            /*int fila = dgv_cuentasContables.SelectedRows[0].Index;
            if (fila < dgv_cuentasContables.Rows.Count - 1)
            {
                dgv_cuentasContables.Rows[fila + 1].Selected = true;
                dgv_cuentasContables.CurrentCell = dgv_cuentasContables.Rows[fila + 1].Cells[0];
            }*/
        }

        private void Btn_FlechaInicio_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
          
        }

        void llenarComboBox()
        {
            DataTable llenarCombo = logic.consultaLogicaTipoCuentaContable();

            foreach (DataRow row in llenarCombo.Rows)
            {
                cbo_tipoCuenta.Items.Add(row[0].ToString());
            }
        }


        void limpiarForm()
        {
            txt_CodigoCuenta.Text = "";
            txt_descripcionCuenta.Text = "";
            txt_estado.Text = "";
            txt_nombreCuenta.Text = "";
            cbo_tipoCuenta.Text = "";
        }

        void habilitarCajasTexto()
        {
            cbo_tipoCuenta.Enabled = true;
            txt_CodigoCuenta.Enabled = true;
            txt_descripcionCuenta.Enabled = true;
            txt_estado.Enabled = true;
            txt_nombreCuenta.Enabled = true;

        }

        void deshabilitarForm()
        {
            cbo_tipoCuenta.Enabled = false;
            txt_CodigoCuenta.Enabled = false;
            txt_descripcionCuenta.Enabled = false;
            txt_estado.Enabled = false;
            txt_nombreCuenta.Enabled = false;
        }

        void habilitarBotones()
        {
            navegador1.Btn_Ingresar.Enabled = true;
            navegador1.Btn_Modificar.Enabled = true;
            navegador1.Btn_Eliminar.Enabled = true;
        }

        void bloquearBotones()
        {
            navegador1.Btn_Ingresar.Enabled = false;
            navegador1.Btn_Modificar.Enabled = false;
            navegador1.Btn_Eliminar.Enabled = false;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            habilitarBotones();
            cbo_tipoCuenta.Enabled = false;
            txt_CodigoCuenta.Enabled = false;
            txt_descripcionCuenta.Enabled = false;
            txt_estado.Enabled = false;
            txt_nombreCuenta.Enabled = false;
            cbo_tipoCuenta.Text = "";
            txt_CodigoCuenta.Text = "";
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            try
            {
                if (txt_CodigoCuenta.Text != "")
                {
                    string sCodigoCuenta = txt_CodigoCuenta.Text;
                    logic.consultaLogicaEliminarCuentaContable(sCodigoCuenta);
                    MessageBox.Show("Registro eliminado");
                    limpiarForm();
                    habilitarBotones();
                    deshabilitarForm();
                    dgv_cuentasContables.DataSource = logic.consultaLogicaCuentasContables().Tables[0];
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningun registro");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        string codigoTipocuenta;

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            string sTipoCuenta;
            string sNombreCuenta;
            string sDescripcionCuenta;
            string sEstado;

            if (boton == 1)
            {

                try
                {
                    if (txt_CodigoCuenta.Text == "" || txt_descripcionCuenta.Text == "" || txt_estado.Text == "" || txt_nombreCuenta.Text == "" || cbo_tipoCuenta.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("Faltan campos por llenar");
                    }


                    else
                    {
                        string sCodigoCuenta = txt_CodigoCuenta.Text;
                        DataTable maxCodigoCuentaContable = logic.consultaLogicaMaxCuentaContable(codigoTipocuenta);

                        foreach (DataRow row in maxCodigoCuentaContable.Rows)
                        {
                            string maxCodigo = row[0].ToString();
                            int identificador = Convert.ToInt32(maxCodigo);
                            identificador++;


                            sTipoCuenta = cbo_tipoCuenta.SelectedItem.ToString();
                            sNombreCuenta = txt_nombreCuenta.Text;
                            sDescripcionCuenta = txt_descripcionCuenta.Text;
                            sEstado = txt_estado.Text;
                            logic.consultaLogicaIngresoCuentasContables(sCodigoCuenta, sTipoCuenta, identificador, sNombreCuenta, sDescripcionCuenta, sEstado);
                            MessageBox.Show("Registro Almacenado Exitosamente");

                            limpiarForm();
                            habilitarBotones();
                            deshabilitarForm();
                            dgv_cuentasContables.DataSource = logic.consultaLogicaCuentasContables().Tables[0];
                        }

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else if (boton == 2)
            {
                if (txt_CodigoCuenta.Text == "" || txt_descripcionCuenta.Text == "" || txt_estado.Text == "" || txt_nombreCuenta.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }

                else
                {
                    string sCodigoCuenta = txt_CodigoCuenta.Text;
                    sNombreCuenta = txt_nombreCuenta.Text;
                    sDescripcionCuenta = txt_descripcionCuenta.Text;
                    sEstado = txt_estado.Text;

                    logic.consultaLogicaModificarCuenta(sCodigoCuenta, sNombreCuenta, sDescripcionCuenta, sEstado);
                    MessageBox.Show("Registro Modificado Exitosamente");
                    limpiarForm();
                    habilitarBotones();
                    deshabilitarForm();
                    dgv_cuentasContables.DataSource = logic.consultaLogicaCuentasContables().Tables[0];
                }

            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            boton = 2;
            habilitarCajasTexto();
            bloquearBotones();
            txt_CodigoCuenta.Enabled = false;
            cbo_tipoCuenta.Enabled = false;
            navegador1.Btn_Guardar.Enabled = true;
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            boton = 1;
            habilitarCajasTexto();
            bloquearBotones();
            limpiarForm();
            txt_CodigoCuenta.Enabled = false;
            txt_estado.Text = "1";
            txt_estado.Enabled = false;
            navegador1.Btn_Guardar.Enabled = true;
        }

        private void frm_ctsContables_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);

            dgv_cuentasContables.DataSource = logic.consultaLogicaCuentasContables().Tables[0];
            cbo_tipoCuenta.Enabled = false;
            txt_CodigoCuenta.Enabled = false;
            txt_descripcionCuenta.Enabled = false;
            txt_estado.Enabled = false;
            txt_nombreCuenta.Enabled = false;

        }
        int renglon;
        private void dgv_cuentasContables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
            string sCodigoCuenta;
            string sNombreCuenta;
            string sDescripcionCuenta;
            string sEstado;

            sCodigoCuenta = dgv_cuentasContables.Rows[renglon].Cells[0].Value.ToString();
            txt_CodigoCuenta.Text = sCodigoCuenta;

            sNombreCuenta = dgv_cuentasContables.Rows[renglon].Cells[2].Value.ToString();
            txt_nombreCuenta.Text = sNombreCuenta;

            sDescripcionCuenta = dgv_cuentasContables.Rows[renglon].Cells[3].Value.ToString();
            txt_descripcionCuenta.Text = sDescripcionCuenta;

            sEstado = dgv_cuentasContables.Rows[renglon].Cells[4].Value.ToString();
            txt_estado.Text = sEstado;
        }

        private void cbo_tipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resultado = "";

            try
            {
                string sTipoCuenta = cbo_tipoCuenta.SelectedItem.ToString();

                codigoTipocuenta = logic.consultaLogicaCodigoDeTipoDeCuenta(sTipoCuenta);
                DataTable maxCodigoCuentaContable = logic.consultaLogicaMaxCuentaContable(codigoTipocuenta);

                foreach (DataRow row in maxCodigoCuentaContable.Rows)
                {

                    string maxCodigo = row[0].ToString();
                    int identificador = Convert.ToInt32(maxCodigo);



                    DataTable maxCodCuentaContable = logic.consultaLogicaMaxCuentaContable2(identificador);

                    foreach (DataRow row2 in maxCodCuentaContable.Rows)
                    {
                        string max = row2[0].ToString();
                        string maxcodigo2 = max.Substring(max.Length - 1, 1);
                        int maximo = Convert.ToInt32(maxcodigo2);

                        if (maximo == 9)
                        {
                            string penultimo = max.Substring(max.Length - 2, 1);
                            int iPenultimo = Convert.ToInt32(penultimo);
                            iPenultimo++;
                            resultado = iPenultimo.ToString() + "0";
                            max = max.Substring(0, max.Length - 2) + resultado;
                            txt_CodigoCuenta.Text = max;
                        }
                        else
                        {
                            maximo++;
                            resultado = maximo.ToString();
                            max = max.Substring(0, max.Length - 1) + resultado;
                            txt_CodigoCuenta.Text = max;
                        }
                        maxCodigo = "";
                        identificador = 0;
                        max = "";
                        maxcodigo2 = "";

                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tipo de Cuenta No Valido");
                Console.WriteLine(ex);
            }
            
        }
    }
}
