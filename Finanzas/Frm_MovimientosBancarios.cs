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
    {
        //variables para llenar combobox con consultas de BD
        List<string> CuentasConCheques = new List<string>();
        List<string> saldo = new List<string>();
        List<string> NoDoc = new List<string>();
        List<string> ctascontablescredito = new List<string>();
        List<string> ctascontablesdebito = new List<string>();



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
            boxdebito.Items.Clear();
            boxcredito.Items.Clear();
            boxctacontablecredito.Items.Clear();
            boxctacontabledebito.Items.Clear();
        }

        //==============funcion para cheques (llama las cuentas que estan disponibles con chequeras)
        void llamarChequeras()
        {
            //llenar combobox con cuentas con chequeras
            boxdebito.Items.Clear();
            CuentasConCheques.Clear();
            logica logic = new logica();
            CuentasConCheques = logic.LogicaObtenerCuentasBancarias();
            if (CuentasConCheques.Count > 0)
            {
                for (int i = 0; i < CuentasConCheques.Count; i++)
                {
                    boxdebito.Items.Add(CuentasConCheques[i]);
                }
                boxdebito.SelectedIndex = 0;
            }

        }

        //============Verificacion si los campos a ingresar estan llenos y con caracteres permitidos
        void vercampos()
        {
        if (txtvalor.Text.Any(x => !char.IsLetter(x))) 
          {

            if (boxtransac.SelectedItem.ToString() == "Cheques")
            {
                if (txtanombre.Text == "")
                    MessageBox.Show("Por favor, escriba el nombre del beneficiario");        
                else if (txtdes.Text == "")
                    MessageBox.Show("Por favor, escriba una breve descripcion del movimiento");
                    else if (boxClasifGastos.SelectedItem.ToString() == "")
                        MessageBox.Show("Por favor, elija un Clasificador de Gasto");
                    else
                    CrearMovimiento();
            }

            else if(boxtransac.SelectedItem.ToString() == "Depositos")
            {
                     if (txtanombre.Text == "")
                        MessageBox.Show("Por favor, escriba el nombre del beneficiario");
                    else if (txtdes.Text == "")
                        MessageBox.Show("Por favor, escriba una breve descripcion del movimiento");
                    else if (boxClasifGastos.SelectedItem.ToString() == "")
                        MessageBox.Show("Por favor, elija un Clasificador de Gasto");
                  
                    else
                        CrearMovimiento();
                }

            else if(boxtransac.SelectedItem.ToString() == "Transacciones a Cuentas propias")
            {
                    if (txtanombre.Text == "")
                        MessageBox.Show("Por favor, escriba el nombre de quien hace la transaccion");
                    else if (txtdes.Text == "")
                                MessageBox.Show("Por favor, escriba una breve descripcion del movimiento");
                    else
                        CrearMovimiento();
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
            double saldon = 0;
            logica logic = new logica();
            saldo = logic.LogicaVerificarFondosCuentaBancaria(boxdebito.SelectedItem.ToString());
            //conversion lista string a double
            List<double> saldolista = saldo.Select(x => double.Parse(x)).ToList();
            //como solo existe un dato en posicion [0], se pasa a un double para poder restar o sumar más fácil.
            saldon = saldolista[0];
            //Si hay fondos
            if (saldon > 0 && saldon > Convert.ToDouble(txtvalor.Text))
            {
                DialogResult asegurarse = MessageBox.Show("¿Está seguro que desea hacer este movimiento?\nUna vez hecho no se podrá revertir.", "Movimientos Bancarios", MessageBoxButtons.OKCancel);
                if (asegurarse == DialogResult.OK)
                {
                    //Crear Movimiento Bancario Insertar en tabla libro bancos
                    if (boxtransac.SelectedItem.ToString() == "Cheques")
                    {
                        //METODO PARA CREAR CHEQUES
                        //CreacionCheque(string noDoc, string valor,string cuentadebitar,string anombrede, string descripcion,string tipomovimiento,string fecha)
                       CreacionCheque(txtdoc.Text,txtvalor.Text,boxdebito.SelectedItem.ToString(),txtanombre.Text,txtdes.Text,boxtransac.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                       Console.WriteLine("Se hizo un cheque");
                    }

                    else if (boxtransac.SelectedItem.ToString() == "Depositos")
                    {
                       // CreacionDeposito();
                        Console.WriteLine("Se hizo un depósito");
                    }

                    else if (boxtransac.SelectedItem.ToString() == "Transacciones a Cuentas propias")
                    {
                       // CreacionTransaccion();
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
        
        
     void CreacionCheque(string noDoc, string valor,string cuentadebitar,string anombrede, string descripcion,string tipomovimiento,string fecha)
        {
            

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

            }

            if (boxtransac.Text == "Depositos")
            {
                bloqueo();
                limpiar();
                boxcredito.Enabled = true;
                txtvalor.Enabled = true;
                txtanombre.Enabled = true;
                txtdes.Enabled = true;
            }

            if(boxtransac.Text== "Transacciones a Cuentas propias")
            {
                bloqueo();
                limpiar();
                boxcredito.Enabled = true;
                boxdebito.Enabled = true;
                txtanombre.Enabled = true;
                txtvalor.Enabled = true;
                txtdes.Enabled = true;
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
