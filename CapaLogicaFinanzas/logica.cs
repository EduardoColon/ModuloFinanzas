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

        public DataTable consultaLogicaPolizas(string fechaInicial, string fechaFinal, string TipoDePoliza)
        {
            try
            {
                OdbcDataAdapter dtPolizas = sen.consultarPolizas(fechaInicial, fechaFinal, TipoDePoliza);
                DataTable tablePolizas = new DataTable();
                dtPolizas.Fill(tablePolizas);
                return tablePolizas;

            }catch(Exception ex)
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

        /*-------------------------------------------------------------Diego Gomez------------------------------------------------------------*/

        public DataSet consultaLogicaBitacora()
        {
            return sen.consultarBitacora();
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


        public DataSet consultaLogicaLibroBancos(string idBanco, string periodo)
        {
            return sen.consultarLibroBancos(idBanco, periodo);
        }
    }
}
