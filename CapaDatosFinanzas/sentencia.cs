using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosFinanzas
{
    public class sentencia
    {
        conexion con = new conexion();

        public List<string> consultarIdDivisa()
        {
            List<String> resultado = new List<string>();

            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT KidDivisa FROM tbl_divisa", con.conectar());

                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    resultado.Add(almacena.GetString(0));
                }
                almacena.Close();
                sql.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return resultado;
        }

        public List<string> consultarNombreDivisa()
        {
            List<String> resultado = new List<string>();

            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT Nombre FROM tbl_divisa", con.conectar());

                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    resultado.Add(almacena.GetString(0));
                }
                almacena.Close();
                sql.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
          
            return resultado;

        }

        public string obtenerTipoCambio(string sMonedaBase, string sMonedaObjetivo)
        {
            string url = "https://free.currconv.com/api/v7/convert?q=" + sMonedaBase + "_" + sMonedaObjetivo + "&compact=ultra&apiKey=e9c22965a0221aae8dfe";
            var json = new WebClient().DownloadString(url);

            string sJSon = json.ToString();

            int pFrom = sJSon.IndexOf(":") + ":".Length;
            int pTo = sJSon.LastIndexOf("}");

            String result = sJSon.Substring(pFrom, pTo - pFrom).Trim();


            string fecha = DateTime.Now.ToString("yyy/MM/dd");

            try
            {

                OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_tipocambio VALUES ('"
                    + sMonedaBase + "' ,'" +
                    sMonedaObjetivo + "' , " +
                    result + " , '" +
                    fecha +
                    "')", con.conectar());
                sql.ExecuteNonQuery();
                sql.Connection.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

            }


            return result;
        }


        /*--------------------------------------------------- Allan Letona -----------------------------------------------------------------------*/

        public OdbcDataAdapter consultarPolizas(string fechaInicial, string fechaFinal)
        {
            try
            {
                string sqlConsultarPolizas = "SELECT PE.KidPoliza,PE.KidTipoDePoliza ,PD.KidCuenta, PD.Debe, PD.Haber FROM tbl_poliza_encabezado PE INNER JOIN tbl_poliza_detalle PD ON PE.KidPoliza = PD.KidPoliza LEFT JOIN tbl_librodiario LD ON PE.KidPoliza = LD.KidPoliza WHERE LD.KidPoliza IS NULL AND (PE.fecha_poliza BETWEEN '"+fechaInicial+"' AND '"+fechaFinal+"');";
                OdbcDataAdapter dataPolizas = new OdbcDataAdapter(sqlConsultarPolizas, con.conectar());
                return dataPolizas;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter consultarActualizacionPolizas(string fechaInicial, string fechaFinal)
        {
            try
            {
                string sqlConsultarPolizas = "SELECT PE.KidPoliza,PE.KidTipoDePoliza, PD.KidCuenta, PD.Debe, PD.Haber FROM tbl_poliza_encabezado PE INNER JOIN tbl_poliza_detalle PD ON PE.KidPoliza = PD.KidPoliza RIGHT JOIN tbl_librodiario LD ON PE.KidPoliza = LD.KidPoliza WHERE (PE.fecha_poliza BETWEEN '" + fechaInicial + "' AND '" + fechaFinal + "');";
                OdbcDataAdapter dataPolizas = new OdbcDataAdapter(sqlConsultarPolizas, con.conectar());
                return dataPolizas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

     
        public OdbcDataAdapter consultarTipoPolizas()
        {
            try
            {
                string sqlTiposPolizas = "SELECT descripcion FROM tbl_tipo_poliza WHERE estado = 1";
                OdbcDataAdapter dataTipoPolizas = new OdbcDataAdapter(sqlTiposPolizas, con.conectar());
                return dataTipoPolizas;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            
        }

        public string obtenerNombreCuentaContable(string sCodigoCuentaContable)
        {
            string sNombreCuenta = "";
            try
            {
                OdbcCommand sqlCodigoCuenta = new OdbcCommand("SELECT nombre FROM tbl_cuentas WHERE KidCuenta = '" + sCodigoCuentaContable + "' ", con.conectar());
                OdbcDataReader almacena = sqlCodigoCuenta.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sNombreCuenta = almacena.GetString(0);
                }

                return sNombreCuenta;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public OdbcDataAdapter IngresarPolizasLibroDiario(int iCodigoPoliza, string sFecha, double dTotalDebe, double dTotalHaber)
        {
            try
            {

                string sqlInsertarLibroDiario = "INSERT INTO tbl_librodiario(KidPoliza, fecha, total_debe,total_haber, estado) VALUES ('"+iCodigoPoliza+"', '"+sFecha+"', '"+dTotalDebe+"', '"+dTotalHaber+"', 1) ";
                OdbcDataAdapter dataLibroDiario = new OdbcDataAdapter(sqlInsertarLibroDiario, con.conectar());
                return dataLibroDiario;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter ObtenerTotalPoliza(int iCodigoPoliza)
        {
            try
            {
                string sqlObtenerTotalPoliza = "SELECT total_poliza FROM tbl_poliza_encabezado WHERE KidPoliza='"+iCodigoPoliza+"'";
                OdbcDataAdapter dataTotalPoliza = new OdbcDataAdapter(sqlObtenerTotalPoliza, con.conectar());
                return dataTotalPoliza;

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataSet ConsultarCuentasContables()
        {
            OdbcDataAdapter dat = null;
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT C.KidCuenta AS Codigo, TP.nombre_tipoCuenta AS Tipo, C.nombre AS Nombre, C.descripcion AS Descripcion, C.estado AS Estado FROM tbl_cuentas C INNER JOIN tbl_tipocuenta TP ON C.KidTipoCuenta = TP.KidTipoCuenta", con.conectar());
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex);
            }
            return ds;
        }

        public OdbcDataAdapter consultarTipoCuentaContable()
        {
            try
            {
                string sqlTiposCuentasContables = "SELECT nombre_tipoCuenta FROM tbl_tipocuenta WHERE estado = 1";
                OdbcDataAdapter dataTipoCuentasContables = new OdbcDataAdapter(sqlTiposCuentasContables, con.conectar());
                return dataTipoCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }


        public OdbcDataAdapter IngresarCuentasContables(string sCodigoCuenta, string sNombreTipoCuenta, int identificador ,string sNombre, string sDescripcion, string sEstado)
        {
            string sCodigoTipoDeCuenta = "";
            try
            {
                OdbcCommand sqlCodigoTipoCuenta = new OdbcCommand("SELECT KidTipoCuenta FROM tbl_tipocuenta WHERE nombre_tipoCuenta = '" + sNombreTipoCuenta + "' ", con.conectar());
                OdbcDataReader almacena = sqlCodigoTipoCuenta.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sCodigoTipoDeCuenta = almacena.GetString(0);
                }

                string sqlInsertarCuentaContable = "INSERT INTO tbl_cuentas(KidCuenta, KidTipoCuenta, Kidentificador,nombre, descripcion, estado) VALUES ('"+sCodigoCuenta+"', '"+sCodigoTipoDeCuenta+"','"+identificador+"' ,'"+sNombre+"', '"+sDescripcion+"','"+sEstado+"');";
                OdbcDataAdapter dataCuentasContables = new OdbcDataAdapter(sqlInsertarCuentaContable, con.conectar());
                return dataCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public string obtenerCodigoDeTipoDeCuenta(string sNombreTipoCuenta)
        {
            string sCodigoTipoCuenta = "";
            try
            {
                OdbcCommand sqlCodigoCuenta = new OdbcCommand("SELECT KidTipoCuenta FROM tbl_tipocuenta WHERE nombre_tipoCuenta = '" + sNombreTipoCuenta + "' ", con.conectar());
                OdbcDataReader almacena = sqlCodigoCuenta.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sCodigoTipoCuenta = almacena.GetString(0);
                }

                return sCodigoTipoCuenta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public OdbcDataAdapter obtenerMaximoCodigoCuentaContable(string sCodigoTipoCuenta)
        {
            try
            {
                string sqlMaxCuentaContable = "SELECT MAX(C.Kidentificador) FROM tbl_cuentas C INNER JOIN tbl_tipocuenta TP ON C.KidTipoCuenta = TP.KidTipoCuenta WHERE TP.KidTipoCuenta ='" + sCodigoTipoCuenta + "'";
                OdbcDataAdapter dataMaxCuentaContable = new OdbcDataAdapter(sqlMaxCuentaContable, con.conectar());
                return dataMaxCuentaContable;
            }
            catch (Exception ex)
            {   
                Console.WriteLine(ex);
                return null;
            }

        }

       

        public OdbcDataAdapter obtenerMaximoCodigoCuentaContable2(int Identificador)
        {
            try
            {
                string sqlMaxCuentaContable = "SELECT KidCuenta FROM tbl_cuentas WHERE Kidentificador ='" + Identificador + "'";
                OdbcDataAdapter dataMaxCuentaContable = new OdbcDataAdapter(sqlMaxCuentaContable, con.conectar());
                return dataMaxCuentaContable;
            }
            catch (Exception ex)    
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public OdbcDataAdapter ModificarCuentaContable(string sCodigoCuenta, string sNombre, string sDescripcion, string sEstado)
        {
            try
            {
                string sqlModificarCuentaContable = "UPDATE tbl_cuentas SET nombre = '"+sNombre+"', descripcion='"+sDescripcion+"', estado='"+sEstado+"' WHERE KidCuenta = '"+sCodigoCuenta+"';";
                OdbcDataAdapter dataModificarCuentaContable = new OdbcDataAdapter(sqlModificarCuentaContable, con.conectar());
                return dataModificarCuentaContable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public OdbcDataAdapter EliminarCuentaContable(string sCodigoCuenta)
        {
            try
            {
                string sqlModificarCuentaContable = "UPDATE tbl_cuentas SET estado=0 WHERE KidCuenta = '" + sCodigoCuenta + "';";
                OdbcDataAdapter dataModificarCuentaContable = new OdbcDataAdapter(sqlModificarCuentaContable, con.conectar());
                return dataModificarCuentaContable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public OdbcDataAdapter obtenerTotalesDeCuentasContablesDePartidas(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                string sqlTotalesCuentasContables = "SELECT PD.KidCuenta, PD.debe, PD.haber FROM tbl_librodiario LD INNER JOIN tbl_poliza_encabezado PE ON LD.KidPoliza = PE.KidPoliza INNER JOIN tbl_poliza_detalle PD ON PE.KidPoliza = PD.KidPoliza WHERE LD.fecha BETWEEN '"+sFechaInicial+"' AND '"+sFechaFinal+"'";
                OdbcDataAdapter dataTotalesCuentasContables = new OdbcDataAdapter(sqlTotalesCuentasContables, con.conectar());
                return dataTotalesCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter ActualizarDebe_HaberCuentasContables(string sCodigoCuenta, double debe, double haber)
        {
            try
            {
                string sqlActualizarCuentasContables = "UPDATE tbl_cuentas SET debe = debe + '"+debe+"', haber = haber + '"+haber+"' WHERE KidCuenta = '"+sCodigoCuenta+"'";
                OdbcDataAdapter dataActualizarCuentasContables = new OdbcDataAdapter(sqlActualizarCuentasContables, con.conectar());
                return dataActualizarCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public OdbcDataAdapter ObtenerTipoDeCuenta()
        {
            try
            {
                string sqlObtenerTipoDeCuenta = "SELECT KidTipoCuenta, nombre_tipoCuenta FROM tbl_tipocuenta WHERE nombre_tipoCuenta LIKE 'ACT%' or nombre_tipoCuenta LIKE 'PAS%' or nombre_tipoCuenta LIKE 'CAP%'";
                OdbcDataAdapter dataTipoCuenta = new OdbcDataAdapter(sqlObtenerTipoDeCuenta, con.conectar());
                return dataTipoCuenta;

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public OdbcDataAdapter InsertarBalanceGeneral(string codigoCuenta, string fecha, double debe, double haber)
        {
            try
            {
                string sqlInsertarBalanceGeneral = "INSERT INTO tbl_balancegeneral(KidCuenta, fecha_balance, debe, haber,estado) VALUES ('"+codigoCuenta+"', '"+fecha+"', '"+debe+"', '"+haber+"',1)";
                OdbcDataAdapter dataInsertBlanceGeneral = new OdbcDataAdapter(sqlInsertarBalanceGeneral, con.conectar());
                return dataInsertBlanceGeneral;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter ConsultarBalanceGeneralActivoCorriente(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                string sqlConsultarBalance = "SELECT BG.KidCuenta, C.nombre ,SUM(BG.debe), SUM(BG.haber) FROM tbl_balancegeneral BG INNER JOIN tbl_cuentas C ON BG.KidCuenta = C.KidCuenta WHERE BG.KidCuenta LIKE '1.1%' AND fecha_balance BETWEEN '"+sFechaInicial+"' AND '"+sFechaFinal+"' GROUP BY BG.KidCuenta";
                OdbcDataAdapter dataConsultarBalance = new OdbcDataAdapter(sqlConsultarBalance, con.conectar());
                return dataConsultarBalance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter ConsultarBalanceGeneralActivoNoCorriente(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                string sqlConsultarBalance = "SELECT BG.KidCuenta, C.nombre ,SUM(BG.debe), SUM(BG.haber) FROM tbl_balancegeneral BG INNER JOIN tbl_cuentas C ON BG.KidCuenta = C.KidCuenta WHERE BG.KidCuenta LIKE '1.2%' AND fecha_balance BETWEEN '" + sFechaInicial + "' AND '" + sFechaFinal + "' GROUP BY BG.KidCuenta";
                OdbcDataAdapter dataConsultarBalance = new OdbcDataAdapter(sqlConsultarBalance, con.conectar());
                return dataConsultarBalance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

      
        public OdbcDataAdapter ConsultarBalanceGeneralPasivoCorriente(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                string sqlConsultarBalance = "SELECT BG.KidCuenta, C.nombre ,SUM(BG.debe), SUM(BG.haber) FROM tbl_balancegeneral BG INNER JOIN tbl_cuentas C ON BG.KidCuenta = C.KidCuenta WHERE BG.KidCuenta LIKE '2.1%' AND fecha_balance BETWEEN '" + sFechaInicial + "' AND '" + sFechaFinal + "' GROUP BY BG.KidCuenta";
                OdbcDataAdapter dataConsultarBalance = new OdbcDataAdapter(sqlConsultarBalance, con.conectar());
                return dataConsultarBalance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter ConsultarBalanceGeneralPasivoNoCorriente(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                string sqlConsultarBalance = "SELECT BG.KidCuenta, C.nombre ,SUM(BG.debe), SUM(BG.haber) FROM tbl_balancegeneral BG INNER JOIN tbl_cuentas C ON BG.KidCuenta = C.KidCuenta WHERE BG.KidCuenta LIKE '2.2%' AND fecha_balance BETWEEN '" + sFechaInicial + "' AND '" + sFechaFinal + "' GROUP BY BG.KidCuenta";
                OdbcDataAdapter dataConsultarBalance = new OdbcDataAdapter(sqlConsultarBalance, con.conectar());
                return dataConsultarBalance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter ConsultarBalanceGeneralCapital(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                string sqlConsultarBalance = "SELECT BG.KidCuenta, C.nombre ,SUM(BG.debe), SUM(BG.haber) FROM tbl_balancegeneral BG INNER JOIN tbl_cuentas C ON BG.KidCuenta = C.KidCuenta WHERE BG.KidCuenta LIKE '3.1%' AND fecha_balance BETWEEN '" + sFechaInicial + "' AND '" + sFechaFinal + "' GROUP BY BG.KidCuenta";
                OdbcDataAdapter dataConsultarBalance = new OdbcDataAdapter(sqlConsultarBalance, con.conectar());
                return dataConsultarBalance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        /*--------------------------------------------------- Diego Gomez -----------------------------------------------------------------------*/

        public DataSet consultarPresupuesto()
        {
            OdbcDataAdapter dat = null;
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("select Kidpresupuesto as Id,KidMoneda as Divisa,KidArea as Area,KidCuenta as Cuenta,nombre as Nombre,fecha as Fecha,descripcion as Descripcion,monto as Monto,estado as Estado from tbl_presupuesto"
                , con.conectar());
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {

            }
            catch (ArgumentOutOfRangeException ex)
            {

            }

            return ds;
        }

        public DataSet consultarPresupuesto1()
        {
            OdbcDataAdapter dat = null;
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("select Kidpresupuesto as Id,nombre as Nombre,monto as Monto,estado as Estado from tbl_presupuesto"
                , con.conectar());
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {

            }
            catch (ArgumentOutOfRangeException ex)
            {

            }

            return ds;
        }

        public OdbcDataAdapter ConsultarPerfil(string consulta)
        {

            /* string sqlbusqueda = "SELECT tblp.nombre, tblp.fecha, tblp.descripcion, tblp.monto, tblp.estado,tblm.nombre_moneda,tbla.nombreArea, tblc.nombre " +
                  "from tbl_presupuesto as tblp " +
                  "inner join tbl_moneda tblm" +
                  "on tblp.KidMoneda = tblm.kidmoneda" +
                  "inner join tbl_areas tbla" +
                  "on tblp.KidArea = tbla.KidArea" +
                  "inner join tbl_cuentas tblc" +
                  "on tblp.KidCuenta = tblc.KidCuenta" +
                  "where tblp.nombre = '"+consulta+"'";*/

            string sqlbusqueda = "SELECT *from tbl_presupuesto as tblp " +
                "inner join tbl_moneda tblm on tblp.KidMoneda = tblm.kidmoneda " +
                "inner join tbl_areas tbla on tblp.KidArea = tbla.KidArea " +
                "inner join tbl_cuentas tblc on tblp.KidCuenta = tblc.KidCuenta " +
                "where tblp.nombre = '" + consulta + "'";


            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlbusqueda, con.conectar());
            return dataTable;
        }

        public OdbcDataAdapter Gestion(string consulta)

        {

            string sqlbusqueda = "select tpre.nombre as Nombre , tpre.monto as Aceptado , SUM(tpold.debe) as Gasto ,  tpre.monto -  SUM(tpold.debe) as Disponible " +
                " from tbl_presupuesto as tpre " +
                "inner join tbl_tipo_poliza ttpol on tpre.nombre = ttpol.descripcion " +
                "inner join tbl_poliza_encabezado tpole  on ttpol.KidTipoDePoliza = tpole.KidTipoDePoliza " +
                "inner join tbl_poliza_detalle tpold on  tpole.KidPoliza = tpold.KidPoliza " +
                "where tpre.nombre = ttpol.descripcion" +
                " and tpold.KidPoliza = tpole.KidPoliza" +
                " and ttpol.KidTipoDePoliza = tpole.KidTipoDePoliza" +
                " and tpre.nombre = '" + consulta + "'";


            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlbusqueda, con.conectar());
            return dataTable;
        }

        public OdbcDataAdapter Gestion1(string consulta)

        {

            string sqlbusqueda = "select tpre.nombre as Nombre , tpre.monto as Aceptado , SUM(tpold.debe) as Gasto ,  tpre.monto -  SUM(tpold.debe) as Disponible " +
                " from tbl_presupuesto as tpre " +
                "inner join tbl_tipo_poliza ttpol on tpre.nombre = ttpol.descripcion " +
                "inner join tbl_poliza_encabezado tpole  on ttpol.KidTipoDePoliza = tpole.KidTipoDePoliza " +
                "inner join tbl_poliza_detalle tpold on  tpole.KidPoliza = tpold.KidPoliza " +
                "where tpre.nombre = ttpol.descripcion" +
                " and tpold.KidPoliza = tpole.KidPoliza" +
                " and ttpol.KidTipoDePoliza = tpole.KidTipoDePoliza" +
                " and tpre.nombre = '" + consulta + "'";


            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlbusqueda, con.conectar());
            return dataTable;
        }

        public OdbcDataAdapter ActualizarPresupuesto(string consulta)
        {
            try
            {
                string aceptado = "UPDATE tbl_presupuesto set estado = '2' where Kidpresupuesto = '" + consulta + "'";
                OdbcDataAdapter acualizarpresupuesto = new OdbcDataAdapter(aceptado, con.conectar());
                return acualizarpresupuesto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter ActualizarPresupuestoRechazado(string consulta)
        {
            try
            {
                string aceptado = "UPDATE tbl_presupuesto set estado = '0' where Kidpresupuesto = '" + consulta + "'";
                OdbcDataAdapter acualizarpresupuesto = new OdbcDataAdapter(aceptado, con.conectar());
                return acualizarpresupuesto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }



        /* --------------------------------------------------------------------------------------------------------------------------------------------------------------*/




        //Eduardo Colon Conciliacion Bancaria Version 2

        public OdbcDataAdapter consultarBancos()
        {
            string sqlModulos = "SELECT KidBanco, nombre FROM tbl_bancos WHERE estado = 1";
            OdbcDataAdapter dataModulos = new OdbcDataAdapter(sqlModulos, con.conectar());
            return dataModulos;
        }

        public OdbcDataAdapter consultarMonedas()
        {
            string sqlModulos = "SELECT KidDivisa, nombre FROM tbl_divisa WHERE estado = 1";
            OdbcDataAdapter dataModulos = new OdbcDataAdapter(sqlModulos, con.conectar());
            return dataModulos;
        }


        public DataSet consultarLibroBancos(string idBanco, string periodo, string idMoneda)
        {
            DataSet ds;
            try
            {
                ds = new DataSet();
                OdbcDataAdapter dat = new OdbcDataAdapter("SELECT KidMovimientoBancario, cuenta_debito, cuenta_credito, monto, tipo_movimiento, fecha_movimiento " +
        " FROM tbl_libro_bancos WHERE estado = 1 " +
        " AND ( EXISTS (  SELECT tbl_cuentabancaria.KidBanco FROM tbl_cuentabancaria WHERE tbl_cuentabancaria.KidBanco = " + idBanco + " AND " +
        " tbl_cuentabancaria.KidCuentaBancaria = cuenta_debito AND tbl_cuentabancaria.KidMoneda= '" + idMoneda + "') " +
        " OR EXISTS (  SELECT tbl_cuentabancaria.KidBanco FROM tbl_cuentabancaria WHERE tbl_cuentabancaria.KidBanco =  " + idBanco + " AND " +
        " tbl_cuentabancaria.KidCuentaBancaria = cuenta_credito AND tbl_cuentabancaria.KidMoneda= '" + idMoneda + "') ) " +
        " AND fecha_movimiento LIKE '" + periodo + "%' " +
        " AND movimiento_conciliado = 0" 
    , con.conectar()); ;
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                return null;
            }

            return ds;
        }

     
        public DataSet consultarConciliacionBancaria(string idBanco, string periodo, string idMoneda)
        {

            DataSet ds;
            try
            {
                string sql = "SELECT KidConciliacion_Bancaria, mes_conciliacion, diferencia_total " +
        " FROM tbl_conciliacion_bancaria_encabezado WHERE estado = 1 " +
        " AND KidBanco =" + idBanco + " AND moneda = '" + idMoneda +
        "' AND mes_conciliacion = '" + periodo + "' ";
                ds = new DataSet();
                OdbcDataAdapter dat = new OdbcDataAdapter( sql
    , con.conectar()); ;
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                return null;
            }

            return ds;
        }

     

        public DataSet consultarConciliacionBancariaDetalle(string idConciliacion)
        {
            DataSet ds;
            try
            {

                string sql = "SELECT tbl_libro_bancos.KidMovimientoBancario, tbl_libro_bancos.cuenta_debito, tbl_libro_bancos.cuenta_credito, " +
                    " tbl_libro_bancos.monto  , tbl_libro_bancos.tipo_movimiento, tbl_libro_bancos.fecha_movimiento FROM tbl_libro_bancos" +
                    " INNER JOIN tbl_conciliacion_bancaria_detalle ON tbl_libro_bancos.KidMovimientoBancario = tbl_conciliacion_bancaria_detalle.KidMovimientoBancario" +
                    " WHERE tbl_conciliacion_bancaria_detalle.KidConciliacion_Bancaria = " + idConciliacion;
                ds = new DataSet();
                OdbcDataAdapter dat = new OdbcDataAdapter(sql
    , con.conectar()); ;
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                return null;
            }

            return ds;
        }


        public bool consultarCuentaBanco(string idCuenta, string idBanco)
        {
            try
            {
                OdbcCommand sqlCodigoCuenta = new OdbcCommand("SELECT KidCuentaBancaria FROM tbl_cuentabancaria " +
                    " WHERE KidCuentaBancaria = '" + idCuenta + "' AND " +
                    " KidBanco = '" + idBanco + "'", con.conectar());
                OdbcDataReader almacena = sqlCodigoCuenta.ExecuteReader();

                if (almacena.HasRows)
                    return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return false;
        }

        public void actualizarMovmientoBancario(string idMovimiento)
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("UPDATE tbl_libro_bancos SET " +
                    " movimiento_conciliado = 1 WHERE KidMovimientoBancario = " + idMovimiento, con.conectar());
                sql.ExecuteNonQuery();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void insertarConciliacionBancaria(string idBanco, string idMoneda, string periodo, string saldo)
        {
            try
            {

                OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_conciliacion_bancaria_encabezado (KidBanco, moneda, mes_conciliacion, diferencia_total, estado) VALUES ("
                  + idBanco + " ,'" +
                  idMoneda + "' , '" +
                  periodo + "' , " +
                  saldo +  " , 1" +
                  ")  ON DUPLICATE KEY UPDATE diferencia_total=" + saldo, con.conectar());
            sql.ExecuteNonQuery();
            sql.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

//==================================Alejandro Barreda Movimientos Bancarios linea 517===================================================

            //para combobox de movimienntos bancarios
        public List<string> consultarCuentasBancariasconCheques()
        {
            List<String> resultado = new List<string>();
            try
            {
                //llama por medio de Inner join a Numero de Cuenta de tbl_cuentabancaria desde tbl_Chequera
                OdbcCommand sql = new OdbcCommand("SELECT c.NumeroCuenta FROM tbl_cuentabancaria c INNER JOIN tbl_chequera b ON c.KidCuentaBancaria =b.KidCuentabancaria AND b.No_Cheques > 0 AND c.estado=1", con.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    resultado.Add(almacena.GetString(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return resultado;
        }


        //Consulta de Saldos en Cuentas Bancarias para confirmacion si hay fondos disponibles
        public List<string> consultarFondosBancarios(string numeroCuenta)
        {
            List<String> resultado = new List<string>();
            try
            {
                //consulta saldo por medio del numero de cuenta que se le dio con el combobox cuentadébito.
                //Unicamente a las cuentas con estado=1
                OdbcCommand sql = new OdbcCommand("SELECT saldo FROM tbl_cuentabancaria " +
                    " WHERE numerocuenta = '" + numeroCuenta + "'" + " AND estado=1", con.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                if (almacena.HasRows)
                {
                    while (almacena.Read())
                    {
                        resultado.Add(almacena.GetString(0));     
                    }
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);            
            }
            return resultado; 
        }


        //Consultar numero de Documentos de Movimientos Bancarios
        public List<string> ObtenerNoDocMovimiento()
        {
            List<String> resultado = new List<string>();
            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT COUNT(KidMovimientoBancario) + 1 FROM tbl_libro_bancos", con.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    resultado.Add(almacena.GetString(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           return resultado;         
        }

        //INGRESO DE MOVIMIENTOS BANCARIOS
        public OdbcDataAdapter IngresarMovimientoBancario(string ID, string cuenta_debito,string cuenta_credito, string monto, string tipo_movimiento, string fecha_movimiento, string beneficiario, string descripcion, string movimiento_concilidado,
                                                           string movimiento_trasladado_contabilidad, string KidCuenta_contabledebito, string KidCuenta_contablecredito, string KidTipo_movimiento, string estado)
        { 
            try
            {

                string sqlInsertarmovimiento = "INSERT INTO tbl_libro_bancos(KidMovimientoBancario, cuenta_debito, cuenta_credito, monto,tipo_movimiento, fecha_movimiento,beneficiario, descripcion,movimiento_conciliado,movimiento_trasladado_contabilidad, KidCuenta_Contable_debito, KidCuenta_Contable_credito,KiDTipo_movimiento, estado) " +
                                               "VALUES ('"+ID+"','"+ cuenta_debito + "', '" + cuenta_credito + "', '" + monto + "', '" + tipo_movimiento + "', '"+ fecha_movimiento+"', '"+ beneficiario+"', '"+ descripcion + "', '" + movimiento_concilidado + "', '" + movimiento_trasladado_contabilidad + 
                                               "', '" + KidCuenta_contabledebito + "', '" + KidCuenta_contablecredito + "', '" + KidTipo_movimiento + "', 1) ";
                OdbcDataAdapter datamovimiento = new OdbcDataAdapter(sqlInsertarmovimiento, con.conectar());
                return datamovimiento;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        //Cuentas Contablas DEBE y HABER
        public List<string> ObtenerCuentasContables()
        {
            List<String> resultado = new List<string>();
            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT KidCuenta, nombre FROM tbl_cuentas WHERE estado=1", con.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    resultado.Add(almacena.GetString(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return resultado;
        }


        public void insertarConciliacionBancariaDetalle(List<string> lIdMovimientoSeleccionado)
        {
            int idMax;
            try
            {
                OdbcCommand sqlCodigoCuenta = new OdbcCommand("SELECT MAX(KidConciliacion_Bancaria) FROM tbl_conciliacion_bancaria_encabezado ", con.conectar());
                OdbcDataReader almacena = sqlCodigoCuenta.ExecuteReader();

                if (almacena.HasRows)
                {
                    idMax = almacena.GetInt32(0);

                    for (int i = 0; i < lIdMovimientoSeleccionado.Count; i++)
                    {
                        OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_conciliacion_bancaria_detalle (KidConciliacion_Bancaria, KidMovimientoBancario, estado) VALUES ("
                + idMax + " ," + lIdMovimientoSeleccionado[i] + ",  1)", con.conectar());
                        sql.ExecuteNonQuery();
                        sql.Connection.Close();

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        //Actualizar Saldo en CuentasBancarias
        public void actualizarSaldoBancario(string cuenta, double monto)
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("UPDATE tbl_cuentabancaria SET " +
                    " saldo = '" + monto + "' WHERE NumeroCuenta = " + cuenta, con.conectar());
                sql.ExecuteNonQuery();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }



    //llamar Cuentas Bancarias
    public List<string> consultarCuentasBancarias()
    {
        List<String> resultado = new List<string>();
        try
        {
            //llama por medio de Inner join a Numero de Cuenta de tbl_cuentabancaria desde tbl_Chequera
            OdbcCommand sql = new OdbcCommand("SELECT c.NumeroCuenta FROM tbl_cuentabancaria c WHERE c.estado=1", con.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                resultado.Add(almacena.GetString(0));
            }
            almacena.Close();
            sql.Connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        return resultado;
    }



    public List<string> consultarNoCheques(string cuenta)
        {
            List<String> resultado = new List<string>();
            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT c.No_Cheques FROM tbl_chequera c INNER JOIN tbl_cuentabancaria b ON c.KidCuentaBancaria =b.KidCuentabancaria AND c.estado=1 AND b.estado=1 AND b.NumeroCuenta='" + cuenta + "'", con.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    resultado.Add(almacena.GetString(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return resultado;
        }


        //Actualizar cheques a chequera
        public void actualizarcheques(string cuenta,int chequesactuales)
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("UPDATE tbl_chequera SET " +
                    " No_cheques = '" + chequesactuales + "' WHERE KidCuentaBancaria = (Select a.KidCuentaBancaria FROM tbl_cuentabancaria a WHERE a.NumeroCuenta = '" + cuenta+"')", con.conectar());
                sql.ExecuteNonQuery();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public OdbcDataAdapter ConsultarCuentasContables1()
        {
            string sqlModulos = "SELECT KidCuenta, nombre FROM tbl_cuentas WHERE estado = 1";
            OdbcDataAdapter dataModulos = new OdbcDataAdapter(sqlModulos, con.conectar());
            return dataModulos;
        }


        public OdbcDataAdapter ObtenerClasificadorGastos()
        {
            string sqlModulos = "SELECT KidTipoMovimiento, nombre FROM tbl_tipo_movimiento WHERE estado=1";
            OdbcDataAdapter dataModulos = new OdbcDataAdapter(sqlModulos, con.conectar());
            return dataModulos;
        }



    

    

        //Eduardo Colon envio de polizas
        public OdbcDataAdapter consultarCuentasEnvioPolizas()
        {
            string sqlModulos = "SELECT KidCuenta, nombre FROM tbl_cuentas WHERE estado = 1";
            OdbcDataAdapter dataModulos = new OdbcDataAdapter(sqlModulos, con.conectar());
            return dataModulos;
        }

        public DataSet consultarLibroBancosEnvioPolizas(string fechaInicial, string fechaFinal)
        {
            DataSet ds;
            try
            {
                ds = new DataSet();
                OdbcDataAdapter dat = new OdbcDataAdapter("SELECT KidMovimientoBancario, (SELECT tbl_cuentas.nombre FROM tbl_cuentas WHERE tbl_cuentas.KidCuenta = tbl_libro_bancos.KidCuenta_Contable_Debito) as Cuenta_Debito, " +
                    " (SELECT tbl_cuentas.nombre FROM tbl_cuentas WHERE tbl_cuentas.KidCuenta = tbl_libro_bancos.KidCuenta_Contable_Credito) as Cuenta_Credito, " +
                    "monto, tipo_movimiento, fecha_movimiento " +
        " FROM tbl_libro_bancos WHERE estado = 1 " +
        " AND movimiento_trasladado_contabilidad = 0 " +
        " AND fecha_movimiento between '" + fechaInicial + "' AND '" + fechaFinal + "'"
    , con.conectar()); ;
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                return null;
            }

            return ds;

        }

        public int consultarMaxpoliza()
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT MAX(KidPoliza) FROM tbl_poliza_encabezado", con.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();

                if (almacena.HasRows)
                {
                    return almacena.GetInt32(0);
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return 0;
        }

        public string consultarNombreCuentaContable(string v)
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT KidCuenta FROM tbl_cuentas WHERE nombre = '" + v + "'", con.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();

                if (almacena.HasRows)
                {
                    return almacena.GetString(0);
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }


        public void marcarMovimientoEnviadoContabilidad(List<string> idMovimiento)
        {
           
            for(int i = 0; i < idMovimiento.Count; i++)
            {
                try
                {
                    OdbcCommand sql = new OdbcCommand("UPDATE tbl_libro_bancos SET " +
                        " movimiento_trasladado_contabilidad = 1 WHERE KidMovimientoBancario = " + idMovimiento[i], con.conectar());
                    sql.ExecuteNonQuery();
                    sql.Connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }

        public bool insertarPolizaEncabezado(string documento, string descripcion, string fecha, string total)
        {

            try
            {
                string stringSql = "INSERT INTO tbl_poliza_encabezado (KidTipoDePoliza, KidDocumentoAsociado, descripcion, fecha_poliza, total_poliza, estado) " +
                    " VALUES ('B', '" + documento + "', '" + descripcion + "', '" + fecha + "', " + total + ",1)";

                OdbcCommand sql = new OdbcCommand(stringSql, con.conectar());
                sql.ExecuteNonQuery();
                sql.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }

        public bool insertarPolizaDetalle(int numeroPoliza, List<string> nuevaListaCuentas, List<double> nuevosMontosDebe, List<double> nuevosMontosHaber)
        {

            OdbcConnection connection = con.conectar();
            OdbcCommand sql = new OdbcCommand();
            try
            {

                for (int i = 0; i < nuevaListaCuentas.Count; i++)
                {
                    string stringSql = "INSERT INTO tbl_poliza_detalle (KidPoliza, KidCuenta, debe, haber) " +
                       " VALUES ( " + numeroPoliza + " , '" + nuevaListaCuentas[i] + "', " + nuevosMontosDebe[i] + ", " + nuevosMontosHaber[i] +")";

                     sql = new OdbcCommand(stringSql, connection);
                    sql.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            sql.Connection.Close();
            return true;
        }


    }

}
