﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosFinanzas;
using System.Data.Odbc;
using System.Data;

namespace CapaLogicaFinanzas
{
    public class logica
    {
        sentencia sen = new sentencia();

        public logica()
        {

        }

        public List<string> obtenerIdDivisa()
        {
            List<String> resultado = new List<string>();

            try
            {
                resultado = sen.consultarIdDivisa();
            }catch(Exception ex)
            {
                
            }
      
            return resultado;
     

        }

        public List<string> obtenerNombreMoneda()
        {
            List<String> resultado = new List<string>();

            try
            {
                resultado = sen.consultarNombreDivisa();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return resultado;

        }

      

        public string consultarTipoCambio(string sMonedaBase, string sMonedaObjetivo)
        {

            string resultado = "";

            try
            {
                resultado = sen.obtenerTipoCambio(sMonedaBase, sMonedaObjetivo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return resultado;
        }


        /*-------------------------------------------------------------Allan Letona------------------------------------------------------------*/

        public DataTable consultaLogicaPolizas(string fechaInicial, string fechaFinal)
        {
            try
            {
                OdbcDataAdapter dtPolizas = sen.consultarPolizas(fechaInicial, fechaFinal);
                DataTable tablePolizas = new DataTable();
                dtPolizas.Fill(tablePolizas);
                return tablePolizas;

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaActualizacionPolizas(string fechaInicial, string fechaFinal)
        {
            try
            {
                OdbcDataAdapter dtPolizas = sen.consultarActualizacionPolizas(fechaInicial, fechaFinal);
                DataTable tablePolizas = new DataTable();
                dtPolizas.Fill(tablePolizas);
                return tablePolizas;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

   
        public DataTable consultaLogicaTipoPolizas()
        {
            try
            {
                OdbcDataAdapter dtTipoPolizas = sen.consultarTipoPolizas();
                DataTable tableTipoPolizas = new DataTable();
                dtTipoPolizas.Fill(tableTipoPolizas);
                return tableTipoPolizas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public string consultaLogicaNombreCuentaContable(string sCodigoCuentaContable)
        {
            try
            {
                string sNombreCuenta = sen.obtenerNombreCuentaContable(sCodigoCuentaContable);

                return sNombreCuenta;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaIngresarLibroDiario(int iCodigoPoliza, string sFecha, double dTotalDebe, double dTotalHaber)
        {
            try
            {
                OdbcDataAdapter dtIngresoLibroDiario = sen.IngresarPolizasLibroDiario(iCodigoPoliza, sFecha, dTotalDebe, dTotalHaber);
                DataTable tableIngresoLibroDiario = new DataTable();
                dtIngresoLibroDiario.Fill(tableIngresoLibroDiario);
                return tableIngresoLibroDiario;

            }catch(Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }

     

        public DataTable consultaLogicaObtenerTotalPoliza(int iCodigoPoliza)
        {
            try
            {
                OdbcDataAdapter dtObtenerTotalPoliza = sen.ObtenerTotalPoliza(iCodigoPoliza);
                DataTable tableObtenerTotalPoliza = new DataTable();
                dtObtenerTotalPoliza.Fill(tableObtenerTotalPoliza);
                return tableObtenerTotalPoliza;
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }



        public DataSet consultaLogicaCuentasContables()
        {
            return sen.ConsultarCuentasContables();
        }


        public DataTable consultaLogicaTipoCuentaContable()
        {
            try
            {
                OdbcDataAdapter dtTipoCuentasContables = sen.consultarTipoCuentaContable();
                DataTable tableTipoCuentasContables = new DataTable();
                dtTipoCuentasContables.Fill(tableTipoCuentasContables);
                return tableTipoCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaIngresoCuentasContables(string sCodigoCuenta, string sNombreTipoCuenta,int identificador ,string sNombre, string sDescripcion, string sEstado)
        {
            try
            {
                OdbcDataAdapter dtCuentasContables = sen.IngresarCuentasContables(sCodigoCuenta, sNombreTipoCuenta,identificador, sNombre, sDescripcion, sEstado);
                DataTable tableCuentasContables = new DataTable();
                dtCuentasContables.Fill(tableCuentasContables);
                return tableCuentasContables;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public string consultaLogicaCodigoDeTipoDeCuenta(string sNombreTipoCuenta)
        {
            try
            {
                string sCodigoTipoCuenta = sen.obtenerCodigoDeTipoDeCuenta(sNombreTipoCuenta);

                return sCodigoTipoCuenta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable consultaLogicaMaxCuentaContable(string sCodigoTipoCuenta)
        {
            try
            {
                OdbcDataAdapter dtMaxCuentasContables = sen.obtenerMaximoCodigoCuentaContable(sCodigoTipoCuenta);
                DataTable tableMaxCuentasContables = new DataTable();
                dtMaxCuentasContables.Fill(tableMaxCuentasContables);
                return tableMaxCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaMaxCuentaContable2(int Identificador)
        {
            try
            {
                OdbcDataAdapter dtMaxCuentasContables = sen.obtenerMaximoCodigoCuentaContable2(Identificador);
                DataTable tableMaxCuentasContables = new DataTable();
                dtMaxCuentasContables.Fill(tableMaxCuentasContables);
                return tableMaxCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaModificarCuenta(string sCodigoCuenta, string sNombre, string sDescripcion, string sEstado)
        {
            try
            {
                OdbcDataAdapter dtModificarCuenta = sen.ModificarCuentaContable(sCodigoCuenta, sNombre, sDescripcion, sEstado);
                DataTable tableModificarCuenta = new DataTable();
                dtModificarCuenta.Fill(tableModificarCuenta);
                return tableModificarCuenta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaEliminarCuentaContable(string sCodigoCuenta)
        {
            try
            {
                OdbcDataAdapter dtEliminarCuenta = sen.EliminarCuentaContable(sCodigoCuenta);
                DataTable tableEliminarCuenta = new DataTable();
                dtEliminarCuenta.Fill(tableEliminarCuenta);
                return tableEliminarCuenta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaObtenerTotalesCuentasContables(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                OdbcDataAdapter dtTotalesCuentasContables = sen.obtenerTotalesDeCuentasContablesDePartidas(sFechaInicial, sFechaFinal);
                DataTable tableTotalesCuentasContables = new DataTable();
                dtTotalesCuentasContables.Fill(tableTotalesCuentasContables);
                return tableTotalesCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaActualizarDebe_HaberCuentasContables(string sCodigoCuenta, double debe, double haber)
        {
            try
            {
                OdbcDataAdapter dtActualizarCuentasContables = sen.ActualizarDebe_HaberCuentasContables(sCodigoCuenta, debe, haber);
                DataTable tableActualizarCuentasContables = new DataTable();
                dtActualizarCuentasContables.Fill(tableActualizarCuentasContables);
                return tableActualizarCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable consultaLogicaObtenerTipoDeCuenta()
        {
            try
            {
                OdbcDataAdapter dtObtenerTipoCuenta = sen.ObtenerTipoDeCuenta();
                DataTable tableTipoDeCuenta = new DataTable();
                dtObtenerTipoCuenta.Fill(tableTipoDeCuenta);
                return tableTipoDeCuenta;

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable consultaLogicaInsertarBalanceGeneral(string codigoCuenta, string fecha, double debe, double haber)
        {
            try
            {
                OdbcDataAdapter dtInsertarBalanceGeneral = sen.InsertarBalanceGeneral(codigoCuenta, fecha, debe, haber);
                DataTable tableBalanceGeneral = new DataTable();
                dtInsertarBalanceGeneral.Fill(tableBalanceGeneral);
                return tableBalanceGeneral;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable consultaLogicaConsultarBalanceGeneralActivoCorriente(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                OdbcDataAdapter dtConsultarBalanceGeneral = sen.ConsultarBalanceGeneralActivoCorriente(sFechaInicial, sFechaFinal);
                DataTable tableBalanceGeneral = new DataTable();
                dtConsultarBalanceGeneral.Fill(tableBalanceGeneral);
                return tableBalanceGeneral;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaConsultarBalanceGeneralActivoNoCorriente(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                OdbcDataAdapter dtConsultarBalanceGeneral = sen.ConsultarBalanceGeneralActivoNoCorriente(sFechaInicial, sFechaFinal);
                DataTable tableBalanceGeneral = new DataTable();
                dtConsultarBalanceGeneral.Fill(tableBalanceGeneral);
                return tableBalanceGeneral;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaConsultarBalanceGeneralPasivoCorriente(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                OdbcDataAdapter dtConsultarBalanceGeneral = sen.ConsultarBalanceGeneralPasivoCorriente(sFechaInicial, sFechaFinal);
                DataTable tableBalanceGeneral = new DataTable();
                dtConsultarBalanceGeneral.Fill(tableBalanceGeneral);
                return tableBalanceGeneral;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaConsultarBalanceGeneralPasivoNoCorriente(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                OdbcDataAdapter dtConsultarBalanceGeneral = sen.ConsultarBalanceGeneralPasivoNoCorriente(sFechaInicial, sFechaFinal);
                DataTable tableBalanceGeneral = new DataTable();
                dtConsultarBalanceGeneral.Fill(tableBalanceGeneral);
                return tableBalanceGeneral;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaConsultarBalanceGeneralCapital(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                OdbcDataAdapter dtConsultarBalanceGeneral = sen.ConsultarBalanceGeneralCapital(sFechaInicial, sFechaFinal);
                DataTable tableBalanceGeneral = new DataTable();
                dtConsultarBalanceGeneral.Fill(tableBalanceGeneral);
                return tableBalanceGeneral;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaBalanceDeSaldos(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                OdbcDataAdapter dtBalanceDeSaldos = sen.BalanceDeSaldos(sFechaInicial, sFechaFinal);
                DataTable tableBalanceDeSaldos = new DataTable();
                dtBalanceDeSaldos.Fill(tableBalanceDeSaldos);
                return tableBalanceDeSaldos;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        /*-------------------------------------------------------------Diego Gomez------------------------------------------------------------*/

        public DataSet consultaLogicapresupuesto()
        {
            return sen.consultarPresupuesto();
        }

        public DataSet consultaPresupuesto()
        {
            return sen.consultarPresupuesto1();
        }

        public DataSet consultaIngresos()
        {
            return sen.consultarIngreso();
        }

        public DataSet TotalIngresos()
        {
            return sen.consultarTotalIngreso();
        }

        public DataSet TotalEgresos()
        {
            return sen.consultarTotalEgresos();
        }

        public DataSet consultaEgresos()
        {
            return sen.consultarEgreso();
        }

        public DataSet Saldo()
        {
            return sen.consultarSaldo();
        }

        public DataTable ConsultaLogicaPerfil(string consultabu)
        {
            try
            {
                OdbcDataAdapter cmpsperfiles = sen.ConsultarPerfil(consultabu);
                DataTable tablaperfiles = new DataTable();
                cmpsperfiles.Fill(tablaperfiles);
                return tablaperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable datos(string consultabu)
        {
            try
            {
                OdbcDataAdapter cmpsperfiles = sen.Gestion(consultabu);
                DataTable tablaperfiles = new DataTable();
                cmpsperfiles.Fill(tablaperfiles);
                return tablaperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable datos1(string consultabu)
        {
            try
            {
                OdbcDataAdapter cmpsperfiles = sen.Gestion1(consultabu);
                DataTable tablaperfiles = new DataTable();
                cmpsperfiles.Fill(tablaperfiles);
                return tablaperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }



        public DataTable PresupuestoAprobado(string consultabu)
        {
            try
            {
                OdbcDataAdapter cmpsperfiles = sen.ActualizarPresupuesto(consultabu);
                DataTable aprobado = new DataTable();
                cmpsperfiles.Fill(aprobado);
                return aprobado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable PresupuestoRechazado(string consultabu)
        {
            try
            {
                OdbcDataAdapter cmpsperfiles = sen.ActualizarPresupuestoRechazado(consultabu);
                DataTable aprobado = new DataTable();
                cmpsperfiles.Fill(aprobado);
                return aprobado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        // Eduardo Colon Conciliacion Bancaria Version 2

        public DataTable consultaLogicaBancos()
        {
            try
            {
                OdbcDataAdapter dtModulos = sen.consultarBancos();
                DataTable tableModulos = new DataTable();
                dtModulos.Fill(tableModulos);
                return tableModulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaMonedas()
        {
            try
            {
                OdbcDataAdapter dtModulos = sen.consultarMonedas();
                DataTable tableModulos = new DataTable();
                dtModulos.Fill(tableModulos);
                return tableModulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }



        public DataSet consultaLogicaLibroBancos(string idBanco, string periodo, string idMoneda)
        {
            try
            {
                return sen.consultarLibroBancos(idBanco, periodo, idMoneda);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataSet consultaLogicaConciliacionBancaria(string idBanco, string periodo, string idMoneda)
        {
            try
            {
                return sen.consultarConciliacionBancaria(idBanco, periodo, idMoneda);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataSet consultaLogicaConciliacionBancariaDetalle(string idConciliacion)
        {
            try
            {
                return sen.consultarConciliacionBancariaDetalle(idConciliacion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool ConsultaLogicaCuentaBanco(string idBanco, string idCuenta)
        {
            try
            {
                return sen.consultarCuentaBanco(idCuenta, idBanco);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        public void registrarMovimientoConciliado(string idMovimiento)
        {
            try
            {
                sen.actualizarMovmientoBancario(idMovimiento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public bool registrarConciliacionBancaria(string idBanco, string idMoneda, string periodo, string saldo)
        {
            try
            {
                sen.insertarConciliacionBancaria(idBanco, idMoneda, periodo, saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return true;
        }

        //============================Alejandro Barreda- Logica Movimientos bancarios=========================
        public List<string> LogicaObtenerCuentasBancariasconCheques()
        {
            List<String> resultado = new List<string>();
            try
            {
                resultado = sen.consultarCuentasBancariasconCheques();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return resultado;

        }

        public void registrarConciliacionBancariaDetalle(List<string> lIdMovimientoSeleccionado)
        {
            try
            {
                sen.insertarConciliacionBancariaDetalle(lIdMovimientoSeleccionado);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        public List<string> LogicaVerificarFondosCuentaBancaria(string numeroCuenta)
        {
            List<String> resultado = new List<string>();
            try
            {
               resultado = sen.consultarFondosBancarios(numeroCuenta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);               
            }
            return resultado;
        }

        public List<string> LogicaObtenerNoDocBancario()
        {
            List<String> resultado = new List<string>();

            try
            {
                resultado = sen.ObtenerNoDocMovimiento();
            }
            catch (Exception ex)
            {

            }
            return resultado;
        }


        public DataTable LogicaIngresarMovimientoBancario(string ID,string cuenta_debito,string cuenta_credito, string monto, string tipo_movimiento, string fecha_movimiento, string beneficiario, string descripcion, string movimiento_concilidado,
                                                           string movimiento_trasladado_contabilidad, string KidCuenta_contabledebito, string KidCuenta_contablecredito, string KidTipo_movimiento, string estado)
        {
            try
            {
                OdbcDataAdapter dtIngresomov1 = sen.IngresarMovimientoBancario(ID,cuenta_debito, cuenta_credito,  monto, tipo_movimiento, fecha_movimiento, beneficiario,  descripcion, movimiento_concilidado, movimiento_trasladado_contabilidad, KidCuenta_contabledebito, KidCuenta_contablecredito,KidTipo_movimiento, estado);
         DataTable tableIngresomov = new DataTable();
                dtIngresomov1.Fill(tableIngresomov);
                return tableIngresomov;

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }
       

       


        public void LogicaActualizarSaldoBancario(string cuenta, double saldo)
        {
            try
            {
                sen.actualizarSaldoBancario(cuenta,saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        public List<string> LogicaObtenerCuentasBancarias()
        {
            List<String> resultado = new List<string>();
            try
            {
                resultado = sen.consultarCuentasBancarias();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return resultado;
        }

        public List<string> LogicaObtenerNoCheques(string cuenta)
        {
            List<String> resultado = new List<string>();
            try
            {
                resultado = sen.consultarNoCheques(cuenta);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }
            return resultado;
        }


        public void LogicaActualizarCheques(string cuenta, int chequesactuales)
        {
            try
            {
                sen.actualizarcheques(cuenta, chequesactuales);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        public DataTable consultaLogicaCuentasContables1()
        {
            try
            {
                OdbcDataAdapter dtModulos = sen.ConsultarCuentasContables1();
                DataTable tableModulos = new DataTable();
                dtModulos.Fill(tableModulos);
                return tableModulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }
//===========================================================================================================


        //Eduardo Colon envio polizas

        public DataTable consultaLogicaCuentasEnvioPolizas()
        {
            try
            {
                OdbcDataAdapter dtModulos = sen.consultarCuentasEnvioPolizas();

                DataTable tableModulos = new DataTable();
                dtModulos.Fill(tableModulos);
                return tableModulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }


        }



        public DataTable LogicaObtenerClasificadorGastos()
        {
            try
            {
                OdbcDataAdapter dtModulos = sen.ObtenerClasificadorGastos();
                DataTable tableModulos = new DataTable();
                dtModulos.Fill(tableModulos);
                return tableModulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }



        public DataSet consultaLogicaLibroBancosEnvioPoliza(string fechaInicial, string fechaFinal)
        {
            try
            {
                return sen.consultarLibroBancosEnvioPolizas(fechaInicial, fechaFinal);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public int consultarMaxPoliza()
        {
            return sen.consultarMaxpoliza() + 1;
        }

        public string consultarNombreCuentaContable(string v)
        {
            return sen.consultarNombreCuentaContable(v);
        }

        public bool insertarPolizaEncabezado(string documento, string descripcion, string fecha, string total)
        {
            try
            {
                return sen.insertarPolizaEncabezado(documento, descripcion, fecha, total);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public void marcarMovimientoEnviadoContabilidad(List<string> idMovimiento)
        {
           sen.marcarMovimientoEnviadoContabilidad(idMovimiento);
        }

        public bool insertarPolizaDetalle(int numeroPoliza, List<string> idCuentaDebe, List<string> idCuentaHaber, List<string> monto)
        {
            List<double> nuevosMontosDebe = new List<double>();
            List<double> nuevosMontosHaber = new List<double>();
            List<string> nuevaListaCuentas = new List<string>();

            for (int i = 0; i < idCuentaDebe.Count; i++)
            {
                if (!nuevaListaCuentas.Contains(idCuentaDebe[i]))
                {
                    nuevaListaCuentas.Add(idCuentaDebe[i]);
                    nuevosMontosDebe.Add(0.00);
                    nuevosMontosHaber.Add(0.00);
                }
            }

            for (int i = 0; i < idCuentaHaber.Count; i++)
            {
                if (!nuevaListaCuentas.Contains(idCuentaHaber[i]))
                {
                    nuevaListaCuentas.Add(idCuentaHaber[i]);
                    nuevosMontosHaber.Add(0.00);
                    nuevosMontosDebe.Add(0.00);

                }
            }

            for (int i = 0; i < nuevaListaCuentas.Count; i++)
            {
                for (int j = 0; j < idCuentaDebe.Count; j++)
                {
                    if (nuevaListaCuentas[i] == idCuentaDebe[j])
                    {
                        nuevosMontosDebe[i] = nuevosMontosDebe[i] + double.Parse(monto[j]);
                    }

                    if (nuevaListaCuentas[i] == idCuentaHaber[j])
                    {
                        nuevosMontosHaber[i] = nuevosMontosHaber[i] + double.Parse(monto[j]);
                    }
                }
            }

            try
            {
                return sen.insertarPolizaDetalle(numeroPoliza, nuevaListaCuentas, nuevosMontosDebe, nuevosMontosHaber);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
