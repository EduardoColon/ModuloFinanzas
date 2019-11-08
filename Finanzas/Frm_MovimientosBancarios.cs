using CapaLogicaFinanzas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------------------------Alejandro Barreda---------------------------------------------------------------------
namespace Finanzas
{
    public partial class Frm_MovimientosBancarios : Form
    {//variables globales
        double saldon = 0;
        double saldon2 = 0;
        double saldoactual = 0;
        double saldoactual2 = 0;
        int Chequesactuales = 0;
        //variables para llenar combobox con consultas de BD
        List<string> Cuentas = new List<string>();
        List<string> saldo = new List<string>();
        List<string> NoDoc = new List<string>();
        List<string> ncheques = new List<string>();
        List<string> cuentasContables = new List<string>();
        List<string> ClasificadordeGastos = new List<string>();


        public Frm_MovimientosBancarios()
        {
            InitializeComponent();
            bloqueo();
        }

        //===========Consulta para Numero de Documento en Movimiento Bancario=====================
        void Documento()
        {
            logica logic = new logica();
            NoDoc.Clear();
            NoDoc = logic.LogicaObtenerNoDocBancario();
            txtdoc.Text = NoDoc[0];
        }

        //===========Bloquear todos los componentes del formulario
        void bloqueo()
        {
            txtanombre.Enabled = false;
            txtdes.Enabled = false;
            txtdoc.Enabled = false;
            txtvalor.Enabled = false;
            boxcredito.Enabled = false;
            boxdebito.Enabled = false;
            boxctacontablecredito.Enabled = false;
            boxctacontabledebito.Enabled = false;
            boxClasifGastos.Enabled = false;
            txtctacredito.Enabled = false;
            //  dateTimePicker1.Enabled = false;
            Documento();
        }

        //============limpiar todos los componentes del formulario
        void limpiar()
        {
            txtanombre.Text = "";
            txtdes.Text = "";
            txtdoc.Text = "";
            txtvalor.Text = "";
            boxcredito.Text = "";
            boxdebito.Text = "";
            boxtransac.Text = "";
            txtctacredito.Text = "";
            boxdebito.Items.Clear();
            boxcredito.Items.Clear();
            boxctacontablecredito.Items.Clear();
            boxctacontabledebito.Items.Clear();
            boxClasifGastos.Items.Clear();
        }

        //==============funcion para cheques (llama las cuentas que estan disponibles con chequeras)
        void llamarChequeras()
        {
            //llenar combobox con cuentas con chequeras
            boxdebito.Items.Clear();
            Cuentas.Clear();
            logica logic = new logica();
            Cuentas = logic.LogicaObtenerCuentasBancariasconCheques();
            if (Cuentas.Count > 0)
            {
                for (int i = 0; i < Cuentas.Count; i++)
                {
                    boxdebito.Items.Add(Cuentas[i]);
                }
                boxdebito.SelectedIndex = 0;
            }

        }

        //============funcion para ver numero de cheques de una cuenta
        void vernumerocheques(string cuenta)
        {
            logica logic = new logica();
            ncheques.Clear();
            ncheques = logic.LogicaObtenerNoCheques(cuenta);

        }

        void llamarCuentaspropias(ComboBox combobox)
        {
            //llenar combobox con cuentas
            combobox.Items.Clear();
            Cuentas.Clear();
            logica logic = new logica();
            Cuentas = logic.LogicaObtenerCuentasBancarias();
            if (Cuentas.Count > 0)
            {
                for (int i = 0; i < Cuentas.Count; i++)
                {
                    combobox.Items.Add(Cuentas[i]);
                }
                combobox.SelectedIndex = 0;
            }
        }

