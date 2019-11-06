using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaFinanzas;

namespace Finanzas
{
    public partial class frm_cuentasContables : Form
    {
        int boton = 0;
        logica logic = new logica();
        
        public frm_cuentasContables(string user)
        {
            InitializeComponent();
            llenarComboBox();
           

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

        private void frm_cuentasContables_Load(object sender, EventArgs e)
        {
            dgv_cuentasContables.DataSource = logic.consultaLogicaCuentasContables().Tables[0];
            cbo_tipoCuenta.Enabled = false;
            txt_CodigoCuenta.Enabled = false;
            txt_descripcionCuenta.Enabled = false;
            txt_estado.Enabled = false;
            txt_nombreCuenta.Enabled = false;
        }

        void bloquearBotones()
        {
            btn_ingresar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
 
        }

        void habilitarBotones()
        {
            btn_ingresar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        void habilitarCajasTexto()
        {
            cbo_tipoCuenta.Enabled = true;
            txt_CodigoCuenta.Enabled = true;
            txt_descripcionCuenta.Enabled = true;
            txt_estado.Enabled = true;
            txt_nombreCuenta.Enabled = true;

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int renglon;

        private void dgv_cuentasContables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgv_cuentasContables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //tabPage2.Show();

           



        }
         

        void deshabilitarForm()
        {
            cbo_tipoCuenta.Enabled = false;
            txt_CodigoCuenta.Enabled = false;
            txt_descripcionCuenta.Enabled = false;
            txt_estado.Enabled = false;
            txt_nombreCuenta.Enabled = false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {


            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
           
           
        }
        string codigoTipocuenta;
        private void cbo_tipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void dgv_cuentasContables_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            boton = 1;
            bloquearBotones();
            habilitarCajasTexto();
            limpiarForm();
            txt_CodigoCuenta.Enabled = false;
            txt_estado.Text = "1";
            txt_estado.Enabled = false;
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            boton = 2;
            bloquearBotones();
            habilitarCajasTexto();
            txt_CodigoCuenta.Enabled = false;
            cbo_tipoCuenta.Enabled = false;
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
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

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
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

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones();
            cbo_tipoCuenta.Enabled = false;
            txt_CodigoCuenta.Enabled = false;
            txt_descripcionCuenta.Enabled = false;
            txt_estado.Enabled = false;
            txt_nombreCuenta.Enabled = false;
            cbo_tipoCuenta.Text = "";
            txt_CodigoCuenta.Text = "";
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_tipoCuenta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string resultado = "";

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

                    //MessageBox.Show(maximo.ToString());
                    /* maximo++;
                     string siguienteCodigo = codigoTipocuenta + "." + maximo;*/
                    maxCodigo = "";
                    identificador = 0;
                    max = "";
                    maxcodigo2 = "";

                }


            }
        }
    }
}