        //LLENAR COMBOBOX DE CUENTAS CONTABLES
        void llamarcuentascontablescredito()
        {

            logica logic = new logica();
            try
            {
                DataTable dtModulos = logic.consultaLogicaCuentasContables1();

                foreach (DataRow row in dtModulos.Rows)
                {
                    boxctacontabledebito.Items.Add(row[1].ToString());
                    boxctacontablecredito.Items.Add(row[1].ToString());
                    cuentasContables.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }

            if (cuentasContables.Count > 0)
            {
                boxctacontablecredito.SelectedIndex = 0;
                boxctacontabledebito.SelectedIndex = 0;
            }
        }


        //LLENAR COMBOBOX DE Clasificador de Gastos
        void llamarclasificadordegastos()
        {
            boxClasifGastos.Items.Clear();
            //llenar combobox con cuentas contables
            logica logic = new logica();
            try
            {
                DataTable dtModulos = logic.LogicaObtenerClasificadorGastos();

                foreach (DataRow row in dtModulos.Rows)
                {
                    boxClasifGastos.Items.Add(row[1].ToString());

                    ClasificadordeGastos.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }

            if (cuentasContables.Count > 0)
            {
                boxClasifGastos.SelectedIndex = 0;

            }
        }


        //============Verificacion si los campos a ingresar estan llenos y con caracteres permitidos
        void vercampos()
        {
            if (string.IsNullOrEmpty(boxtransac.Text) || boxtransac.SelectedIndex==-1) {
            
                    MessageBox.Show("Elija un tipo de Transacción a realizar");
                
            }

            
         else if (txtvalor.Text.Any(x => !char.IsLetter(x)))
            {
                if (boxtransac.SelectedItem.ToString() == "Cheques")
                {
                    if (txtanombre.Text == "")
                        MessageBox.Show("Por favor, escriba el nombre del beneficiario");
                    else if (txtdes.Text == "")
                        MessageBox.Show("Por favor, escriba una breve descripcion del movimiento");
                    else if (ClasificadordeGastos[boxClasifGastos.SelectedIndex] == "")
                        MessageBox.Show("Por favor, elija un Clasificador de Gasto");
                    else
                    {
                        logica logic = new logica();
                        saldo = logic.LogicaVerificarFondosCuentaBancaria(boxdebito.SelectedItem.ToString());
                        //conversion lista string a double
                        List<double> saldolista = saldo.Select(x => double.Parse(x)).ToList();
                        //como solo existe un dato en posicion [0], se pasa a un double para poder restar o sumar más fácil.
                        saldon = saldolista[0];

                        CrearMovimiento();
                    }
                }

                else if (boxtransac.SelectedItem.ToString() == "Depositos")
                {
                    if (txtanombre.Text == "")
                        MessageBox.Show("Por favor, escriba el nombre del beneficiario");
                    else if (txtdes.Text == "")
                        MessageBox.Show("Por favor, escriba una breve descripcion del movimiento");
                    else if (ClasificadordeGastos[boxClasifGastos.SelectedIndex] == "")
                        MessageBox.Show("Por favor, elija un Clasificador de Gasto");

                    else
                    {
                        logica logic = new logica();
                        saldo = logic.LogicaVerificarFondosCuentaBancaria(boxcredito.SelectedItem.ToString());
                        //conversion lista string a double
                        List<double> saldolista = saldo.Select(x => double.Parse(x)).ToList();
                        //como solo existe un dato en posicion [0], se pasa a un double para poder restar o sumar más fácil.
                        saldon = saldolista[0];
                        // CreacionDeposito
                        saldoactual = (saldon + Convert.ToDouble(txtvalor.Text));
                        DialogResult asegurarse = MessageBox.Show("¿Está seguro que desea hacer este Depósito?\nUna vez hecho no se podrá revertir.", "Movimientos Bancarios", MessageBoxButtons.OKCancel);
                        if (asegurarse == DialogResult.OK)
                        {
                            creacionmovimientobancario("", "", boxcredito.SelectedItem.ToString(), Convert.ToDouble(txtvalor.Text), boxtransac.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), txtanombre.Text, txtdes.Text, "", "", cuentasContables[boxctacontabledebito.SelectedIndex], cuentasContables[boxctacontablecredito.SelectedIndex], ClasificadordeGastos[boxClasifGastos.SelectedIndex], "1");
                            Console.WriteLine("Se hizo un depósito");
                        }
                        else if (asegurarse == DialogResult.Cancel)
                        {
                            Console.WriteLine("No se creó el Depósito");
                        }
                    }
                }

                else if (boxtransac.Text == "ACH (Pagos por transferencia)")
                {
                    if (txtctacredito.Text == "")
                        MessageBox.Show("Por favor, ingrese numero de cuenta a la que se hará la transacción");
                    else if (txtanombre.Text == "")
                        MessageBox.Show("Por favor, escriba el nombre del beneficiario");
                    else if (txtdes.Text == "")
                        MessageBox.Show("Por favor, escriba una breve descripcion del movimiento");
                    else if (ClasificadordeGastos[boxClasifGastos.SelectedIndex] == "")
                        MessageBox.Show("Por favor, elija un Clasificador de Gasto");
                    else
                    {
                        logica logic = new logica();
                        saldo = logic.LogicaVerificarFondosCuentaBancaria(boxdebito.SelectedItem.ToString());
                        //conversion lista string a double
                        List<double> saldolista = saldo.Select(x => double.Parse(x)).ToList();
                        //como solo existe un dato en posicion [0], se pasa a un double para poder restar o sumar más fácil.
                        saldon = saldolista[0];
                        CrearMovimiento();
                    }
                }

                else if (boxtransac.SelectedItem.ToString() == "Transacciones entre Cuentas propias")
                {
                    if (txtanombre.Text == "")
                        MessageBox.Show("Por favor, escriba el nombre de quien hace la transaccion");
                    else if (txtdes.Text == "")
                        MessageBox.Show("Por favor, escriba una breve descripcion del movimiento");
                    else
                    {
                        logica logic = new logica();
                        saldo = logic.LogicaVerificarFondosCuentaBancaria(boxdebito.SelectedItem.ToString());
                        //conversion lista string a double
                        List<double> saldolista = saldo.Select(x => double.Parse(x)).ToList();
                        //como solo existe un dato en posicion [0], se pasa a un double para poder restar o sumar más fácil.
                        saldon = saldolista[0];
                        CrearMovimiento();
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Por favor, llene el campo de Valor con una cifra numerica");
            }
        }



        //-------------------------------------------------------------------------------------------------------------//
        //----------------**FUNCION PARA CONSULTAR SALDOS Y CREAR MOVIMIENTOS BANCARIOS**------------------------------//
        //-------------------------------------------------------------------------------------------------------------//
        void CrearMovimiento()
        {

            if (boxctacontablecredito.Text == boxctacontabledebito.Text)
            {
                MessageBox.Show("Cuentas Contables Iguales, Imposible crear partida");
            }
            else
            {
                if (saldon > 0 && saldon > Convert.ToDouble(txtvalor.Text))
                {
                    DialogResult asegurarse = MessageBox.Show("¿Está seguro que desea hacer este movimiento?\nUna vez hecho no se podrá revertir.", "Movimientos Bancarios", MessageBoxButtons.OKCancel);
                    if (asegurarse == DialogResult.OK)
                    {
                        //Crear Movimiento Bancario Insertar en tabla libro bancos
                        if (boxtransac.SelectedItem.ToString() == "Cheques")
                        {
                            //METODO PARA CREAR CHEQUES
                            //CreacionCheque(id, cuenta_debito, cuenta_credito, monto, tipo_movimiento, fecha_movimiento, beneficiario, descripcion, movimiento_concilidado, movimiento_trasladado_contabilidad, KidCuenta_contabledebito, KidCuenta_contablecredito, KidTipo_movimiento, estado)
                            saldoactual = (saldon - Convert.ToDouble(txtvalor.Text));
                            vernumerocheques(boxdebito.SelectedItem.ToString());
                            Chequesactuales = Int32.Parse(ncheques[0]) - 1;
                            creacionmovimientobancario("", boxdebito.SelectedItem.ToString(), "", Convert.ToDouble(txtvalor.Text), boxtransac.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), txtanombre.Text, txtdes.Text, "", "", cuentasContables[boxctacontabledebito.SelectedIndex], cuentasContables[boxctacontablecredito.SelectedIndex], ClasificadordeGastos[boxClasifGastos.SelectedIndex], "1");
                            Console.WriteLine("Se hizo un cheque");

                        }

                        else if (boxtransac.Text == "ACH (Pagos por transferencia)")
                        {
                            //METODO PARA CREAR CHEQUES
                            //CreacionCheque(id, cuenta_debito, cuenta_credito, monto, tipo_movimiento, fecha_movimiento, beneficiario, descripcion, movimiento_concilidado, movimiento_trasladado_contabilidad, KidCuenta_contabledebito, KidCuenta_contablecredito, KidTipo_movimiento, estado)
                            saldoactual = (saldon - Convert.ToDouble(txtvalor.Text));
                            vernumerocheques(boxdebito.SelectedItem.ToString());
                            Chequesactuales = Int32.Parse(ncheques[0]) - 1;
                            creacionmovimientobancario("", boxdebito.SelectedItem.ToString(), txtctacredito.Text, Convert.ToDouble(txtvalor.Text), boxtransac.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), txtanombre.Text, txtdes.Text, "", "", cuentasContables[boxctacontabledebito.SelectedIndex], cuentasContables[boxctacontablecredito.SelectedIndex], ClasificadordeGastos[boxClasifGastos.SelectedIndex], "1");
                            Console.WriteLine("Se hizo la transeferencia a Terceros");
                        }

                        else if (boxtransac.SelectedItem.ToString() == "Transacciones entre Cuentas propias")
                        {
                            // CreacionTransaccion();
                            //CONSULTA DE SALDO DE CUENTA A DEBITAR PARA RESTAR
                            saldoactual = (saldon - Convert.ToDouble(txtvalor.Text));


                            //CONSULTA DE SALDO DE CUENTA A ACREDITAR PARA SUMAR
                            logica logic2 = new logica();
                            saldo = logic2.LogicaVerificarFondosCuentaBancaria(boxcredito.SelectedItem.ToString());
                            //conversion lista string a double
                            List<double> saldolista2 = saldo.Select(x => double.Parse(x)).ToList();
                            //como solo existe un dato en posicion [0], se pasa a un double para poder restar o sumar más fácil.
                            saldon2 = saldolista2[0];

                            // CreacionDeposito
                            saldoactual2 = (saldon2 + Convert.ToDouble(txtvalor.Text));

                            //CreacionCheque(id, cuenta_debito, cuenta_credito, monto, tipo_movimiento, fecha_movimiento, beneficiario, descripcion, movimiento_concilidado, movimiento_trasladado_contabilidad, KidCuenta_contabledebito, KidCuenta_contablecredito, KidTipo_movimiento, estado)

                            creacionmovimientobancario("", boxdebito.SelectedItem.ToString(), boxcredito.SelectedItem.ToString(), Convert.ToDouble(txtvalor.Text), boxtransac.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), txtanombre.Text, txtdes.Text, "", "", cuentasContables[boxctacontabledebito.SelectedIndex], cuentasContables[boxctacontablecredito.SelectedIndex], ClasificadordeGastos[boxClasifGastos.SelectedIndex], "1");


                            Console.WriteLine("Se hizo una transaccion entre cuentas propias");
                        }

                        Console.WriteLine("se creó el movimiento");
                        limpiar();
                        bloqueo();
                    }
                    else if (asegurarse == DialogResult.Cancel)
                    {
                        Console.WriteLine("No se creó el movimiento");
                    }



                    //Si hay fondos pero no para esa transacción
                    else if (saldon > 0 && saldon < Convert.ToDouble(txtvalor.Text))
                    {
                        MessageBox.Show("No hay fondos suficientes en la Cuenta Bancaria Seleccionada\n" +
                                        "para la Transacción Solicitada");
                    }

                    else if (saldon == 0)
                    {
                        //Si no hay fondos en la cuenta seleccionada para debitar.
                        MessageBox.Show("NO HAY FONDOS EN LA CUENTA BANCARIA SELECCIONADA A DEBITAR");
                    }

                }


            }


            //Si hay fondos
        }

        //=====================================================================================================================
        //======================================================================================================================


        //Funcion para enviar datos a tbl_libro Bancos
        void creacionmovimientobancario(string ID, string cuenta_debito, string cuenta_credito, double monto, string tipo_movimiento, string fecha_movimiento, string beneficiario, string descripcion, string movimiento_concilidado,
                            string movimiento_trasladado_contabilidad, string KidCuenta_contabledebito, string KidCuenta_contablecredito, string KidTipo_movimiento, string estado)
        {
            logica sentencia = new logica();
            sentencia.LogicaIngresarMovimientoBancario(ID, cuenta_debito, cuenta_credito, monto.ToString(), tipo_movimiento, fecha_movimiento, beneficiario, descripcion, movimiento_concilidado, movimiento_trasladado_contabilidad, KidCuenta_contabledebito, KidCuenta_contablecredito, KidTipo_movimiento, estado);
            if (boxdebito.Enabled == true)
            {
                sentencia.LogicaActualizarSaldoBancario(cuenta_debito, saldoactual);
                sentencia.LogicaActualizarCheques(cuenta_debito, Chequesactuales);
            }
            if (boxcredito.Enabled == true)
            {
                sentencia.LogicaActualizarSaldoBancario(cuenta_credito, saldoactual);
            }

            if (boxcredito.Enabled == true && boxdebito.Enabled == true)
            {
                sentencia.LogicaActualizarSaldoBancario(cuenta_debito, saldoactual);
                sentencia.LogicaActualizarSaldoBancario(cuenta_credito, saldoactual2);
            }


        }


        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void txttransac_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (boxtransac.Text == "Cheques")
            {
                bloqueo();
                limpiar();
                boxdebito.Enabled = true;
                txtvalor.Enabled = true;
                txtanombre.Enabled = true;
                txtdes.Enabled = true;
                llamarChequeras();
                boxctacontabledebito.Enabled = true;
                boxctacontablecredito.Enabled = true;
                llamarcuentascontablescredito();
                boxClasifGastos.Enabled = true;
                llamarclasificadordegastos();
                Documento();
            }

            if (boxtransac.Text == "Depositos")
            {
                bloqueo();
                limpiar();
                boxcredito.Enabled = true;
                txtvalor.Enabled = true;
                txtanombre.Enabled = true;
                txtdes.Enabled = true;
                llamarCuentaspropias(boxcredito);
                boxctacontabledebito.Enabled = true;
                boxctacontablecredito.Enabled = true;
                llamarcuentascontablescredito();
                boxClasifGastos.Enabled = true;
                llamarclasificadordegastos();
                Documento();
            }

            if (boxtransac.Text == "ACH (Pagos por transferencia)")
            {
                bloqueo();
                limpiar();
                boxdebito.Enabled = true;
                txtvalor.Enabled = true;
                txtanombre.Enabled = true;
                txtdes.Enabled = true;
                llamarCuentaspropias(boxdebito);
                txtctacredito.Enabled = true;
                boxctacontabledebito.Enabled = true;
                boxctacontablecredito.Enabled = true;
                llamarcuentascontablescredito();
                boxClasifGastos.Enabled = true;
                llamarclasificadordegastos();
                Documento();
            }

            if (boxtransac.Text == "Transacciones entre Cuentas propias")
            {
                bloqueo();
                limpiar();
                boxcredito.Enabled = true;
                boxdebito.Enabled = true;
                txtanombre.Enabled = true;
                txtvalor.Enabled = true;
                txtdes.Enabled = true;
                boxctacontabledebito.Enabled = true;
                boxctacontablecredito.Enabled = true;
                boxClasifGastos.Enabled = true;
                llamarclasificadordegastos();
                llamarCuentaspropias(boxdebito);
                llamarCuentaspropias(boxcredito);
                llamarcuentascontablescredito();
                Documento();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult asegurarse = MessageBox.Show("¿Está seguro que desea cancelar?\nSe perderán todos los datos ingresados.", "Movimientos Bancarios", MessageBoxButtons.OKCancel);
            if (asegurarse == DialogResult.OK)
            {
                limpiar();
                bloqueo();
            }
            else if (asegurarse == DialogResult.Cancel)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vercampos();
        }


    }
}

